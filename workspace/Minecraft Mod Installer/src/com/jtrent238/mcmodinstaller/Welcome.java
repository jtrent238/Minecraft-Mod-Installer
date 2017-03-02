package com.jtrent238.mcmodinstaller;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;

@SuppressWarnings("serial")
public class Welcome extends JFrame
{
    JButton button_close;
     JLabel info_0;
     
   public Welcome()
   {
     getContentPane().setLayout(null);
     setupGUI();
     setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
   }
   void setupGUI()
   {
     	button_close = new JButton();
	button_close.setLocation(498,51);
	button_close.setSize(50,25);
	button_close.setText("Close");
	getContentPane().add(button_close);

	info_0 = new JLabel();
	info_0.setLocation(6,8);
	info_0.setSize(545,34);
	info_0.setText("I Hope you enjoy using this program, if you need any help just Email me: jtrent238@outlook.com");
	getContentPane().add(info_0);

	setTitle("Welcome");
	setSize(567,114);
	setVisible(true);
	setResizable(true);
	
	
   }
    
}  
