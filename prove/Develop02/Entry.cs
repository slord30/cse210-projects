using System;

//create class Entry
class Entry
{
  public string _prompt { get; set; }
  public string _response { get; set; }
  public DateTime _date { get; set; }

  public Entry(string prompt, string response)
  {
    _prompt = prompt;
    _response = response;
    _date = DateTime.Now;
  }

  public override string ToString()
  {
    return $"Date: {_date.ToString("MM/dd/yyyy")} - Prompt: {_prompt}\n{_response}\n";
  }
}