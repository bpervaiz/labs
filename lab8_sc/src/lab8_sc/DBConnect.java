
package lab8_sc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Calendar;
import java.util.Scanner;

public class DBConnect {
    private Connection con;
    private Statement st;
    private PreparedStatement pst;
    private ResultSet rs;
    
    
    public void insertData(){
            try
    {
      // create a mysql database connection
      String myDriver = "org.gjt.mm.mysql.Driver";
      String myUrl = "jdbc:mysql://localhost/university";
      Class.forName(myDriver);
      Connection conn = DriverManager.getConnection(myUrl, "root", "");
      conn.setAutoCommit(true);
      Statement st = conn.createStatement();
      for(int i=5000; i<10000;i++){
        String query = "INSERT INTO student (ID, RegNo, Name, Semester, Address) VALUES (NULL,1000"+i+",'Bisma"+i+"',5,'house "+i+"')";
        st.executeUpdate(query);
        
      }
      
      conn.close();
    }
    catch (Exception e)
    {
      System.err.println("Got an exception!");
      System.err.println(e.getMessage());
    }
    }
    
    public void insertDataPreparedSt(){
        try
    {
      // create a mysql database connection
      String myDriver = "org.gjt.mm.mysql.Driver";
      String myUrl = "jdbc:mysql://localhost/university";
      Class.forName(myDriver);
      Connection conn = DriverManager.getConnection(myUrl, "root", "");
    
      conn.setAutoCommit(false);
      for(int i=500; i<10000;i++){
        String query = "INSERT INTO student (ID, RegNo, Name, Semester, Address) VALUES (NULL, ?, ?, ?, ?)";
        //st.executeUpdate(query);
        
      
      // create the mysql insert preparedstatement
      PreparedStatement preparedStmt = conn.prepareStatement(query);
      preparedStmt.setInt (1, 5000+i);
      preparedStmt.setString (2, "Sara"+i);
      preparedStmt.setInt   (3, 4);
      preparedStmt.setString(4, "House "+i);

      // execute the preparedstatement
      preparedStmt.execute();
      }
      conn.commit();
      conn.close();
    }    
       
    catch (Exception e)
    {
      System.err.println("Got an exception!");
      System.err.println(e.getMessage());
    }
    }
    
    public void batchUpdateUsingStatement() {

      
	
	int[] result = null;
	try {
            String myDriver = "org.gjt.mm.mysql.Driver";
            String myUrl = "jdbc:mysql://localhost/university";
            Class.forName(myDriver);
            Connection conn = DriverManager.getConnection(myUrl, "root", "");
		Statement stmt = conn.createStatement();

		conn.setAutoCommit(true); // Setting auto-commit off
                for(int i=5000;i<10000;i++){
		String SQL = "INSERT INTO student (ID, RegNo, Name, Semester, Address) VALUES (NULL,12000"+i+",'Ali"+i+"',5,'house "+i+"')";
		stmt.addBatch(SQL); // add statement to Batch
		result = stmt.executeBatch(); // execute the Batch
                }
		
                conn.close();
	} catch (Exception e) {
		
	} 
}
    
    
}
