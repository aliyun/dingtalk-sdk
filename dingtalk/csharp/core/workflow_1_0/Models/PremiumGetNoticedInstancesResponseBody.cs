// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetNoticedInstancesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGetNoticedInstancesResponseBodyResult Result { get; set; }
        public class PremiumGetNoticedInstancesResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<PremiumGetNoticedInstancesResponseBodyResultList> List { get; set; }
            public class PremiumGetNoticedInstancesResponseBodyResultList : TeaModel {
                [NameInMap("formMassage")]
                [Validation(Required=false)]
                public string FormMassage { get; set; }

                [NameInMap("originatorId")]
                [Validation(Required=false)]
                public string OriginatorId { get; set; }

                [NameInMap("originatorName")]
                [Validation(Required=false)]
                public string OriginatorName { get; set; }

                [NameInMap("originatorPhoto")]
                [Validation(Required=false)]
                public string OriginatorPhoto { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// </summary>
                [NameInMap("processCreateTime")]
                [Validation(Required=false)]
                public string ProcessCreateTime { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// </summary>
                [NameInMap("processEndTime")]
                [Validation(Required=false)]
                public string ProcessEndTime { get; set; }

                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("processType")]
                [Validation(Required=false)]
                public int? ProcessType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
