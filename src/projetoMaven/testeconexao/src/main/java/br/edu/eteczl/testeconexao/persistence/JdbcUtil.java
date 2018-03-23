package br.edu.eteczl.testeconexao.persistence;

import java.sql.Connection;

import java.sql.DriverManager;
import java.sql.SQLException;

public class JdbcUtil {

	private static Connection conn;
	//private static String urlConn = "jdbc:sqlserver://localhost:1433;databaseName=lojainfo";
	//private static String urlConn = "jdbc:sqlserver://localhost\\SQLEXPRESS:1433=LAB-07-21;databaseName=lojainfo";
//	private static String urlConn = "jdbc:sqlserver://localhost:1433;instanceName=SQLEXPRESS;databaseName=lojainfo";
//	
//	private static String user = "SA";
//	private static String senha = "info211";

	

    private static String connectionDriverClass="org.gjt.mm.mysql.Driver";
   //private static String connectionDriverClass="com.mysql.jdbc.Driver";
    private static String connectionUrl="jdbc:mysql://localhost:3306/lojainfo";
    private static String connectionUsername="root";
    //private static String connectionPassword="admin123";
    private static String connectionPassword="";

    
	
	
	public static Connection getConnection() throws ClassNotFoundException, SQLException{
		if(JdbcUtil.conn != null){
			return JdbcUtil.conn;
		}else{
			Class.forName(connectionDriverClass);
			JdbcUtil.conn = DriverManager.getConnection(
					JdbcUtil.connectionUrl,JdbcUtil.connectionUsername,JdbcUtil.connectionPassword);
			return JdbcUtil.conn;
		}		
	}
	
}
