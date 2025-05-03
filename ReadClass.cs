/**
 * The Read4 API is defined in the parent class Reader4.
 *     int Read4(char[] buf4);
 */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Number of characters to read
     * @return    The number of actual characters read
     */
     // TC => O(n)
     // SC => O(1)
     char[] mybuffer = new char[4];
     int buffsize;
     int index;
    public int Read(char[] buf, int n) {
        if(buffsize == 0){
            buffsize = Read4(mybuffer);
        }

        int i = 0;
        while(i < n && buffsize > 0){
            buf[i++] = mybuffer[index++];
            if(index == buffsize){
                buffsize = Read4(mybuffer);
                index = 0;
            }
        }
        return i;
    }
}
