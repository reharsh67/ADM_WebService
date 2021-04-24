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
    public string Fill_Form(EnqueryFields ef)
    {

        EnqueryFormLogin DB = new EnqueryFormLogin();
         
        return DB.Fill_Enquery_form(ef);
    }
    [WebMethod]
    public string Fill_Coun_Form(CounsellingFields ef)
    {

        CounsellingFormLogic DB = new CounsellingFormLogic();
       
        return  DB.Fill_Counselling_Form(ef);
    }

    [WebMethod]
    public string Stud_Login(StudLoginFields ef)
    {

        StudLoginLogic DB = new StudLoginLogic();
        string txt = DB.login(ef);
        return txt;
    }
    [WebMethod]
    public string Genrate_Pass(StudLoginFields ef)
    {

        GenratePassLogic DB = new GenratePassLogic();
        
        string r= DB.Gen_Pass(ef);

        return r;
    }
    [WebMethod]
    public string Ask_Again_Que(EnqueryFields ef)
    {

        AskQueryAfterLogin DB = new AskQueryAfterLogin();
        string txt = DB.Ask_Que_Again(ef);
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
    public string ARF_Fill(ARFFormFields ef)
    {

        ARFFillingLogic al = new ARFFillingLogic();
        
        return al.ARF_Fill_Logic(ef);
    }
    [WebMethod]
    public string PastEdu_Details(PastEduFields ef)
    {

        PastEduSaveLogic al = new PastEduSaveLogic();
        string x = al.Save_Past(ef);
        return x;
    }
    [WebMethod]
    public int Gen_Appid()
    {
        EnqueryFormLogin ef = new EnqueryFormLogin();
        return ef.Gen_AppID();
    }
    [WebMethod]
    public string Pass_Reset(StudLoginFields ef)
    {

        ResetPasswordLogic DB = new ResetPasswordLogic();
        string txt = DB.PassReset(ef);
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