using System;
using solid_principleLib.client;

namespace solid_principle
{
  class MainClass {
    public static void Main (string[] args) {
      /// why use var?
      var client = new CannonMG2470();
      client.PhotoCopyContent("text placeholder");
      client.PrintContent("text placeholder");
      client.ScanContent("text placeholder");

      var client2 = new HPLaserJet();
      client2.FaxContent("text placeholder");
      client2.PhotoCopyContent("text placeholder");
      client2.PrintContent("text placeholder");
      client2.PrintDuplexContent("text placeholder");
      client2.ScanContent("text placeholder");
    }
  }

}