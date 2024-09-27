// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueueNotifyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("estimateWaitMin")]
        [Validation(Required=false)]
        public long? EstimateWaitMin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eWaJSqDcLsoiE</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("queuePlace")]
        [Validation(Required=false)]
        public long? QueuePlace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3333333333</para>
        /// </summary>
        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SourceTypeEnum</para>
        /// </summary>
        [NameInMap("targetChannel")]
        [Validation(Required=false)]
        public string TargetChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>你好，欢迎来到这里</para>
        /// </summary>
        [NameInMap("tips")]
        [Validation(Required=false)]
        public string Tips { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eeeeeeeeerrrrr</para>
        /// </summary>
        [NameInMap("visitorToken")]
        [Validation(Required=false)]
        public string VisitorToken { get; set; }

    }

}
