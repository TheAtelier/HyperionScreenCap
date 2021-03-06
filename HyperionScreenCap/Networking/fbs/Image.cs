// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace hyperionnet
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Image : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Image GetRootAsImage(ByteBuffer _bb) { return GetRootAsImage(_bb, new Image()); }
  public static Image GetRootAsImage(ByteBuffer _bb, Image obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Image __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public hyperionnet.ImageType DataType { get { int o = __p.__offset(4); return o != 0 ? (hyperionnet.ImageType)__p.bb.Get(o + __p.bb_pos) : hyperionnet.ImageType.NONE; } }
  public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public int Duration { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)-1; } }
  public bool MutateDuration(int duration) { int o = __p.__offset(8); if (o != 0) { __p.bb.PutInt(o + __p.bb_pos, duration); return true; } else { return false; } }

  public static Offset<hyperionnet.Image> CreateImage(FlatBufferBuilder builder,
      hyperionnet.ImageType data_type = hyperionnet.ImageType.NONE,
      int dataOffset = 0,
      int duration = -1) {
    builder.StartTable(3);
    Image.AddDuration(builder, duration);
    Image.AddData(builder, dataOffset);
    Image.AddDataType(builder, data_type);
    return Image.EndImage(builder);
  }

  public static void StartImage(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddDataType(FlatBufferBuilder builder, hyperionnet.ImageType dataType) { builder.AddByte(0, (byte)dataType, 0); }
  public static void AddData(FlatBufferBuilder builder, int dataOffset) { builder.AddOffset(1, dataOffset, 0); }
  public static void AddDuration(FlatBufferBuilder builder, int duration) { builder.AddInt(2, duration, -1); }
  public static Offset<hyperionnet.Image> EndImage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 6);  // data
    return new Offset<hyperionnet.Image>(o);
  }
  public ImageT UnPack() {
    var _o = new ImageT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ImageT _o) {
    _o.Data = new hyperionnet.ImageTypeUnion();
    _o.Data.Type = this.DataType;
    switch (this.DataType) {
      default: break;
      case hyperionnet.ImageType.RawImage:
        _o.Data.Value = this.Data<hyperionnet.RawImage>().HasValue ? this.Data<hyperionnet.RawImage>().Value.UnPack() : null;
        break;
    }
    _o.Duration = this.Duration;
  }
  public static Offset<hyperionnet.Image> Pack(FlatBufferBuilder builder, ImageT _o) {
    if (_o == null) return default(Offset<hyperionnet.Image>);
    var _data_type = _o.Data == null ? hyperionnet.ImageType.NONE : _o.Data.Type;
    var _data = _o.Data == null ? 0 : hyperionnet.ImageTypeUnion.Pack(builder, _o.Data);
    return CreateImage(
      builder,
      _data_type,
      _data,
      _o.Duration);
  }
};

public class ImageT
{
  public hyperionnet.ImageTypeUnion Data { get; set; }
  public int Duration { get; set; }

  public ImageT() {
    this.Data = null;
    this.Duration = -1;
  }
}


}
