﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GuidewireTestSuites.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class Drupal_PortalFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Drupal_Portal.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Drupal_Portal", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Drupal_Portal")))
            {
                global::GuidewireTestSuites.Features.Drupal_PortalFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void LayoutBuilderBug(string testCase, string applicationType, string target, string browser, string capability, string username, string password, string originalTitle, string originalHeadline, string originalText, string draftTitle, string draftHeadline, string draftText, string primaryTitle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag",
                    "Drupal_Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LayoutBuilderBug", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given(string.Format("I access the Digital Application {0} on {1} in {2}", applicationType, target, browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.And(string.Format("I enter {0} and {1} on the Drupal Admin Login Page", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table140 = new TechTalk.SpecFlow.Table(new string[] {
                        "MenuOption"});
            table140.AddRow(new string[] {
                        "contents"});
#line 9
testRunner.When("I click on menu option in Drupal Admin Landing Page", ((string)(null)), table140, "When ");
#line hidden
            TechTalk.SpecFlow.Table table141 = new TechTalk.SpecFlow.Table(new string[] {
                        "Options"});
            table141.AddRow(new string[] {
                        "Marketing page"});
#line 12
testRunner.And("I click on options in Add Content Page", ((string)(null)), table141, "And ");
#line 15
testRunner.And(string.Format("I insert {0} into Tile in Create Marketing Page", primaryTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.And("I Verify Title is created in Drupal Admin Landing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table142 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabOption"});
            table142.AddRow(new string[] {
                        "Layout"});
#line 17
testRunner.And("I click on tab option in Drupal Admin Landing Page", ((string)(null)), table142, "And ");
#line 20
testRunner.And("I Verify Layout text header in Drupal Admin Landing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table143 = new TechTalk.SpecFlow.Table(new string[] {
                        "State"});
            table143.AddRow(new string[] {
                        "Published"});
#line 21
testRunner.And("I change State in Drupal Admin Landing Page", ((string)(null)), table143, "And ");
#line hidden
            TechTalk.SpecFlow.Table table144 = new TechTalk.SpecFlow.Table(new string[] {
                        "Action"});
            table144.AddRow(new string[] {
                        "Add Block"});
#line 24
testRunner.And("I take action on markating page content in  Drupal Admin Landing Page", ((string)(null)), table144, "And ");
#line hidden
            TechTalk.SpecFlow.Table table145 = new TechTalk.SpecFlow.Table(new string[] {
                        "BlockType"});
            table145.AddRow(new string[] {
                        "feature"});
#line 27
testRunner.And("I create a custome block type in  Drupal Admin Landing Page", ((string)(null)), table145, "And ");
#line 30
testRunner.And(string.Format("I Update {0} , {1} and {2} details for Configure Block in  Drupal Admin Landing P" +
                        "age and Click Save button", originalTitle, originalHeadline, originalText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.And(string.Format("I verify {0} , {1} and {2} updates from Configure Block in  Drupal Admin Landing " +
                        "Page", originalTitle, originalHeadline, originalText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
testRunner.And("I click on Save Layout button in Drupal Admin Landing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
testRunner.And("I verify sucess message in  Layout Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
testRunner.And(string.Format("I verify {0} , {1} and {2} from Configure Block in Layout Page", originalTitle, originalHeadline, originalText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table146 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabOption"});
            table146.AddRow(new string[] {
                        "Layout"});
#line 35
testRunner.And("I click on tab option in Drupal Admin Landing Page", ((string)(null)), table146, "And ");
#line 38
testRunner.And("I Verify Layout text header in Drupal Admin Landing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table147 = new TechTalk.SpecFlow.Table(new string[] {
                        "State"});
            table147.AddRow(new string[] {
                        "Draft"});
#line 39
testRunner.And("I change State in Drupal Admin Landing Page", ((string)(null)), table147, "And ");
#line 42
testRunner.And("I click on edit pencil button for Layout builder in Drupal Admin Landing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
testRunner.And(string.Format("I Update {0} , {1} and {2} for Configure Block in Drupal Admin Landing Page and c" +
                        "lick on Update button", draftTitle, draftHeadline, draftText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
testRunner.And(string.Format("I verify {0} , {1} and {2} updates from Configure Block in  Drupal Admin Landing " +
                        "Page", draftTitle, draftHeadline, draftText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.And("I click on Save Layout button in Drupal Admin Landing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.And("I verify sucess message in  Layout Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table148 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabOption"});
            table148.AddRow(new string[] {
                        "View"});
#line 47
testRunner.And("I click on tab option in Drupal Admin Landing Page", ((string)(null)), table148, "And ");
#line 50
testRunner.And(string.Format("I verify {0} , {1} and {2} updates from Configure Block in View Page", originalTitle, originalHeadline, originalText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table149 = new TechTalk.SpecFlow.Table(new string[] {
                        "TabOption"});
            table149.AddRow(new string[] {
                        "Layout"});
#line 51
testRunner.And("I click on tab option in Drupal Admin Landing Page", ((string)(null)), table149, "And ");
#line 54
testRunner.And("I Verify Layout text header in Drupal Admin Landing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
testRunner.And(string.Format("I verify {0} , {1} and {2} from Configure Block in Layout Page", draftTitle, draftHeadline, draftText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table150 = new TechTalk.SpecFlow.Table(new string[] {
                        "Option"});
            table150.AddRow(new string[] {
                        "Manage"});
#line 56
testRunner.And("I click on tool bar option in Layout Page", ((string)(null)), table150, "And ");
#line hidden
            TechTalk.SpecFlow.Table table151 = new TechTalk.SpecFlow.Table(new string[] {
                        "MenuOption"});
            table151.AddRow(new string[] {
                        "managecontents"});
#line 59
testRunner.And("I click on menu option in Drupal Admin Landing Page", ((string)(null)), table151, "And ");
#line 62
testRunner.And(string.Format("I Delete {0} from Content Page", primaryTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("LayoutBuilderBug: HomePageLinks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Drupal_Portal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Drupal_Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "HomePageLinks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Test Case #", "HomePageLinks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:applicationType", "DRUPALAPP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "Desktop")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:browser", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Capability", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:username", "ITAutomation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:password", "#$afK8462e0oA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OriginalTitle", "Layout Builder Bug Test Title")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OriginalHeadline", "Layout Builder Bug Test Headline")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OriginalText", "Layout Builder Bug Test Text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DraftTitle", "Layout Builder Bug Test Title Draft")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DraftHeadline", "Layout Builder Bug Test Headline Draft")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DraftText", "Layout Builder Bug Test Text Draft")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PrimaryTitle", "Layout Builder Bug Test")]
        public virtual void LayoutBuilderBug_HomePageLinks()
        {
#line 6
this.LayoutBuilderBug("HomePageLinks", "DRUPALAPP", "Desktop", "Chrome", "", "ITAutomation", "#$afK8462e0oA", "Layout Builder Bug Test Title", "Layout Builder Bug Test Headline", "Layout Builder Bug Test Text", "Layout Builder Bug Test Title Draft", "Layout Builder Bug Test Headline Draft", "Layout Builder Bug Test Text Draft", "Layout Builder Bug Test", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
