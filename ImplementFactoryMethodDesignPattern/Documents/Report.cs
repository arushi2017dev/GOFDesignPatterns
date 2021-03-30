using System;
using System.Collections.Generic;
using System.Text;
using ImplementFactoryMethodDesignPattern.Pages;

namespace ImplementFactoryMethodDesignPattern.Documents
{
    /// <summary>

    /// A 'ConcreteCreator' class

    /// </summary>
    class Report : Document

    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
