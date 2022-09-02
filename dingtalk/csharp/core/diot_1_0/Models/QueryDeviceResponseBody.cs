// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class QueryDeviceResponseBody : TeaModel {
        /// <summary>
        /// 结果数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryDeviceResponseBodyData> Data { get; set; }
        public class QueryDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// 设备id
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// 设备昵称
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// 设备状态 0:在线 1:离线
            /// </summary>
            [NameInMap("deviceStatus")]
            [Validation(Required=false)]
            public long? DeviceStatus { get; set; }

            /// <summary>
            /// 设备类型
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// 设备类型名称
            /// </summary>
            [NameInMap("deviceTypeName")]
            [Validation(Required=false)]
            public string DeviceTypeName { get; set; }

            /// <summary>
            /// 直播地址
            /// </summary>
            [NameInMap("liveUrls")]
            [Validation(Required=false)]
            public QueryDeviceResponseBodyDataLiveUrls LiveUrls { get; set; }
            public class QueryDeviceResponseBodyDataLiveUrls : TeaModel {
                /// <summary>
                /// flv格式直播地址
                /// </summary>
                [NameInMap("flv")]
                [Validation(Required=false)]
                public string Flv { get; set; }

                /// <summary>
                /// hls格式直播地址
                /// </summary>
                [NameInMap("hls")]
                [Validation(Required=false)]
                public string Hls { get; set; }

                /// <summary>
                /// rtmp格式直播地址
                /// </summary>
                [NameInMap("rtmp")]
                [Validation(Required=false)]
                public string Rtmp { get; set; }

            }

            /// <summary>
            /// 设备地址
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 设备父节点id
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// 产品类型 摄像头:CAMERA 其它:OTHERS
            /// </summary>
            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

        }

        /// <summary>
        /// 当前页码
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
