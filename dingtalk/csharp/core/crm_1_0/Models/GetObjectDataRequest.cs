// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetObjectDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding_userid</para>
        /// </summary>
        [NameInMap("currentOperatorUserId")]
        [Validation(Required=false)]
        public string CurrentOperatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-EF199CCA-8AB6-482A-AE10-85EDE5E391D9</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;queryGroupList&quot;:[{&quot;logicType&quot;:&quot;AND&quot;,&quot;queryObjectList&quot;:[{&quot;fieldId&quot;:&quot;contact_phone&quot;,&quot;value&quot;:&quot;18000000000&quot;},{&quot;fieldId&quot;:&quot;contact_related_customer&quot;,&quot;value&quot;:&quot;INST-XXX&quot;}]}]}</para>
        /// </summary>
        [NameInMap("queryDsl")]
        [Validation(Required=false)]
        public string QueryDsl { get; set; }

    }

}
