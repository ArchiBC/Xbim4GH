using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace Xbim4GH
{
    public class Xbim4GHInfo : GH_AssemblyInfo
    {
        public override string Name => "Xbim4GH";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "通过SimpleGrasshopper转译Xbim的IFC实体解析功能到gh中。";

        public override Guid Id => new Guid("a68f255c-8291-438d-ba99-7176d08181bf");

        //Return a string identifying you or your company.
        public override string AuthorName => "ArchiBC";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "Archi=BC@outlook.com";
    }
}