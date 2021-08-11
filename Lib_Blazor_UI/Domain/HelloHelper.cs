using Microsoft.JSInterop;

namespace Lib_Blazor_UI
{
  public class HelloHelper
  {
    public HelloHelper(string name)
    {
      this.Name = name;
    }

    public string Name { get; set; }

    [JSInvokable]
    public string SayHello() => $"Hello, {this.Name}!";
  }
}
