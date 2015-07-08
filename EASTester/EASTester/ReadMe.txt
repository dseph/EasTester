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

11/7/2013
Changed version to 1.4
Fixed a bug in Conversation view where the server was not being saved.
Adding processing to load a string which describes the response code. This will make Conversation view a lot 
easier to work with since is a pain to look-up the respose code meaning.

11/8/2013
Status lookup is working for common codes and status codes for several high usage commands.
If a command specific code is not foun found in the Exchange Protocol Documentationd then it tries to get the common status code if there is one.

12/19/2013
Fixed examples - some didn't have a colon in the namepace names, so I dded them.
Updated Ping example
Some minor updates to help files.

1/16/2014
Fixed some issues involved with pulling source code down and compiling. It should build properly now as long as you run Visual Stuidio as Admin.
More changes for the raw ews post screen.

8/6/2014
Finished response status help on base most common EAS commands. 
Added a respone helper screen which allows a person to paste in a response and get info on the status code. 
Added abiltiy to set proxy settings so Fiddler and other proxy appsand network tracers could be used with it.

8/6/2014
Released EAS Tester 1.4

9/7/2014
Seveal multiline text boxes were limiting content to 32k - I removed this limit.

10/13/2014
Added ItemsOperations - Move on ConversationId sample

10/15/2014
Screen reformatting and chaingingfont sizes

11/14/2014
Fixed bug where null returend prevents displaying all data in text box
Added ie rendering of response
Added hex display of response
Fixed file types noted when saving and loading 
Response analysis is now saved and loaded

12/23/2014
Fixed inbox sync key 0 sample - removed getchanges tag

4/20/2015
In Encode form: Fixed some issues with hex dump code, added conversions 
for base 64 to hex string, base 64 to space delimited hex string, 
hex dump and hex dump of content in a base64 endoded string. These 
additions will help situations when a user wants to decode and edit 
binary data - which eas base64 encodes. The data binary data can 
also be dumped easily for review due to the hex dump feature.

4/22/2015
Added new hex string conversions to Encoding window.

Finished changes for new hex string conversions.

5/4/2015
Released EASTester 1.6

7/8/2015
	I'm adding prelminary schema EAS 16.0 fields.  Note that these are not for the final release of EAS 16. I'll update it further when EAS 16 reaches RTM.
	See the following for the preliminary EAS 16.0 specs:  
		https://msdn.microsoft.com/en-us/library/ee941641.aspx#exchange_server
			MS-ASWBXML covers the EAS Schema
	EasConversations.cs - added version 16.0
	ASWBXML.cs - added new EAS schema fields


