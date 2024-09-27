// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetContactsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("currentOperatorUserId")]
        [Validation(Required=false)]
        public string CurrentOperatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crm_contact</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingxxx</para>
        /// </summary>
        [NameInMap("providerCorpId")]
        [Validation(Required=false)]
        public string ProviderCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;queryGroupList&quot;:[{&quot;logicType&quot;:&quot;AND&quot;,&quot;queryObjectList&quot;:[{&quot;fieldId&quot;:&quot;contact_phone&quot;,&quot;value&quot;:&quot;18000000000&quot;},{&quot;fieldId&quot;:&quot;contact_related_customer&quot;,&quot;value&quot;:&quot;INST-XXX&quot;}]}]}</para>
        /// </summary>
        [NameInMap("queryDsl")]
        [Validation(Required=false)]
        public string QueryDsl { get; set; }

    }

}
