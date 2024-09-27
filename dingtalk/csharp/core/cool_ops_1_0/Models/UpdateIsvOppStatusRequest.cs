// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcool_ops_1_0.Models
{
    public class UpdateIsvOppStatusRequest : TeaModel {
        [NameInMap("isvOpportunityStatusList")]
        [Validation(Required=false)]
        public List<UpdateIsvOppStatusRequestIsvOpportunityStatusList> IsvOpportunityStatusList { get; set; }
        public class UpdateIsvOppStatusRequestIsvOpportunityStatusList : TeaModel {
            [NameInMap("isvCorpId")]
            [Validation(Required=false)]
            public string IsvCorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("microAppId")]
            [Validation(Required=false)]
            public string MicroAppId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("operCorpId")]
            [Validation(Required=false)]
            public string OperCorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("operName")]
            [Validation(Required=false)]
            public string OperName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("operTime")]
            [Validation(Required=false)]
            public string OperTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("operUserId")]
            [Validation(Required=false)]
            public string OperUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("oppSourceCorpId")]
            [Validation(Required=false)]
            public string OppSourceCorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("opportunityStatus")]
            [Validation(Required=false)]
            public string OpportunityStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
