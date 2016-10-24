using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ConsoleWriter
    {
        #region Declarations

        private ConsoleColor _successColor;    
        private ConsoleColor _errorColor;       
        

        private string _successText;            
        private string _errorText;              
       

        #endregion
        #region Properties

        
        public ConsoleColor SuccessColor { get { return _successColor; } set { _successColor = value; } }

       
        public ConsoleColor ErrorColor { get { return _errorColor; } set { _errorColor = value; } }

       
        public string SuccessText { get { return _successText; } set { _successText = value; } }

        
        public string ErrorText { get { return _errorText; } set { _errorText = value; } }

      
        public ConsoleColor ForegroundColor { get { return Console.ForegroundColor; } set { Console.ForegroundColor = value; } }

        
        public ConsoleColor BackgroundColor { get { return Console.BackgroundColor; } set { Console.BackgroundColor = value; } }

        #endregion

        #region Constructors

        
        public ConsoleWriter()
        {
            _successColor = ConsoleColor.Green;
            _errorColor = ConsoleColor.Red;
            

            _successText = "OK";
            _errorText = "ERROR";
            
        }

        #endregion

        #region Private methods
        #endregion
        #region Protected methods
        #endregion
        #region Public methods

        #region Write | WriteLine

      
        public void Write(string value)
        {
            Console.Write(value);
        }

      
        public void Write(ConsoleColor color, string value)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ForegroundColor = oldColor;
        }

      
        public void Write(string format, params object[] args)
        {
            Console.Write(string.Format(format, args));
        }

        
        public void Write(ConsoleColor color, string format, params object[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(string.Format(format, args));
            Console.ForegroundColor = oldColor;
        }

       
        public void WriteLine()
        {
            Console.WriteLine();
        }

      
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

       
        public void WriteLine(ConsoleColor color, string value)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = oldColor;
        }

   
        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(string.Format(format, args));
        }

       
        public void WriteLine(ConsoleColor color, string format, params object[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(string.Format(format, args));
            Console.ForegroundColor = oldColor;
        }

        #endregion
        #region WriteSuccess | WriteLineSuccess

        
        public void WriteSuccess()
        {
            Write(_successColor, _successText);
        }

   
        public void WriteSuccess(string value)
        {
            Write(_successColor, value);
        }

        
        public void WriteSuccess(string format, params object[] args)
        {
            Write(_successColor, string.Format(format, args));
        }

        
        public void WriteLineSuccess()
        {
            WriteLine(_successColor, _successText);
        }

      
        public void WriteLineSuccess(string value)
        {
            WriteLine(_successColor, value);
        }

       
        public void WriteLineSuccess(string format, params object[] args)
        {
            WriteLine(_successColor, string.Format(format, args));
        }

        #endregion
        #region WriteError | WriteLineError

        
        public void WriteError()
        {
            Write(_errorColor, _errorText);
        }

     
        public void WriteError(string value)
        {
            Write(_errorColor, value);
        }

        
        public void WriteError(string format, params object[] args)
        {
            Write(_errorColor, string.Format(format, args));
        }

     
        public void WriteLineError()
        {
            WriteLine(_errorColor, _errorText);
        }

        
        public void WriteLineError(string value)
        {
            WriteLine(_errorColor, value);
        }

        
        public void WriteLineError(string format, params object[] args)
        {
            WriteLine(_errorColor, string.Format(format, args));
        }

        #endregion
 

        #endregion

        
    }
}

