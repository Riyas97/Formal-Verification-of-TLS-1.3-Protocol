using System;
using System.Collections.Generic;
using System.Text;
//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    /// <summary>
    /// The math library that can be used in your model.
    /// all methods should be declared as public static.
    /// 
    /// The parameters must be of type "int", or "int array"
    /// The number of parameters can be 0 or many
    /// 
    /// The return type can be bool, int or int[] only.
    /// 
    /// The method name will be used directly in your model.
    /// e.g. call(max, 10, 2), call(dominate, 3, 2), call(amax, [1,3,5]),
    /// 
    /// Note: method names are case sensetive
    /// </summary>
    public class MyTLS
    {
        public static int randomG() { 
        	return 2;
        }
        
        public static int randomP() {
        	return 9;
        }
        
        public static int random() {
        	Random rnd = new Random();
        	return rnd.Next(20);
        }
        
        public static int createMsg(int key, int G, int P) {
        	// return G^key mod P
        	return (int)(Math.Pow(G, key) % P);
        }
        
        public static int createPreMasterSecret(int key, int message, int P) {
        	// return message^key mod P
        	
        	return (int)(Math.Pow(message, key) % P);
        }
        
        public static int transferFunct(int seed) {
        	Random rnd = new Random(seed);
        	return rnd.Next();
        }
        
        public static int encrypt(int plainText, int publicKey) {
        	// do something
        	return plainText + publicKey;
        }
        
        public static int decrypt(int cipherText) {
        	return cipherText - 5;
        }        
    }
}
