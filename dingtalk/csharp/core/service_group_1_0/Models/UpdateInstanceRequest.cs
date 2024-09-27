// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hhdhg</para>
        /// </summary>
        [NameInMap("externalBizId")]
        [Validation(Required=false)]
        public string ExternalBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING_CUSTOMER</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;node_888&quot;:&quot;hhhh&quot;}</para>
        /// </summary>
        [NameInMap("formDataList")]
        [Validation(Required=false)]
        public string FormDataList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>888555</para>
        /// </summary>
        [NameInMap("openDataInstanceId")]
        [Validation(Required=false)]
        public string OpenDataInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>888***</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>88888</para>
        /// </summary>
        [NameInMap("ownerUnionId")]
        [Validation(Required=false)]
        public string OwnerUnionId { get; set; }

    }

}
