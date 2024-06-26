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
    public partial class AgentInquiryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "AgentInquiry.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AgentInquiry", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "AgentInquiry")))
            {
                global::GuidewireTestSuites.Features.AgentInquiryFeature.FeatureSetup(null);
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
        
        public virtual void Scenario01_AgentInquiry_PolicyCenterValidation(string applicationEnvironment, string targetType, string capability, string browserType, string operatingSystem, string userName, string password, string gW_UserName, string gW_Password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regression",
                    "AIRegression",
                    "AI1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario01_AgentInquiry_PolicyCenterValidation", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
                testRunner.Given(string.Format("I access the AgentAutomation app in {0} , {1} , {2} , {3} and {4}", applicationEnvironment, targetType, capability, browserType, operatingSystem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.When(string.Format("I login with {0} and {1} in  AgentPortal", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "NavigationOption"});
            table1.AddRow(new string[] {
                        "policy"});
#line 10
    testRunner.And("I click on Top Navigation option in Agent Portal", ((string)(null)), table1, "And ");
#line 13
    testRunner.And("I click on Advanced Search option in Agent Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Searchby",
                        "ProducerCode",
                        "Offering",
                        "PolicyStatus"});
            table2.AddRow(new string[] {
                        "Policy",
                        "exited kindled payers (B50D)",
                        "Jewelers Block",
                        "In Force"});
#line 14
    testRunner.And("I search with below details", ((string)(null)), table2, "And ");
#line 17
    testRunner.And("I selct First account in Account search result table of AgentPortal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.And("I fetch Accountname and PrimaryAddress from Accounts page of Agent inquiry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "NavigationOption"});
            table3.AddRow(new string[] {
                        "policy"});
#line 19
    testRunner.And("I click on Top Navigation option in Agent Portal", ((string)(null)), table3, "And ");
#line 22
    testRunner.And("I click on Advanced Search option in Agent Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Searchby",
                        "ProducerCode",
                        "Offering",
                        "PolicyStatus"});
            table4.AddRow(new string[] {
                        "Policy",
                        "exited kindled payers (B50D)",
                        "Jewelers Block",
                        "In Force"});
#line 23
    testRunner.And("I search with below details", ((string)(null)), table4, "And ");
#line 26
    testRunner.And("I selct First policy in Account search result table of AgentPortal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.And("I fetch EffectiveDate , ExpirationDate, ProducerCode , ProducerName", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.And("I Kill Web Driver", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.And("I access the Guidewire PC on Desktop in IE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
               testRunner.And("I enter pluwmanager and pluwmanagerpwd on the PC9 Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.And("I select Policies from the Search Tab menu of PC9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
          testRunner.And("search for account with REGISTRY and select from search results in PC9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
    testRunner.Then("I verify REGISTRY , REGISTRY ,  ,  ,  ,  ,  , ,   in Left Account Details page fo" +
                    "r PC9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
    testRunner.And("I verify  ,  ,  ,  , REGISTRY in Right Account Details page for PC9 for QNA Accou" +
                    "nt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
    testRunner.And("I verfy  REGISTRY ,  ,  in Policy Term  for PC9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
                testRunner.And("I logout of the PC9 application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario01_AgentInquiry_PolicyCenterValidation: AI")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AgentInquiry")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AIRegression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AI1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "AI")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ApplicationEnvironment", "AI")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TargetType", "desktop")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Capability", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:BrowserType", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OperatingSystem", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserName", "robertgarcia@apptest.jminsure.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Password", "Pass1234!")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GW_UserName", "su")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GW_Password", "gw")]
        public virtual void Scenario01_AgentInquiry_PolicyCenterValidation_AI()
        {
#line 7
this.Scenario01_AgentInquiry_PolicyCenterValidation("AI", "desktop", "", "Chrome", "", "robertgarcia@apptest.jminsure.com", "Pass1234!", "su", "gw", ((string[])(null)));
#line hidden
        }
        
        public virtual void Scenario02_AgentInquiry_ClaimCenterValidation(string gWUserName, string gWPassword, string applicationEnvironment, string targetType, string capability, string browserType, string operatingSystem, string userName, string password, string gW_UserName, string gW_Password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regression",
                    "AIRegression",
                    "AI2"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario02_AgentInquiry_ClaimCenterValidation", @__tags);
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
                testRunner.Given(string.Format("I access the AgentAutomation app in {0} , {1} , {2} , {3} and {4}", applicationEnvironment, targetType, capability, browserType, operatingSystem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
    testRunner.When(string.Format("I login with {0} and {1} in  AgentPortal", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "NavigationOption"});
            table5.AddRow(new string[] {
                        "policy"});
#line 53
    testRunner.And("I click on Top Navigation option in Agent Portal", ((string)(null)), table5, "And ");
#line 56
    testRunner.And("I click on Advanced Search option in Agent Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Searchby",
                        "ProducerCode",
                        "Offering",
                        "PolicyStatus"});
            table6.AddRow(new string[] {
                        "Policy",
                        "exited kindled payers (B50D)",
                        "Jewelers Block",
                        "In Force"});
#line 57
    testRunner.And("I search with below details", ((string)(null)), table6, "And ");
#line 60
    testRunner.And("I selct fourth policy with avalable claim table of AgentPortal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "NavigationOption"});
            table7.AddRow(new string[] {
                        "claims"});
#line 61
    testRunner.And("I click on Top Navigation option in Agent Portal", ((string)(null)), table7, "And ");
#line 64
    testRunner.And("I enetr REGISTRY in Policy number text  in Search a Claim section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
    testRunner.And("I get latest claim number from claim search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "NavigationOption"});
            table8.AddRow(new string[] {
                        "claims"});
#line 66
    testRunner.And("I click on Top Navigation option in Agent Portal", ((string)(null)), table8, "And ");
#line 69
    testRunner.And("I enetr REGISTRY in Policy number text  in Submit a Claim section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
    testRunner.And("I selct First policy in Claim search result table of AgentPortal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Date",
                        "LossDescription",
                        "LossCause"});
            table9.AddRow(new string[] {
                        "SYSTEM",
                        "LossDesc",
                        "Fire"});
#line 71
    testRunner.And("I set First Notice of Loss details for Agent portal", ((string)(null)), table9, "And ");
#line 74
    testRunner.And("I submit First Notice of Loss details for Agent portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
    testRunner.And("I verify if first notice of loss is recived", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "NavigationOption"});
            table10.AddRow(new string[] {
                        "claims"});
#line 76
    testRunner.And("I click on Top Navigation option in Agent Portal", ((string)(null)), table10, "And ");
#line 79
    testRunner.And("I enetr REGISTRY in Policy number text  in Search a Claim section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
    testRunner.And("I get verify new claim number is added in claim search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario02_AgentInquiry_ClaimCenterValidation: su")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AgentInquiry")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AIRegression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AI2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "su")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GWUserName", "su")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GWPassword", "gw")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ApplicationEnvironment", "AI")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TargetType", "desktop")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Capability", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:BrowserType", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OperatingSystem", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserName", "robertgarcia@apptest.jminsure.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Password", "Pass1234!")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GW_UserName", "su")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GW_Password", "gw")]
        public virtual void Scenario02_AgentInquiry_ClaimCenterValidation_Su()
        {
#line 50
this.Scenario02_AgentInquiry_ClaimCenterValidation("su", "gw", "AI", "desktop", "", "Chrome", "", "robertgarcia@apptest.jminsure.com", "Pass1234!", "su", "gw", ((string[])(null)));
#line hidden
        }
        
        public virtual void Scenario03_AgentInquiry_BillingCenterValidation(string applicationEnvironment, string targetType, string capability, string browserType, string operatingSystem, string userName, string password, string gW_UserName, string gW_Password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regression",
                    "AIRegression",
                    "AI3"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario03_AgentInquiry_BillingCenterValidation", @__tags);
#line 93
this.ScenarioSetup(scenarioInfo);
#line 94
                testRunner.Given(string.Format("I access the AgentAutomation app in {0} , {1} , {2} , {3} and {4}", applicationEnvironment, targetType, capability, browserType, operatingSystem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
    testRunner.When(string.Format("I login with {0} and {1} in  AgentPortal", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "NavigationOption"});
            table11.AddRow(new string[] {
                        "billing"});
#line 96
    testRunner.And("I click on Top Navigation option in Agent Portal", ((string)(null)), table11, "And ");
#line 99
    testRunner.And("I click on Advanced Search option in Agent Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProducerCode",
                        "PolicyStatus"});
            table12.AddRow(new string[] {
                        "uppers rift caracol nocks (B54D)",
                        "In Force"});
#line 100
    testRunner.And("I search with below details in billing section", ((string)(null)), table12, "And ");
#line 103
    testRunner.And("I selct First policy in Billing search result table of AgentPortal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "section"});
            table13.AddRow(new string[] {
                        "Billing Information"});
#line 104
    testRunner.And("I click on section of Policy Summary Billing", ((string)(null)), table13, "And ");
#line 107
    testRunner.And("I fetch Accountnumber, address, paymentplan and autopay from billing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
    testRunner.And("I Kill Web Driver", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
    testRunner.And("I access the Guidewire BC on Desktop in IE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
                testRunner.And("I enter bcmanager and bcmanagerpwd on the BC Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
                testRunner.And("I select Search from the Tab menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
                testRunner.And("search for account with REGISTRY and select from search results for QNA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
                testRunner.And("I select details from left navigation menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
    testRunner.Then("I verify REGISTRY , REGISTRY in Account Details page for Agent Inquiry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
                testRunner.And("I Logout of the Billing Center application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario03_AgentInquiry_BillingCenterValidation: AI")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AgentInquiry")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AIRegression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AI3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "AI")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ApplicationEnvironment", "AI")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TargetType", "desktop")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Capability", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:BrowserType", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OperatingSystem", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserName", "alanachair@apptest.jminsure.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Password", "Pass1234!")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GW_UserName", "su")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GW_Password", "gw")]
        public virtual void Scenario03_AgentInquiry_BillingCenterValidation_AI()
        {
#line 93
this.Scenario03_AgentInquiry_BillingCenterValidation("AI", "desktop", "", "Chrome", "", "alanachair@apptest.jminsure.com", "Pass1234!", "su", "gw", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
