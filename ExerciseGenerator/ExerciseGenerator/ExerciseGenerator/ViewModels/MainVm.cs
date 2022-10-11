using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExerciseGenerator.ViewModels
{
    public class MainVm : ViewModelBase
    {
        public string ExerciseName { get; set; }

        public ICommand GenerateCodeCommand { get; set; }

        public ICommand SaveCodeCommand { get; set; }

        private bool _codeGenerated;

        public bool CodeGenerated
        {
            get => _codeGenerated;
            set
            {
                _codeGenerated = value;
                NotifyPropertyChanged(nameof(CodeGenerated));
            }
        }

        private string _exerciseCode;

        public string ExerciseCode
        {
            get => _exerciseCode;
            set
            {
                _exerciseCode = value;
                NotifyPropertyChanged(nameof(ExerciseCode));
            }
        }

        private string _testCode;

        public string TestCode
        {
            get => _testCode;
            set
            {
                _testCode = value;
                NotifyPropertyChanged(nameof(TestCode));
            }
        }

        private string _mainCode;

        public string MainCode
        {
            get => _mainCode;
            set
            {
                _mainCode = value;
                NotifyPropertyChanged(nameof(MainCode));
            }
        }

        private CommonOpenFileDialog _saveDialog;

        public MainVm()
        {
            ExerciseName = string.Empty;

            GenerateCodeCommand = new ActionCommand(o =>
            {
                GenerateCode();
            }, null);

            SaveCodeCommand = new ActionCommand(o =>
            {
                SaveCode();
            }, null);

            _saveDialog = new CommonOpenFileDialog();
            _saveDialog.IsFolderPicker = true;
        }

        private void GenerateCode()
        {
            var lower = char.ToLower(ExerciseName[0]) + ExerciseName.Substring(1);

            ExerciseCode = PreGeneratedCode.ExerciseCode.Replace("{NAME}", ExerciseName);

            TestCode = PreGeneratedCode.TestCode.Replace("{NAME}", ExerciseName).Replace("{NAME_LOWER}", lower);

            MainCode = PreGeneratedCode.MainCode.Replace("{NAME}", ExerciseName);

            CodeGenerated = true;
        }

        private void SaveCode()
        {
            GenerateCode();

            if (_saveDialog.ShowDialog() != CommonFileDialogResult.Ok)
                return;

            var folderPath = _saveDialog.FileName;

            var exerciseProjectPath = $"{folderPath}/ProblemSolving/";

            var mainPath = $"{exerciseProjectPath}/Program.cs";
            var exercisePath = $"{exerciseProjectPath}/Exercises/{ExerciseName}Exercise.cs";

            var testPath = $"{folderPath}/ProblemSolvingTests/Tests/{ExerciseName}Test.cs";

            File.WriteAllText(mainPath, MainCode);
            File.WriteAllText(exercisePath, ExerciseCode);
            File.WriteAllText(testPath, TestCode);
        }
    }

    public class PreGeneratedCode
    {
        public static readonly string ExerciseCode = @"using System;

namespace ProblemSolving.Exercises
{
    public class {NAME}Exercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve();
            Console.WriteLine(answer);
        }

        public string Solve()
        {
            return 0;
        }
    }
}";

        public static readonly string TestCode = @"using ProblemSolving.Tests;

namespace ProblemSolvingTests.Exercises
{
    [TestClass]
    public class {NAME}Test : Test
    {
        private readonly {NAME}Exercise _{NAME_LOWER}Exercise = new {NAME}Exercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _{NAME_LOWER}Exercise.Solve();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _{NAME_LOWER}Exercise.Solve();

            Assert.AreEqual(2, result);
        }
        
    }
}";

        public static readonly string MainCode = @"using System;
using ProblemSolving.Exercises;

namespace ProblemSolving
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new {NAME}Exercise().Run();
            Console.ReadLine();
        }
    }
}
";
    }
}
