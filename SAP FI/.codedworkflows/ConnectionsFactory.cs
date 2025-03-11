using UiPath.CodedWorkflows;
using System;

namespace PublicSectorDemo
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection SandBox_Rahul_Sridharan_uptestsuite_gmail_com { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            SandBox_Rahul_Sridharan_uptestsuite_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("03bdd54f-9541-43fd-8c58-ee42cbcf4c9a", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}