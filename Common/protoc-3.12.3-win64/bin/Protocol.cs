// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protocol.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.Protocol {

  /// <summary>Holder for reflection information generated from Protocol.proto</summary>
  public static partial class ProtocolReflection {

    #region Descriptor
    /// <summary>File descriptor for Protocol.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtocolReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5Qcm90b2NvbC5wcm90bxIIUHJvdG9jb2waH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8iGQoGQ19DaGF0Eg8KB2NvbnRleHQYASABKAkiGQoG",
            "U19DaGF0Eg8KB2NvbnRleHQYASABKAkiHgoLU19FbnRlckdhbWUSDwoHY29u",
            "dGV4dBgBIAEoCSKHAgoGUGVyc29uEgwKBG5hbWUYASABKAkSCgoCaWQYAiAB",
            "KAUSDQoFZW1haWwYAyABKAkSLAoGcGhvbmVzGAQgAygLMhwuUHJvdG9jb2wu",
            "UGVyc29uLlBob25lTnVtYmVyEjAKDGxhc3RfdXBkYXRlZBgFIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAaRwoLUGhvbmVOdW1iZXISDgoGbnVt",
            "YmVyGAEgASgJEigKBHR5cGUYAiABKA4yGi5Qcm90b2NvbC5QZXJzb24uUGhv",
            "bmVUeXBlIisKCVBob25lVHlwZRIKCgZNT0JJTEUQABIICgRIT01FEAESCAoE",
            "V09SSxACIi8KC0FkZHJlc3NCb29rEiAKBnBlb3BsZRgBIAMoCzIQLlByb3Rv",
            "Y29sLlBlcnNvbioxCgVNc2dJZBIKCgZDX0NIQVQQABIKCgZTX0NIQVQQARIQ",
            "CgxTX0VOVEVSX0dBTUUQA0IbqgIYR29vZ2xlLlByb3RvYnVmLlByb3RvY29s",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Protobuf.Protocol.MsgId), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.C_Chat), global::Google.Protobuf.Protocol.C_Chat.Parser, new[]{ "Context" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.S_Chat), global::Google.Protobuf.Protocol.S_Chat.Parser, new[]{ "Context" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.S_EnterGame), global::Google.Protobuf.Protocol.S_EnterGame.Parser, new[]{ "Context" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.Person), global::Google.Protobuf.Protocol.Person.Parser, new[]{ "Name", "Id", "Email", "Phones", "LastUpdated" }, null, new[]{ typeof(global::Google.Protobuf.Protocol.Person.Types.PhoneType) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.Person.Types.PhoneNumber), global::Google.Protobuf.Protocol.Person.Types.PhoneNumber.Parser, new[]{ "Number", "Type" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.AddressBook), global::Google.Protobuf.Protocol.AddressBook.Parser, new[]{ "People" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum MsgId {
    [pbr::OriginalName("C_CHAT")] CChat = 0,
    [pbr::OriginalName("S_CHAT")] SChat = 1,
    [pbr::OriginalName("S_ENTER_GAME")] SEnterGame = 3,
  }

  #endregion

  #region Messages
  public sealed partial class C_Chat : pb::IMessage<C_Chat> {
    private static readonly pb::MessageParser<C_Chat> _parser = new pb::MessageParser<C_Chat>(() => new C_Chat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C_Chat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.Protocol.ProtocolReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C_Chat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C_Chat(C_Chat other) : this() {
      context_ = other.context_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C_Chat Clone() {
      return new C_Chat(this);
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 1;
    private string context_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Context {
      get { return context_; }
      set {
        context_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as C_Chat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(C_Chat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Context != other.Context) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Context.Length != 0) hash ^= Context.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Context.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Context);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Context.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Context);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(C_Chat other) {
      if (other == null) {
        return;
      }
      if (other.Context.Length != 0) {
        Context = other.Context;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Context = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class S_Chat : pb::IMessage<S_Chat> {
    private static readonly pb::MessageParser<S_Chat> _parser = new pb::MessageParser<S_Chat>(() => new S_Chat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S_Chat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.Protocol.ProtocolReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S_Chat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S_Chat(S_Chat other) : this() {
      context_ = other.context_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S_Chat Clone() {
      return new S_Chat(this);
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 1;
    private string context_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Context {
      get { return context_; }
      set {
        context_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S_Chat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S_Chat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Context != other.Context) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Context.Length != 0) hash ^= Context.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Context.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Context);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Context.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Context);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S_Chat other) {
      if (other == null) {
        return;
      }
      if (other.Context.Length != 0) {
        Context = other.Context;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Context = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class S_EnterGame : pb::IMessage<S_EnterGame> {
    private static readonly pb::MessageParser<S_EnterGame> _parser = new pb::MessageParser<S_EnterGame>(() => new S_EnterGame());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S_EnterGame> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.Protocol.ProtocolReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S_EnterGame() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S_EnterGame(S_EnterGame other) : this() {
      context_ = other.context_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S_EnterGame Clone() {
      return new S_EnterGame(this);
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 1;
    private string context_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Context {
      get { return context_; }
      set {
        context_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S_EnterGame);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S_EnterGame other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Context != other.Context) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Context.Length != 0) hash ^= Context.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Context.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Context);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Context.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Context);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S_EnterGame other) {
      if (other == null) {
        return;
      }
      if (other.Context.Length != 0) {
        Context = other.Context;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Context = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Person : pb::IMessage<Person> {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.Protocol.ProtocolReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person(Person other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      email_ = other.email_;
      phones_ = other.phones_.Clone();
      lastUpdated_ = other.lastUpdated_ != null ? other.lastUpdated_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private int id_;
    /// <summary>
    /// Unique ID number for this person.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "phones" field.</summary>
    public const int PhonesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Protobuf.Protocol.Person.Types.PhoneNumber> _repeated_phones_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Protobuf.Protocol.Person.Types.PhoneNumber.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.Protocol.Person.Types.PhoneNumber> phones_ = new pbc::RepeatedField<global::Google.Protobuf.Protocol.Person.Types.PhoneNumber>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.Protocol.Person.Types.PhoneNumber> Phones {
      get { return phones_; }
    }

    /// <summary>Field number for the "last_updated" field.</summary>
    public const int LastUpdatedFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastUpdated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastUpdated {
      get { return lastUpdated_; }
      set {
        lastUpdated_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (Email != other.Email) return false;
      if(!phones_.Equals(other.phones_)) return false;
      if (!object.Equals(LastUpdated, other.LastUpdated)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      hash ^= phones_.GetHashCode();
      if (lastUpdated_ != null) hash ^= LastUpdated.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      phones_.WriteTo(output, _repeated_phones_codec);
      if (lastUpdated_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LastUpdated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      size += phones_.CalculateSize(_repeated_phones_codec);
      if (lastUpdated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastUpdated);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      phones_.Add(other.phones_);
      if (other.lastUpdated_ != null) {
        if (lastUpdated_ == null) {
          LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastUpdated.MergeFrom(other.LastUpdated);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            phones_.AddEntriesFrom(input, _repeated_phones_codec);
            break;
          }
          case 42: {
            if (lastUpdated_ == null) {
              LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastUpdated);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Person message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PhoneType {
        [pbr::OriginalName("MOBILE")] Mobile = 0,
        [pbr::OriginalName("HOME")] Home = 1,
        [pbr::OriginalName("WORK")] Work = 2,
      }

      public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber> {
        private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Protobuf.Protocol.Person.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber(PhoneNumber other) : this() {
          number_ = other.number_;
          type_ = other.type_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber Clone() {
          return new PhoneNumber(this);
        }

        /// <summary>Field number for the "number" field.</summary>
        public const int NumberFieldNumber = 1;
        private string number_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Number {
          get { return number_; }
          set {
            number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::Google.Protobuf.Protocol.Person.Types.PhoneType type_ = global::Google.Protobuf.Protocol.Person.Types.PhoneType.Mobile;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.Protocol.Person.Types.PhoneType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PhoneNumber);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PhoneNumber other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Number != other.Number) return false;
          if (Type != other.Type) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Number.Length != 0) hash ^= Number.GetHashCode();
          if (Type != global::Google.Protobuf.Protocol.Person.Types.PhoneType.Mobile) hash ^= Type.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Number.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Number);
          }
          if (Type != global::Google.Protobuf.Protocol.Person.Types.PhoneType.Mobile) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Number.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
          }
          if (Type != global::Google.Protobuf.Protocol.Person.Types.PhoneType.Mobile) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PhoneNumber other) {
          if (other == null) {
            return;
          }
          if (other.Number.Length != 0) {
            Number = other.Number;
          }
          if (other.Type != global::Google.Protobuf.Protocol.Person.Types.PhoneType.Mobile) {
            Type = other.Type;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Number = input.ReadString();
                break;
              }
              case 16: {
                Type = (global::Google.Protobuf.Protocol.Person.Types.PhoneType) input.ReadEnum();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// Our address book file is just one of these.
  /// </summary>
  public sealed partial class AddressBook : pb::IMessage<AddressBook> {
    private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.Protocol.ProtocolReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook(AddressBook other) : this() {
      people_ = other.people_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook Clone() {
      return new AddressBook(this);
    }

    /// <summary>Field number for the "people" field.</summary>
    public const int PeopleFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.Protocol.Person> _repeated_people_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.Protocol.Person.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.Protocol.Person> people_ = new pbc::RepeatedField<global::Google.Protobuf.Protocol.Person>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.Protocol.Person> People {
      get { return people_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressBook);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressBook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!people_.Equals(other.people_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= people_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      people_.WriteTo(output, _repeated_people_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += people_.CalculateSize(_repeated_people_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressBook other) {
      if (other == null) {
        return;
      }
      people_.Add(other.people_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            people_.AddEntriesFrom(input, _repeated_people_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
