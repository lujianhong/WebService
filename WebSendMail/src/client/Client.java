package client;

import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.StringTokenizer;
import java.util.Vector;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;
import sendmail.SendMailInterface;
import sendmail.SendMailInterface_Service;

public class Client extends JFrame implements ActionListener
{
	private static SendMailInterface sendMail;
	public static void main(String[] args)
	{
		SendMailInterface_Service sendMailInterface_Service=new SendMailInterface_Service();
		sendMail=sendMailInterface_Service.getSendMailPort();
		mail_frame();
	}
	private static JFrame frame = new JFrame("发送邮件");
	private static Container c = frame.getContentPane();
	private static JTextField input1 = new JTextField();
	static JLabel a1 = new JLabel("收信方地址(如果群发，地址请用“;”隔开):");
	private static JTextField input2 = new JTextField();
	static JLabel a2 = new JLabel("内容:");
	private static JButton send = new JButton("发送");
	

	static void mail_frame()
	{
		
        
		frame.setSize(300,300);
		
		c.setLayout(new BorderLayout());
		frame.setLocationRelativeTo(null);
		frame.setVisible(true);
		
		JPanel fieldPanel = new JPanel();
		fieldPanel.setLayout(null);
		
		a1.setBounds(10,20,250,20);
		fieldPanel.add(a1);
		input1.setBounds(10,50,250,20);
		fieldPanel.add(input1);
        
		a2.setBounds(10,80,80,20);;
		fieldPanel.add(a2);
		input2.setBounds(10,110,250,100);
		fieldPanel.add(input2);
		c.add(fieldPanel,"Center");
		
		Client client=new Client();
		send.addActionListener(client);
		JPanel buttonPanel = new JPanel();
		buttonPanel.setLayout(new FlowLayout());
		buttonPanel.add(send);
		c.add(buttonPanel,"South");

	}
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO 自动生成的方法存根
		if(e.getActionCommand()=="发送")  
        {  
        	String url=input1.getText();
        	Vector<String> URL=new Vector<String>();
        	StringTokenizer st = new StringTokenizer(url,";");
        	int i=0;
        	while(st.hasMoreTokens() )
        	{
            	URL.addElement(st.nextToken());
            	System.out.println(URL.get(i));
            	i++;
        	}
        	String payload=input2.getText();
        	if(URL.size()==1)
        	{
        		sendMail.sendEmail(URL.get(0),payload);
        	}
        	else if(URL.size()>1)
        	{
        		sendMail.sendEmailBatch(URL, payload);
        	}
        	else {
				System.out.println("收信地址不能为空");
			}
        }
	}
}
