// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class MultiOrgPermissionGrantRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("grantDeptIdList")]
        [Validation(Required=false)]
        public List<long?> GrantDeptIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxxx</para>
        /// </summary>
        [NameInMap("joinCorpId")]
        [Validation(Required=false)]
        public string JoinCorpId { get; set; }

    }

}
