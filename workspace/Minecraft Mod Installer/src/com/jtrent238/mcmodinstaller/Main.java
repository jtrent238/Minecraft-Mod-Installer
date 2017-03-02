package com.jtrent238.mcmodinstaller;



import javax.swing.*;

public class Main extends JFrame
{

	/**
	 * 
	 */
	private static final long serialVersionUID = 3013034703985402896L;
	private static boolean firstRun;
	JButton install_button;
     JList<?> modlist;
     JLabel info_0;
     JButton help_button;
     
   public Main()
   {
     getContentPane().setLayout(null);
     setupGUI();
     setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
   }
   void setupGUI()
   {
    
	install_button = new JButton();
	install_button.setLocation(465,388);
	install_button.setSize(75,25);
	install_button.setText("Install");
	getContentPane().add(install_button);

	modlist = new JList<Object>();
	modlist.setLocation(3,7);
	modlist.setSize(227,411);
	getContentPane().add(modlist);

	info_0 = new JLabel();
	info_0.setLocation(239,10);
	info_0.setSize(275,20);
	info_0.setText("Select a mod to install from the list on the left.");
	getContentPane().add(info_0);

	help_button = new JButton();
	help_button.setLocation(238,389);
	help_button.setSize(75,25);
	help_button.setText("Help");
	help_button.addActionListener(null);
	getContentPane().add(help_button);

	setTitle("Minecraft Mod Installer - By: jtrent238");
	setSize(559,458);
	setVisible(true);
	setResizable(false);
	
	
   }
    public static void main( String args[] )
   {
    	if(firstRun == true){
    		new Welcome();
    	}
    		else{
    			new Main();
    		}

   }
}  