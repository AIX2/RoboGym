// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: animalai/communicator_objects/command_proto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from animalai/communicator_objects/command_proto.proto</summary>
  public static partial class CommandProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for animalai/communicator_objects/command_proto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommandProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFhbmltYWxhaS9jb21tdW5pY2F0b3Jfb2JqZWN0cy9jb21tYW5kX3Byb3Rv",
            "LnByb3RvEhRjb21tdW5pY2F0b3Jfb2JqZWN0cyotCgxDb21tYW5kUHJvdG8S",
            "CAoEU1RFUBAAEgkKBVJFU0VUEAESCAoEUVVJVBACQh+qAhxNTEFnZW50cy5D",
            "b21tdW5pY2F0b3JPYmplY3RzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MLAgents.CommunicatorObjects.CommandProto), }, null));
    }
    #endregion

  }
  #region Enums
  public enum CommandProto {
    [pbr::OriginalName("STEP")] Step = 0,
    [pbr::OriginalName("RESET")] Reset = 1,
    [pbr::OriginalName("QUIT")] Quit = 2,
  }

  #endregion

}

#endregion Designer generated code