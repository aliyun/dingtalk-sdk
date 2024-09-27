// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class ListItemUserDataResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("studyInfos")]
        [Validation(Required=false)]
        public List<ListItemUserDataResponseBodyStudyInfos> StudyInfos { get; set; }
        public class ListItemUserDataResponseBodyStudyInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("durationMillis")]
            [Validation(Required=false)]
            public long? DurationMillis { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16621*******284773</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
