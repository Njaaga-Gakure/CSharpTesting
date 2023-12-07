using Assessment;

Console.WriteLine("Testing....");

AssessmentQuestions ass = new();

try {
    Console.WriteLine(
    "Reversed number: " +     
    ass.ReverseInteger("one")
        
        
        );
  
} catch (Exception e) {
    Console.WriteLine($"Error: {e.Message}");
}