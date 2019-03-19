# soap-asmx-webservice
send soap message with empty SOAPAction SOAP 1.1 using asmx web service

Formatted view : https://raw.githubusercontent.com/TurgayCan/soap-asmx-webservice/master/README.md

Request (Raw)

POST http://127.0.0.1:8080/NotifySmsReception.asmx HTTP/1.1
Accept-Encoding: gzip,deflate
Content-Type: text/xml;charset=UTF-8
SOAPAction: ""
Content-Length: 1046
Host: 127.0.0.1:8080
Connection: Keep-Alive
User-Agent: Apache-HttpClient/4.1.1 (java 1.5)

<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/"
xmlns:sms="http://www.xxxxx.com.tr/xxxx-cccc/schema/smsNotification">
   <soapenv:Body>
      <sms:NotifySmsReceptionRequest>
         <!--Optional:-->
         <SessionId>12e12e21</SessionId>
         <!--Optional:-->
         <SmsServiceActivationNumber>121122d</SmsServiceActivationNumber>
         <!--Optional:-->
         <SenderAddress>
            <!--Optional:-->
            <Msisdn>905554443311</Msisdn>
            <!--Optional:-->
            <Asid/>
         </SenderAddress>
         <!--Optional:-->
         <Message>HEDIYE AKBIL</Message>
         <!--Optional:-->
         <MessageKey>MSG123123</MessageKey>
         <!--Optional:-->
         <PartTotal>1</PartTotal>
         <!--Optional:-->
         <PartNo>1</PartNo>
         <!--Zero or more repetitions:-->
         <NamedParam>
            <Key>token</Key>
            <Value>TKN123</Value>
         </NamedParam>
      </sms:NotifySmsReceptionRequest>
   </soapenv:Body>
</soapenv:Envelope>


Request

<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/"
xmlns:sms="http://www.xxxxx.com.tr/xxxx-cccc/schema/smsNotification">
   <soapenv:Body>
      <sms:NotifySmsReceptionRequest>
         <!--Optional:-->
         <SessionId>12e12e21</SessionId>
         <!--Optional:-->
         <SmsServiceActivationNumber>121122d</SmsServiceActivationNumber>
         <!--Optional:-->
         <SenderAddress>
            <!--Optional:-->
            <Msisdn>905554443311</Msisdn>
            <!--Optional:-->
            <Asid/>
         </SenderAddress>
         <!--Optional:-->
         <Message>HEDIYE AKBIL</Message>
         <!--Optional:-->
         <MessageKey>MSG123123</MessageKey>
         <!--Optional:-->
         <PartTotal>1</PartTotal>
         <!--Optional:-->
         <PartNo>1</PartNo>
         <!--Zero or more repetitions:-->
         <NamedParam>
            <Key>token</Key>
            <Value>TKN123</Value>
         </NamedParam>
      </sms:NotifySmsReceptionRequest>
   </soapenv:Body>
</soapenv:Envelope>

Response

<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
   <soap:Body>
      <NotifResponse xmlns="http://www.xxxxx.com.tr/xxxx-cccc/schema/smsNotification">
         <NotifResult>
            <resultCode xmlns="">OK</resultCode>
         </NotifResult>
      </NotifResponse>
   </soap:Body>
</soap:Envelope>
