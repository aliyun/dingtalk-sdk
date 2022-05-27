// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetConfBaseInfoByLogicalIdResponseBody : TeaModel {
        /// <summary>
        /// 会议ID（仅在会议正式开始后才返回该字段）
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// 会议逻辑id
        /// </summary>
        [NameInMap("logicalConferenceId")]
        [Validation(Required=false)]
        public string LogicalConferenceId { get; set; }

        /// <summary>
        /// 会议创建用户昵称
        /// </summary>
        [NameInMap("nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public float? StartTime { get; set; }

        /// <summary>
        /// 会议标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 会议创建用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
