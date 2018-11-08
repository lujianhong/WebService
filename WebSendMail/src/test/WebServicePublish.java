package test;

import javax.xml.ws.Endpoint;
import sendmail.SendMail;

public class WebServicePublish {

	public static void main(String[] args) {
		// TODO 自动生成的方法存根
		 String address = "http://192.168.1.119:8888/Webservice";
		 //使用Endpoint类提供的publish方法发布WebService，发布时要保证使用的端口号没有被其他应用程序占用
		 Endpoint.publish(address , new SendMail());
		 System.out.println("发布webservice成功!");
	}
}
