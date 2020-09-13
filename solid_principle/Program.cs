using System;
using solid_principleLib.client;

namespace solid_principle
{
  class MainClass {
    public static void Main (string[] args) {
      /// why use var?
      var client = new CannonMG2470();
      client.PhotoCopyContent("test text");
      client.PrintContent("test text");
      client.ScanContent("test text");

      var client2 = new HPLaserJet();
      client2.FaxContent("test text");
      client2.PhotoCopyContent("test text");
      client2.PrintContent("test text");
      client2.PrintDuplexContent("test text");
      client2.ScanContent("test text");
    }
  }

}