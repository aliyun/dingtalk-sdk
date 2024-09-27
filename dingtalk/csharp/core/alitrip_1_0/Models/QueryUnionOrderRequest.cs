// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryUnionOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant1231</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>第三方审批单号，关联单号和申请单号必选其一</para>
        /// </summary>
        [NameInMap("thirdPartApplyId")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>关联单号，关联单号和申请单号必选其一</para>
        /// </summary>
        [NameInMap("unionNo")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

    }

}
