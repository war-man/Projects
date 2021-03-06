package Database;

import java.awt.*;
import java.awt.event.*;

import javax.swing.*;
import javax.swing.event.*;

import java.sql.*;


public class GameTable extends JFrame 
{
	PreparedStatement ps;
	Connection conn;
	ResultSet rset;
	Statement stmt;
	JLabel l1;
	String bn,ba,bc,bt,bf;
	int mid,bid;
	
	Date d1,d2;
    int rows = 0;
	Object data1[][];
	JScrollPane scroller;
	JTable table;
	private DBConnection db;
	private JPanel contentPane;
	private JPanel p1;
	  
    public GameTable()
    {
    	setVisible(true);
    	db = new DBConnection();
		conn = db.openDB();

        Container cp = getContentPane();
        cp.setLayout(new BorderLayout());
   			
   		setSize(600,200);
    	setLocation(100,100);
   		setLayout(new BorderLayout());
   		setTitle("All Games");

		try 
		{
			stmt = conn.createStatement ();	//Creating Statement Object.
		}
		catch (SQLException sqlex)
		{			//If Problem then Show the User a Message.
 			JOptionPane.showMessageDialog (null, "A Problem Occurs While Loading Form.");
 			dispose ();				//Closing the Form.
	 	}
    
    	
    	try
    	{
    	    rset=stmt.executeQuery("SELECT * from Game");   	
    	    while(rset.next())
    	    {
    	 
    	    	bid = rset.getInt(1);
    			bn = rset.getString(2);
    			ba = rset.getString(3);
    			bc = rset.getString(4);
    			bf = rset.getString(6);   	  
    	 
    	    	rows++;
    	}  
    		
    	    data1=new Object[rows][5];
			Object[] Colheads={"stockid" ,"title", "publisher", "console", "stock"};
			rset=stmt.executeQuery("SELECT * from Game");
			
			
			for(int i1=0;i1<rows;i1++)
			{
				rset.next();
					for(int j1 = 0; j1 < 5; j1++)
					{
						data1[i1][j1]=rset.getString(j1+1);
					}
			}
			JTable table = new JTable(data1,Colheads)
			{
				private static final long serialVersionUID = 1L;

		        public boolean isCellEditable(int row, int column) 
		        {                
		                return false;               
		        }
			};
			int v=ScrollPaneConstants.VERTICAL_SCROLLBAR_AS_NEEDED;
			int h=ScrollPaneConstants.HORIZONTAL_SCROLLBAR_AS_NEEDED;
			
			JScrollPane jsp=new JScrollPane(table,v,h);
		
			getContentPane().add(jsp);
		
    	}
    	catch(Exception e)
    	{
    	}
    
    try
    {
    	data1=new Object[rows][6];
		Object[] Colheads={"stockid" ,"title", "publisher", "console", "stock"};
		rset=stmt.executeQuery("SELECT * from Game");
					
		for(int i1 = 0; i1 < rows; i1++)
		{
			rset.next();
			for(int j1=0;j1<5;j1++)
			{
				data1[i1][j1]=rset.getString(j1+1);
			}
		}
		JTable table=new JTable(data1,Colheads)
		{
			private static final long serialVersionUID = 1L;

			public boolean isCellEditable(int row, int column) 
			{                
				return false;               
			}
		};
		int v = ScrollPaneConstants.VERTICAL_SCROLLBAR_AS_NEEDED;
		int h = ScrollPaneConstants.HORIZONTAL_SCROLLBAR_AS_NEEDED;
				
		JScrollPane jsp=new JScrollPane(table,v,h);
					
		getContentPane().add(jsp);
		
    }
    catch(Exception e)
    {
    }	
    	setVisible(true);
    	setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);	
    }
    
    public static void main(String args[])
    {
     JFrame frm = new GameTable();
     frm.setSize(600, 200); 			
    }
 }
