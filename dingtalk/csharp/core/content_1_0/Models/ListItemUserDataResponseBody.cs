// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class ListItemUserDataResponseBody : TeaModel {
        /// <summary>
        /// 学习的时长记录
        /// </summary>
        [NameInMap("studyInfos")]
        [Validation(Required=false)]
        public List<ListItemUserDataResponseBodyStudyInfos> StudyInfos { get; set; }
        public class ListItemUserDataResponseBodyStudyInfos : TeaModel {
            /// <summary>
            /// 时间持续长度，单位为毫秒
            /// </summary>
            [NameInMap("durationMillis")]
            [Validation(Required=false)]
            public long? DurationMillis { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
