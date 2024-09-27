// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalCreateProgressRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>64bf87f8d7ace3616f0a1971</para>
        /// </summary>
        [NameInMap("krId")]
        [Validation(Required=false)]
        public string KrId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("mergeIntoLatestProgress")]
        [Validation(Required=false)]
        public bool? MergeIntoLatestProgress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>662e006fe4b0f579bbcb10cf</para>
        /// </summary>
        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public string ObjectiveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一条目标进展文本</para>
        /// </summary>
        [NameInMap("plainText")]
        [Validation(Required=false)]
        public string PlainText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>naturalWeek</para>
        /// </summary>
        [NameInMap("progressMergePeriod")]
        [Validation(Required=false)]
        public string ProgressMergePeriod { get; set; }

    }

}
