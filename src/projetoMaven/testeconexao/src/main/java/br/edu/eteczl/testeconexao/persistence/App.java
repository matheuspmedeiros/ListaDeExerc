package br.edu.eteczl.testeconexao.persistence;



import java.sql.Connection;
import java.sql.SQLException;

/**
 * Hello world!
 * mysql_upgrade -u root -p --force
 * restartar o banco
 */
public class App 
{
    public static void main( String[] args )
    {
        try {
			Connection conn = JdbcUtil.getConnection();
			System.out.println(conn);
		} catch (ClassNotFoundException e) {		
			e.printStackTrace();
		} catch (SQLException e) {		
			e.printStackTrace();
		}
    }
}
