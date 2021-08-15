﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
namespace Chain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ChainDemo
    {
        public virtual AbstractLogger AbstractLogger
        {
            get;
            set;
        }

        public void Main()
        {
            var errorLogger = new ErrorLogger { Level = Level.Error};
            var fileLogger = new FileLogger { Level = Level.Debug };
            var consoleLogger = new ConsoleLogger { Level = Level.Info };

            errorLogger.NextLogger = fileLogger;
            fileLogger.NextLogger = consoleLogger;

            var loggerChain = errorLogger;

            loggerChain.LogMessage(Level.Info, "This is an information.");
            loggerChain.LogMessage(Level.Debug, "This is a debug information.");
            loggerChain.LogMessage(Level.Error, "This is a error information.");
        }


    }
}

