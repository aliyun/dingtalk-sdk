// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalObjectiveKeyActionListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>211042291978xxxx</para>
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6444f5e9a4261c6e699dxxxx</para>
        /// </summary>
        [NameInMap("keyResultId")]
        [Validation(Required=false)]
        public string KeyResultId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6444f5e9a4261c6e699dxxxx</para>
        /// </summary>
        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public string ObjectiveId { get; set; }

    }

}
