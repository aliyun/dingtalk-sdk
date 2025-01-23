// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class AddToOrgSkillRepositoryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("actionId")]
        [Validation(Required=false)]
        public string ActionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("actionVersion")]
        [Validation(Required=false)]
        public string ActionVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

    }

}
