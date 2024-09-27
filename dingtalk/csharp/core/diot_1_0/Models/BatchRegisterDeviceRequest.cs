// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchRegisterDeviceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("devices")]
        [Validation(Required=false)]
        public List<BatchRegisterDeviceRequestDevices> Devices { get; set; }
        public class BatchRegisterDeviceRequestDevices : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>002</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>摄像头002</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public int? DeviceStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Camera</para>
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>摄像头</para>
            /// </summary>
            [NameInMap("deviceTypeName")]
            [Validation(Required=false)]
            public string DeviceTypeName { get; set; }

            [NameInMap("extraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

            [NameInMap("liveUrls")]
            [Validation(Required=false)]
            public BatchRegisterDeviceRequestDevicesLiveUrls LiveUrls { get; set; }
            public class BatchRegisterDeviceRequestDevicesLiveUrls : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://abc.stream.flv">https://abc.stream.flv</a></para>
                /// </summary>
                [NameInMap("flv")]
                [Validation(Required=false)]
                public string Flv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://abc.stream.m3u8">https://abc.stream.m3u8</a></para>
                /// </summary>
                [NameInMap("hls")]
                [Validation(Required=false)]
                public string Hls { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rtmp://abc.stream</para>
                /// </summary>
                [NameInMap("rtmp")]
                [Validation(Required=false)]
                public string Rtmp { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>社区南门</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>001</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAMERA</para>
            /// </summary>
            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

        }

    }

}
