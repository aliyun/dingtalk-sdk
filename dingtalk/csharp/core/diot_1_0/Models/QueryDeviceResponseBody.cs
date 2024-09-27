// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class QueryDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryDeviceResponseBodyData> Data { get; set; }
        public class QueryDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XX摄像头</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public long? DeviceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAMERA</para>
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>摄像头</para>
            /// </summary>
            [NameInMap("deviceTypeName")]
            [Validation(Required=false)]
            public string DeviceTypeName { get; set; }

            [NameInMap("liveUrls")]
            [Validation(Required=false)]
            public QueryDeviceResponseBodyDataLiveUrls LiveUrls { get; set; }
            public class QueryDeviceResponseBodyDataLiveUrls : TeaModel {
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
            /// <para>XX地址</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAMERA</para>
            /// </summary>
            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
