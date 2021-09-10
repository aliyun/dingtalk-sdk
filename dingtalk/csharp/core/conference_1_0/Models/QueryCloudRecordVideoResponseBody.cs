// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryCloudRecordVideoResponseBody : TeaModel {
        /// <summary>
        /// 视频列表
        /// </summary>
        [NameInMap("videoList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordVideoResponseBodyVideoList> VideoList { get; set; }
        public class QueryCloudRecordVideoResponseBodyVideoList : TeaModel {
            /// <summary>
            /// 音视频云录制Id，多份视频recordId一样
            /// </summary>
            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// 录制人UnionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 录制开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 记录类型,0-普通录制，1-合成的文件
            /// </summary>
            [NameInMap("recordType")]
            [Validation(Required=false)]
            public long? RecordType { get; set; }

            /// <summary>
            /// 录制持续时间
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 文件大小
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// 录制结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 媒体文件id，唯一
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// 媒体文件所在集群id
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
