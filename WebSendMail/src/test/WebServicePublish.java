package test;

import javax.xml.ws.Endpoint;
import sendmail.SendMail;

public class WebServicePublish {

	public static void main(String[] args) {
		// TODO �Զ����ɵķ������
		 String address = "http://192.168.1.119:8888/Webservice";
		 //ʹ��Endpoint���ṩ��publish��������WebService������ʱҪ��֤ʹ�õĶ˿ں�û�б�����Ӧ�ó���ռ��
		 Endpoint.publish(address , new SendMail());
		 System.out.println("����webservice�ɹ�!");
	}
}
