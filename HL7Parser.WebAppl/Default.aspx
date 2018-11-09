<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HL7Parser.WebAppl._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../Style/Style.css" />
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js"></script>
    <script src="../Javascript/Common.js"></script>
</head>
<body>
<form id="form1" runat="server">
    <div id="Header"style="display: none;">
        <table style="">
            <tr>
                <td><button type="button" onclick="mshShowSearch()" class="btn-style">MSH</button></td>
                <td><button type="button" onclick="pidShowSearch()" class="btn-style">PID</button></td>
            </tr>
        </table>
    </div>

    <div id="MshSearch" style="display: none;">
        <table style="" class="table-bg">
            <tr>
                <td>Search By Control-Id: <input type="text" id="txtControlId" class="input-box" runat="server"/></td>
                <td>
                    <asp:Button ID="btnMshsearch" class="btn-style" runat="server" Text="Search" OnClick="btnMshsearch_Click" />
                </td>
            </tr>
        </table>
    </div>

    <div id="PidSearch" <%--style="display: none;"--%>>
        <table class="table-bg">
            <tr>
                <td>Search By Patient-Id: <input type="text" id="txtPatientId" class="input-box" runat="server"/></td>
                <td>
                    <asp:Button ID="btnPidsearch" class="btn-style" runat="server" Text="Search" OnClick="btnPidsearch_Click" />
                </td>
            </tr>
        </table>
    </div>

    <div id="MshGrid" style="display: none;">
        <table class="id-table">
            <tr><td>ID</td><td><input type="text" id="txtMshId" runat="server"/></td></tr>
            <tr><td>MSH.1</td><td><input type="text" id="txtMSH_1" runat="server"/></td>      </tr>
            <tr><td>MSH.2</td><td><input type="text" id="txtMSH_2" runat="server"/></td>      </tr>
            <tr><td>MSH.3.1 </td><td><input type="text" id="txtMSH_3_1" runat="server"/></td> </tr>
            <tr><td>MSH.3.2 </td><td><input type="text" id="txtMSH_3_2" runat="server"/></td> </tr>
            <tr><td>MSH.3.3 </td><td><input type="text" id="txtMSH_3_3" runat="server"/></td> </tr>
            <tr><td>MSH.4.1 </td><td><input type="text" id="txtMSH_4_1" runat="server"/></td> </tr>
            <tr><td>MSH.4.2 </td><td><input type="text" id="txtMSH_4_2" runat="server"/></td> </tr>
            <tr><td>MSH.4.3 </td><td><input type="text" id="txtMSH_4_3" runat="server"/></td> </tr>
            <tr><td>MSH.5.1 </td><td><input type="text" id="txtMSH_5_1" runat="server"/></td> </tr>
            <tr><td>MSH.5.2 </td><td><input type="text" id="txtMSH_5_2" runat="server"/></td> </tr>
            <tr><td>MSH.5.3 </td><td><input type="text" id="txtMSH_5_3" runat="server"/></td> </tr>
            <tr><td>MSH.6.1 </td><td><input type="text" id="txtMSH_6_1" runat="server"/></td> </tr>
            <tr><td>MSH.6.2 </td><td><input type="text" id="txtMSH_6_2" runat="server"/></td> </tr>
            <tr><td>MSH.6.3 </td><td><input type="text" id="txtMSH_6_3" runat="server"/></td> </tr>
            <tr><td>MSH.7</td><td><input type="text" id="txtMSH_7" runat="server"/></td>      </tr>
            <tr><td>MSH.8</td><td><input type="text" id="txtMSH_8" runat="server"/></td>      </tr>
            <tr><td>MSH.9.1 </td><td><input type="text" id="txtMSH_9_1" runat="server"/></td> </tr>
            <tr><td>MSH.9.2 </td><td><input type="text" id="txtMSH_9_2" runat="server"/></td> </tr>
            <tr><td>MSH.10</td><td><input type="text" id="txtMSH_10" runat="server"/></td>    </tr>
            <tr><td>MSH.11.1</td><td><input type="text" id="txtMSH_11_1" runat="server"/></td></tr>
            <tr><td>MSH.11.2</td><td><input type="text" id="txtMSH_11_2" runat="server"/></td></tr>
            <tr><td>MSH.12</td><td><input type="text" id="txtMSH_12" runat="server"/></td>    </tr>
            <tr><td>MSH.13</td><td><input type="text" id="txtMSH_13" runat="server"/></td>    </tr>
            <tr><td>MSH.14</td><td><input type="text" id="txtMSH_14" runat="server"/></td>    </tr>
            <tr><td>MSH.15</td><td><input type="text" id="txtMSH_15" runat="server"/></td>    </tr>
            <tr><td>MSH.16</td><td><input type="text" id="txtMSH_16" runat="server"/></td>    </tr>
            <tr><td>MSH.17</td><td><input type="text" id="txtMSH_17" runat="server"/></td>    </tr>
            <tr><td>MSH.18</td><td><input type="text" id="txtMSH_18" runat="server"/></td>    </tr>
            <tr><td>MSH.19</td><td><input type="text" id="txtMSH_19" runat="server"/></td>    </tr>
            <tr><td>
                <asp:Button ID="btnMshSave" class="btn-style" runat="server" Text="Save" OnClick="btnMshSave_Click1" />
                </td></tr>
        </table>
        
    </div>

    <div id="PidGrid" <%--style="display: none;"--%>>
        <table style="" class="id-table">
            <tr><td>ID</td><td><input type="text" id="txtPidID" runat="server"/></td></tr>
            <tr><td>Set Id</td><td><input type="text" id="txtPid_1" runat="server"/></td></tr>
            <tr><td>External Id</td><td><input type="text" id="txtPid_2" runat="server"/></td></tr>
            <tr><td>Internal Id</td><td><input type="text" id="txtPid_3" runat="server"/></td></tr>
            <tr><td>Alternate Id</td><td><input type="text" id="txtPid_4" runat="server"/></td></tr>
            <tr><td>Patient Last Name</td><td><input type="text" id="txtPid_5_1" runat="server"/></td></tr>
            <tr><td>Patient firstName</td><td><input type="text" id="txtPid_5_2" runat="server"/></td></tr>
            <tr><td>Patient Middle Name</td><td><input type="text" id="txtPid_5_3" runat="server"/></td></tr>
            <tr><td>Patient Suffix</td><td><input type="text" id="txtPid_5_4" runat="server"/></td></tr>
            <tr><td>Patient Prefix</td><td><input type="text" id="txtPid_5_5" runat="server"/></td></tr>
            <tr><td>Patient degree</td><td><input type="text" id="txtPid_5_6" runat="server"/></td></tr>
            <tr><td>Mothers Last Name</td><td><input type="text" id="txtPid_6_1" runat="server"/></td></tr>
            <tr><td>Mothers First Name</td><td><input type="text" id="txtPid_6_2" runat="server"/></td></tr>
            <tr><td>Mothers Middle Name</td><td><input type="text" id="txtPid_6_3" runat="server"/></td></tr>
            <tr><td>Mothers Suffix</td><td><input type="text" id="txtPid_6_4" runat="server"/></td></tr>
            <tr><td>Mothers Prefix</td><td><input type="text" id="txtPid_6_5" runat="server"/></td></tr>
            <tr><td>Mothers Degree</td><td><input type="text" id="txtPid_6_6" runat="server"/></td></tr>
            <tr><td>Mothers NameTypeCode</td><td><input type="text" id="txtPid_6_7" runat="server"/></td></tr>
            <tr><td>DOB</td><td><input type="text" id="txtPid_7" runat="server"/></td></tr>
            <tr><td>Sex</td><td><input type="text" id="txtPid_8" runat="server"/></td></tr>
            <tr><td>Alias Last Name</td><td><input type="text" id="txtPid_9_1" runat="server"/></td></tr>
            <tr><td>Alias First Name</td><td><input type="text" id="txtPid_9_2" runat="server"/></td></tr>
            <tr><td>Alias Middle Name</td><td><input type="text" id="txtPid_9_3" runat="server"/></td></tr>
            <tr><td>Alias Suffix</td><td><input type="text" id="txtPid_9_4" runat="server"/></td></tr>
            <tr><td>Alias Prefix</td><td><input type="text" id="txtPid_9_5" runat="server"/></td></tr>
            <tr><td>Alias Degree</td><td><input type="text" id="txtPid_9_6" runat="server"/></td></tr>
            <tr><td>Alias NameTypeCode</td><td><input type="text" id="txtPid_9_7" runat="server"/></td></tr>
            <tr><td>Race</td><td><input type="text" id="txtPid_10" runat="server"/></td></tr>
            <tr><td>Street Address</td><td><input type="text" id="txtPid_11_1" runat="server"/></td></tr>
            <tr><td>Other Designation</td><td><input type="text" id="txtPid_11_2" runat="server"/></td></tr>
            <tr><td>City</td><td><input type="text" id="txtPid_11_3" runat="server"/></td></tr>
            <tr><td>StateOrProvince</td><td><input type="text" id="txtPid_11_4" runat="server"/></td></tr>
            <tr><td>Zip</td><td><input type="text" id="txtPid_11_5" runat="server"/></td></tr>
            <tr><td>Country</td><td><input type="text" id="txtPid_11_6" runat="server"/></td></tr>
            <tr><td>AddressType</td><td><input type="text" id="txtPid_11_7" runat="server"/></td></tr>
            <tr><td>OtherGeographicDesignation</td><td><input type="text" id="txtPid_11_8" runat="server"/></td></tr>
            <tr><td>CountyOrParishCode</td><td><input type="text" id="txtPid_11_9" runat="server"/></td></tr>
            <tr><td>CountyCode</td><td><input type="text" id="txtPid_12" runat="server"/></td></tr>
            <tr><td>HomePhone Number</td><td><input type="text" id="txtPid_13_1" runat="server"/></td></tr>
            <tr><td>homePhone TelecommunicationUseCode</td><td><input type="text" id="txtPid_13_2" runat="server"/></td></tr>
            <tr><td>homePhone TelecommunicationEquipmentType</td><td><input type="text" id="txtPid_13_3" runat="server"/></td></tr>
            <tr><td>EmailAddress</td><td><input type="text" id="txtPid_13_4" runat="server"/></td></tr>
            <tr><td>BusinessPhone</td><td><input type="text" id="txtPid_14_1" runat="server"/></td></tr>
            <tr><td>BusinessPhone TelecommunicationUseCode</td><td><input type="text" id="txtPid_14_2" runat="server"/></td></tr>
            <tr><td>BusinessPhone TelecommunicationEquipmentType</td><td><input type="text" id="txtPid_14_3" runat="server"/></td></tr>
            <tr><td>BusinessPhone EmailAddress</td><td><input type="text" id="txtPid_14_4" runat="server"/></td></tr>
            <tr><td>PrimaryLanguage Id</td><td><input type="text" id="txtPid_15_1" runat="server"/></td></tr>
            <tr><td>PrimaryLanguage Text</td><td><input type="text" id="txtPid_15_2" runat="server"/></td></tr>
            <tr><td>MaritalStatus</td><td><input type="text" id="txtPid_16" runat="server"/></td></tr>
            <tr><td>Religion</td><td><input type="text" id="txtPid_17" runat="server"/></td></tr>
            <tr><td>PatientAccountNumber</td><td><input type="text" id="txtPid_18" runat="server"/></td></tr>
            <tr><td>Ssn</td><td><input type="text" id="txtPid_19" runat="server"/></td></tr>
            <tr><td>DriversLicenseNumber</td><td><input type="text" id="txtPid_20" runat="server"/></td></tr>
            <tr><td>MothersId</td><td><input type="text" id="txtPid_21" runat="server"/></td></tr>
            <tr><td>EthnicGroup</td><td><input type="text" id="txtPid_22" runat="server"/></td></tr>
            <tr><td>BirthPlace</td><td><input type="text" id="txtPid_23" runat="server"/></td></tr>
            <tr><td>MultipleBirthIndicator</td><td><input type="text" id="txtPid_24" runat="server"/></td></tr>
            <tr><td>BirthOrder</td><td><input type="text" id="txtPid_25" runat="server"/></td></tr>
            <tr><td>Citizenship</td><td><input type="text" id="txtPid_26" runat="server"/></td></tr>
            <tr><td>VeteranStatus</td><td><input type="text" id="txtPid_27" runat="server"/></td></tr>
            <tr><td>Nationality</td><td><input type="text" id="txtPid_28" runat="server"/></td></tr>
            <tr><td>DeathDateTime</td><td><input type="text" id="txtPid_29" runat="server"/></td></tr>
            <tr><td>DeathIndicator</td><td><input type="text" id="txtPid_30" runat="server"/></td></tr>
            <tr><td>
                <asp:Button ID="btnPidsave" class="btn-style" runat="server" Text="Save" OnClick="btnPidsave_Click1" />
            </td></tr>
        </table>
    </div>
</form>
</body>
</html>