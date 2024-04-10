using System;
using System.Collections.Generic;
using System.ComponentModel;
using SimpleGrasshopper.Attributes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbim4GH;

enum BaseLibraryTag
{
    [Description("Xbim")]
    Xbim,
    //GeometryGym,
    //IfcOpenShell
}

enum IfcVersion
{
    [Description("IFC2x3")]
    IFC2x3,
    [Description("IFC4")]
    IFC4,
    [Description("IFC4x3")]
    IFC4x3,
}

internal static partial class Settings
{
    /// <summary>
    /// 设置基础库，目前暂不可切换
    /// </summary>
    [Setting]
    private static readonly BaseLibraryTag baseLibrary = BaseLibraryTag.Xbim;

    /// <summary>
    /// 设置IFC版本，目前暂不可切换
    /// </summary>
    [Setting]
    private static readonly IfcVersion ifcVersion = IfcVersion.IFC4x3;

}
