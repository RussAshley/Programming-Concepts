using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Programming_Concepts
{
    class ConceptSections
    {

        private String Title;
        private String Explaination;
        private String Ref;
        private Image ExampleImage;

        public ConceptSections(string title, string explaination, string @ref, Image exampleImage)
        {
            Title1 = title;
            Explaination1 = explaination;
            Ref1 = @ref;
            ExampleImage1 = exampleImage;
        }

        public string Title1 { get => Title; set => Title = value; }
        public string Explaination1 { get => Explaination; set => Explaination = value; }
        public string Ref1 { get => Ref; set => Ref = value; }
        public Image ExampleImage1 { get => ExampleImage; set => ExampleImage = value; }
    }


}
