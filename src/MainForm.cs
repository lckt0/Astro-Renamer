using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;
using System;
using System.Windows.Forms;

namespace Astro_Renamer
{
    public partial class MainForm : Form
    {
        string[] arguments = { };
        public MainForm(string[] args)
        {
            arguments = args;
            InitializeComponent();
            this.ActiveControl = btnStart;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            processProgress.Value = 100;

            bool classBool = rnClass.Checked;
            bool asmblyBool = rnAsmbly.Checked;
            bool mduleBool = rnMdule.Checked;
            bool methodBool = rnMethod.Checked;
            bool fileBool = rnFile.Checked;
            bool stringBool = rnString.Checked;
            bool propertyBool = rnProperty.Checked;
            bool fieldBool = rnField.Checked;
            bool eventdefBool = rnEventdef.Checked;
            bool resourcesBool = rnResources.Checked;
            bool asmblyInfoBool = rnAsmblyInfo.Checked;

            string loadPath = fileLocationBox.Text;
            ModuleDefMD module = null;
            try
            {
                module = ModuleDefMD.Load(loadPath);
            }
            catch
            {
                MessageBox.Show("Entered file location is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processProgress.Value = 0;
                btnStart.Enabled = true;
                return;
            }

            string oldValue = originalStrBox.Text;
            string newValue = renamedStrBox.Text;

            int countx = RenameProcess(module, oldValue, newValue, classBool, asmblyBool, mduleBool, methodBool, fileBool, stringBool, propertyBool, fieldBool, eventdefBool, resourcesBool, asmblyInfoBool);

            string file = loadPath;

            try
            {
                if (file.ToLower().EndsWith(".exe"))
                {
                    string newname = file.Substring(0, file.Length - 4) + "-astro.exe";
                    if (newname.Contains(oldValue) && fileBool)
                    {
                        newname = newname.Replace(oldValue, newValue);
                    }
                    var path = newname;
                    module.Write(path,
                    new ModuleWriterOptions(module)
                    {
                        PEHeadersOptions = {
                            NumberOfRvaAndSizes = 13
                        },
                        Logger =
                        DummyLogger.NoThrowInstance
                    });
                }
                if (file.ToLower().EndsWith(".dll"))
                {
                    string newname = file.Substring(0, file.Length - 4) + "-astro.dll";
                    if (newname.Contains(oldValue) && fileBool)
                    {
                        newname = newname.Replace(oldValue, newValue);
                    }
                    var path = newname;
                    module.Write(path,
                    new ModuleWriterOptions(module)
                    {
                        PEHeadersOptions = {
                            NumberOfRvaAndSizes = 13
                        },
                        Logger =
                        DummyLogger.NoThrowInstance
                    });
                }
                if (arguments.Length > 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("Rename process is successfully completed!\nRenamed Things: " + countx, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show($"An error occured while saving file!\nException: {a.Message.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            processProgress.Value = 0;
            btnStart.Enabled = true;
        }

        private int RenameProcess(ModuleDefMD moduleDef, string originalStr, string renamedStr, bool classBool, bool asmblyBool, bool mduleBool, bool methodBool, bool fileBool, bool stringBool, bool propertyBool, bool fieldBool, bool eventdefBool, bool resourcesBool, bool asmblyInfoBool)
        {
            int count = 0;
            foreach (TypeDef type in moduleDef.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;
                foreach (MethodDef methodDef in type.Methods)
                {
                    if (!methodDef.HasBody || !methodDef.Body.HasInstructions) continue;
                    for (var i = 0; i < methodDef.Body.Instructions.Count; i++)
                    {
                        if (methodDef.Body.Instructions[i].OpCode != OpCodes.Ldstr) continue;
                        var plainText = methodDef.Body.Instructions[i].Operand.ToString();
                        var operand = plainText;
                        if (plainText.Contains(originalStr) && stringBool)
                        {
                            Loglist("Replaced: " + operand);
                            operand = plainText.Replace(originalStr, renamedStr);
                            count++;
                        }
                        methodDef.Body.Instructions[i].Operand = operand;
                    }
                    methodDef.Body.SimplifyBranches();
                }

                if (type.Name.Contains(originalStr) && classBool)
                {
                    Loglist("Replaced: " + type.Name);
                    type.Name = type.Name.Replace(originalStr, renamedStr);
                    count++;
                }
                foreach (PropertyDef property in type.Properties)
                {
                    if (property.Name.Contains(originalStr) && propertyBool)
                    {
                        Loglist("Replaced: " + property.Name);
                        property.Name = property.Name.Replace(originalStr, renamedStr);
                        count++;
                    }
                }
                foreach (FieldDef fields in type.Fields)
                {
                    if (fields.Name.Contains(originalStr) && fieldBool)
                    {
                        Loglist("Replaced: " + fields.Name);
                        fields.Name = fields.Name.Replace(originalStr, renamedStr);
                        count++;
                    }
                }
                foreach (EventDef eventdef in type.Events)
                {
                    if (eventdef.Name.Contains(originalStr) && eventdefBool)
                    {
                        Loglist("Replaced: " + eventdef.Name);
                        eventdef.Name = eventdef.Name.Replace(originalStr, renamedStr);
                        count++;
                    }
                }
                foreach (MethodDef method in type.Methods)
                {
                    if (method.IsConstructor) continue;
                    if (method.Name.Contains(originalStr) && methodBool)
                    {
                        Loglist("Replaced: " + method.Name);
                        method.Name = method.Name.Replace(originalStr, renamedStr);
                        count++;
                    }
                }
            }
            if (moduleDef.Name.Contains(originalStr) && mduleBool)
            {
                Loglist("Replaced: " + moduleDef.Name);
                moduleDef.Name = moduleDef.Name.Replace(originalStr, renamedStr);
                count++;
            }
            if (moduleDef.Assembly.Name.Contains(originalStr) && asmblyBool)
            {
                Loglist("Replaced: " + moduleDef.Assembly.Name);
                moduleDef.Assembly.Name = moduleDef.Assembly.Name.Replace(originalStr, renamedStr);
                count++;
            }

            foreach (Resource res in moduleDef.Resources)
            {
                if (res.Name.Contains(originalStr) && resourcesBool)
                {
                    Loglist("Replaced: " + res.Name);
                    res.Name = res.Name.Replace(originalStr, renamedStr);
                    count++;
                }
            }

            /*
            //ASSEMBLY INFO RENAME
            if (asmblyInfoBool)
            {
                moduleDef.Assembly.Version = new Version(123,123,123,123);

                string ls = "";

                foreach (CustomAttribute item in moduleDef.Assembly.CustomAttributes)
                {
                    if (item.HasConstructorArguments)
                    {
                        foreach (var item2 in item.ConstructorArguments)
                        {
                            if (item2.Value.ToString().Contains(originalStr))
                            {
                                item2.Value = item2.Value.ToString().Replace(originalStr, renamedStr);
                            }
                        }
                    }

                    if (item.HasNamedArguments)
                    {
                        foreach (var item2 in item.NamedArguments)
                        {
                            if (item2.Value.ToString().Contains(originalStr))
                            {
                                item2.Value = item2.Value.ToString().Replace(originalStr, renamedStr);
                            }
                        }
                    }
                }

                System.IO.File.WriteAllText($"C:\\Users\\{Environment.UserName}\\Desktop\\testAttr.txt",ls);
                ls = "";

                MessageBox.Show("Success!");
                count++;
            }*/
            
            return count;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            object text = e.Data.GetData(DataFormats.FileDrop);
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.Text = string.Format("{0}", ((string[])text)[0]);
            }
        }

        private void allBox_Click(object sender, EventArgs e)
        {
            rnAsmbly.toggleCheck();
            rnClass.toggleCheck();
            rnEventdef.toggleCheck();
            rnField.toggleCheck();
            rnFile.toggleCheck();
            rnMdule.toggleCheck();
            rnMethod.toggleCheck();
            rnProperty.toggleCheck();
            rnString.toggleCheck();
            rnAsmblyInfo.toggleCheck();
            rnResources.toggleCheck();
            allBox.CheckState = CheckState.Indeterminate;
        }

        public void Loglist(string text)
        {
            logListBox.Items.Add(text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (arguments.Length > 0)
            {
                originalStrBox.Text = arguments[0];
                renamedStrBox.Text = arguments[1];
                fileLocationBox.Text = arguments[2];
                if (arguments[2].StartsWith("\"") && arguments[2].EndsWith("\""))
                {
                    fileLocationBox.Text = arguments[2].Replace("\"","");
                }

                btnStart.PerformClick();
            }
        }
    }

    public static class Func2
    {
        public static void toggleCheck(this CheckBox checkBox)
        {
            checkBox.Checked = !checkBox.Checked;
        }
    }
}
