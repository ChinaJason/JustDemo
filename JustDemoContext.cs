using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace JustDemoTest{
    public class JustDemoContext : IDisposable
    {
        private readonly ILogger _logger;
    
        public JustDemoContext(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<JustDemoContext>();
            _logger.LogDebug("Constructing JustDemoContext");
        }
    
        public IEnumerable<string> GetItems()
        {
            try{                
                // throw new NullReferenceException();
                _logger.LogInformation("Found 3 items.");
                 
                 return new[]
                 {
                     "Demo Item 1",
                     "Demo Item 2",
                     "Demo Item 3",
                     "Demo Item 4",
                     "Demo Item 5"
                 };
            }catch(Exception ex)
            {
                _logger.LogError("I meet Exception",ex);   
                throw;             
            }          
        }
        
        public bool PostItems()
        {
            try{                
                 throw new NullReferenceException();   
                      
            }catch(Exception ex)
            {
                 _logger.LogError("I meet Exception",ex);   
                return false;
            }            
        }        
        public void Dispose()
        {
            _logger.LogDebug("Disposing JustDemoContext");
        }
        
    }
}