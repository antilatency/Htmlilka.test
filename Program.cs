using System;
using System.Text;

namespace Htmlilka.test
{
    class Program {
        static void Main(string[] args){

            var page = new Tag(null)
                .AddVoidTag("!DOCTYPE", a => a.Attribute("html"))
                .AddTag("html", a => {
                    a.AddTag("head", b => {
                        b.AddTag("title", c => c.AddText("Super"));
                        b.AddMeta(c => c.Attribute("charset", "utf-8"));
                    });
                    a.AddTag("body", b => {
                        b.AddTag("script", c => c.AddText("Behaviour.Initialize(\"TemplateLeftSideMenu<>\",800,64)"));
                        b.AddTag("nav", c => {
                            c.AddClass("manu").AddClass("LeftSideMenu");
                            c.ID = "Menu";
                        });
                        b.AddDiv(c => c.AddText("Hello"));
                        b.AddNull(c => {
                            c.AddDiv(d => d.AddText("Hello"));
                            c.AddDiv(d => d.AddText("Hello"));
                            c.AddDiv(d => d.AddText("Hello"));
                        });
                    });
                });



            var result = new StringBuilder();
            page.WriteHtml(result);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
