using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ADMLib.Student;
using ADMLib.Clerk;
using System.Data;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public int Fill_Form(EnqueryFields ef)
    {

        EnqueryFormLogin DB = new EnqueryFormLogin();
        int txt = DB.Fill_Enquery_form(ef);
        return txt;
    }
    [WebMethod]
    public int Fill_Coun_Form(CounsellingFields ef)
    {

        CounsellingFormLogic DB = new CounsellingFormLogic();
        int txt = DB.Fill_Counselling_Form(ef);
        return txt;
    }

    [WebMethod]
    public int Stud_Login(StudLoginFields ef)
    {

        StudLoginLogic DB = new StudLoginLogic();
        int txt = DB.login(ef);
        return txt;
    }
    [WebMethod]
    public int Genrate_Pass(StudLoginFields ef)
    {

        GenratePassLogic DB = new GenratePassLogic();
        int txt = DB.Gen_Pass(ef);
        return txt;
    }
    [WebMethod]
    public int Ask_Again_Que(EnqueryFields ef)
    {

        AskQueryAfterLogin DB = new AskQueryAfterLogin();
        int txt = DB.Ask_Que_Again(ef);
        return txt;
    }
    [WebMethod]
    public DataTable Load_Response(EnqueryFields ef)
    {

        ViewQueryRespLogic DB = new ViewQueryRespLogic();
        DataTable txt = DB.View_Response(ef);
        return txt;
    }
    [WebMethod]
    public DataTable Pre_Fill_ARF(ARFFormFields ef)
    {

        ARFFillingLogic al = new ARFFillingLogic();
        return al.Pre_Fill(ef);
    }
    [WebMethod]
    public int ARF_Fill(ARFFormFields ef)
    {

        ARFFillingLogic al = new ARFFillingLogic();
        al.ARF_Fill_Logic(ef);
        return 0;
    }
    [WebMethod]
    public int PastEdu_Details(PastEduFields ef)
    {

        PastEduSaveLogic al = new PastEduSaveLogic();
        int x = al.Save_Past(ef);
        return x;
    }
    [WebMethod]
    public int Gen_Appid()
    {
        EnqueryFormLogin ef = new EnqueryFormLogin();
        return ef.Gen_AppID();
    }
    [WebMethod]
    public int Pass_Reset(StudLoginFields ef)
    {

        ResetPasswordLogic DB = new ResetPasswordLogic();
        int txt = DB.PassReset(ef);
        return txt;
    }

    [WebMethod]
    public int Clerk_Login(ClearkLoginFields ef)
    {

        ClerkLoginLogic DB = new ClerkLoginLogic();
        int txt = DB.login(ef);
        return txt;
    }
    [WebMethod]
    public int Pass_Reset_Clerk(ClearkLoginFields ef)
    {

        ResetPasswordLogicClerk DB = new ResetPasswordLogicClerk();
        int txt = DB.PassReset(ef);
        return txt;
    }

}