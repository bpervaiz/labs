/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab8_sc;

/**
 *
 * @author Bisma
 */
public class Lab8_sc {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        DBConnect db = new DBConnect();
        db.batchUpdateUsingStatement();
    }
    
}
