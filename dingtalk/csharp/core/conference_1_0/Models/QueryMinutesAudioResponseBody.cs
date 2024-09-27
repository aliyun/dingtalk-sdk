// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryMinutesAudioResponseBody : TeaModel {
        [NameInMap("audioList")]
        [Validation(Required=false)]
        public List<QueryMinutesAudioResponseBodyAudioList> AudioList { get; set; }
        public class QueryMinutesAudioResponseBodyAudioList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>59886</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631172094000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1127942</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx-hangzhou.oss-cn-hangzhou.aliyuncs.com/record_xxxx.mp3?Expires=1718045081&OSSAccessKeyId=TMP.3KdwHtvZxopmwacMZEdyb4WHLVmbArrNRB9CTKnR1MaJgmRjdmZczs6Rip66cgKgk2HhQon1yygvBnbY3uqEaZNeHBLcBa&Signature=OFWyAIY%2FdlzfwM9wIfEaKoAudkxxxxx">https://xxx-hangzhou.oss-cn-hangzhou.aliyuncs.com/record_xxxx.mp3?Expires=1718045081&amp;OSSAccessKeyId=TMP.3KdwHtvZxopmwacMZEdyb4WHLVmbArrNRB9CTKnR1MaJgmRjdmZczs6Rip66cgKgk2HhQon1yygvBnbY3uqEaZNeHBLcBa&amp;Signature=OFWyAIY%2FdlzfwM9wIfEaKoAudkxxxxx</a></para>
            /// </summary>
            [NameInMap("playUrl")]
            [Validation(Required=false)]
            public string PlayUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>290882268xxx1172033231</para>
            /// </summary>
            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631172094000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WFBkgJvtxxxxtSaA1jK4sgiEiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
