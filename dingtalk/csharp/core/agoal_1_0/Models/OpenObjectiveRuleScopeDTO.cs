// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenObjectiveRuleScopeDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82347xxx2382</para>
        /// </summary>
        [NameInMap("scopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
