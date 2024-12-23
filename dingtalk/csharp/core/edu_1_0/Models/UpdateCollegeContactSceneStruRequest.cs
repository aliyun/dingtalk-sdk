// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateCollegeContactSceneStruRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>场景架构标识</para>
        /// </summary>
        [NameInMap("sourceIdentifier")]
        [Validation(Required=false)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是场景架构简介</para>
        /// </summary>
        [NameInMap("struBrief")]
        [Validation(Required=false)]
        public string StruBrief { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("struId")]
        [Validation(Required=false)]
        public long? StruId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>科研架构</para>
        /// </summary>
        [NameInMap("struName")]
        [Validation(Required=false)]
        public string StruName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>stru_research_dept</para>
        /// </summary>
        [NameInMap("struType")]
        [Validation(Required=false)]
        public string StruType { get; set; }

    }

}
