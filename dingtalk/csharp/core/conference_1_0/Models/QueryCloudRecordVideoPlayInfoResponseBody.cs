// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryCloudRecordVideoPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>59886</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1127942</para>
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://vod.mcs.dingtalk.com/faa1566c5bc24f21821ae2394f82db2e/8bbd1612e686462ab4717919f67bb721-b8531e0d534b2f9747a9fdfxxxxxxxxc-sd.mp4">https://vod.mcs.dingtalk.com/faa1566c5bc24f21821ae2394f82db2e/8bbd1612e686462ab4717919f67bb721-b8531e0d534b2f9747a9fdfxxxxxxxxc-sd.mp4</a></para>
        /// </summary>
        [NameInMap("mp4FileUrl")]
        [Validation(Required=false)]
        public string Mp4FileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://vod.mcs.dingtalk.com/faa1566c5bc24f21821ae2394f82db2e/8bbd1612e686462ab4717919f67bb721-ab85cc044a163568c9485xxxxxxxx76d-sd.m3u8">https://vod.mcs.dingtalk.com/faa1566c5bc24f21821ae2394f82db2e/8bbd1612e686462ab4717919f67bb721-ab85cc044a163568c9485xxxxxxxx76d-sd.m3u8</a></para>
        /// </summary>
        [NameInMap("playUrl")]
        [Validation(Required=false)]
        public string PlayUrl { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
