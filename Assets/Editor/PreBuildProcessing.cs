using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using System;

public class PreBuildProcessing : IPreprocessBuildWithReport
{
    public int callbackOrder => 1;

    public void OnPreprocessBuild(BuildReport report)
    {
        System.Environment.SetEnvironmentVariable("EMSDK_PYTHON", "/Users/judecaldwell/.asdf/shims/python");
    }
}
