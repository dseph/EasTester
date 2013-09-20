EAS Tester

This is a sample application which demonstrates the encoding, decoding and submission of EAS WBMXL and XML content.  

It provides some very basic capabilities:
	It will issue basic EAS requests and return responses.

	It will load WBXML binary content from a file and convert it to XML.
	   Such content can be exported from various network tracing tools such as NetMon and Wireshark.

	It can attempt to convert WBXML content which is in a hex or integer string which may have delimiters into XML.
	   Such content can be copied from various network tracing tools such as NetMon, Wireshark and Fiddler.

Most of the code comes from the Exchange Server Interoperability Guidance samples for Activesync, in particular:

	Implementing an Exchange ActiveSync client: the transport mechanism
	http://msdn.microsoft.com/en-us/library/exchange/hh361570(v=exchg.140).aspx

Details on the ActiveSync protocol can be found here:

	Exchange Server Protocol Documents
	http://msdn.microsoft.com/en-us/library/cc425499(v=exchg.80).aspx 

Here is information on licensing:

	Technology Licensing Programs
	http://www.microsoft.com/about/legal/en/us/IntellectualProperty/IPLicensing/Programs/Default.aspx

	Exchange ActiveSync Protocol
	http://www.microsoft.com/about/legal/en/us/IntellectualProperty/IPLicensing/Programs/ExchangeActiveSyncProtocol.aspx

	Microsoft Expands Exchange ActiveSync Licensing Program
	http://www.microsoft.com/presspass/press/2008/dec08/12-18easlicencingpr.mspx
 
This article covers basic information on ActiveSync:

	New to Exchange ActiveSync Development?
 	http://blogs.msdn.com/b/webdav_101/archive/2011/09/28/new-to-exchange-activesync-development.aspx 


If you have policies in force which require provisioning, then you should be sure to read the followign article so 
that you know the set of provisioning calls which must be done to get a policy key which can be used for other EAS calls.

    Provisioning, policies, remote wipe, and the Allow/Block/Quarantine list in Exchange ActiveSync
	http://msdn.microsoft.com/en-us/library/exchange/hh509085(v=exchg.140).aspx 

--------------------
NOTE:
--------------------

This code is not supported by anyone and exists purely for educational purposes.  If you are building an ActiveSync 
application which is going to be commercialized then you really need to look into licensing.

--------------------
Pointers:
--------------------
If you are getting a Queue empty error being thrown in DecodeWBXML while loading WBXML, it is likely that the WBXML 
body is incomplete. Be sure to export the full body for request or response from your networking tool.

--------------------
History:
--------------------

Prior to 6/21/2013
I wrote this as tool to use for testing EAS calls and for decoding WBXML content.  I've been using this
resolving EAS issues for a while and decided to make it public so that others would have something
which they could use.

6/21/2013
Removed some code which was not needed.
I've done some polishing on this test code in order to get it ready for external publishing.

6/24/2013
Fixed policy key issues.
Added an Example window.
Lots of code cleaned-up.
 
6/29/2013
Changed examples to load from files. Added feature to save to files. Content is saved under app program folder.
Added some help text.
Minor clean-up issues.
Checked in code.
Initial release - 1.0 

7/1/2013
Make only these versions of EAS selectable in conversatgions window:
    14.1
    14.0
    12.1
    12.0
    2.5
Slight changes to the EAS Conversations windows in order to narrow it down.

7/3/2013
Released 1.1

--

7/29/2013
Added more to EAS samples
Corrected some issues with eas samples.
Added encoding form to Conversations window.  Right now it just does basic operations to support 
working with the message body for sending email.
Reworked list of Commands in Conversations window.
Released 1.2

--
7/29/2013
Added some notes to readme.txt
Incremented version number to 1.3 for development.
Fixed ItemOperations folder clear sample.
Changed "ItemsOperations" to "ItemOperations" in Conversation window.

9/20/2013
Conversations view now can save and load settings + last request + last response.  Password is not saved.
Release 1.3