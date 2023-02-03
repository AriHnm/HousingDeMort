using System;

namespace HDMPlugin
{
  public class PluginException : Exception
  {
    public PluginException() { }
    public PluginException(string message) : base($"HDM Exception: {message}") { }
  }
}
