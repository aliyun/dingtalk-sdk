// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetAllDismissionReasonsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAllDismissionReasonsResponseBodyResult Result { get; set; }
        public class GetAllDismissionReasonsResponseBodyResult : TeaModel {
            [NameInMap("passiveList")]
            [Validation(Required=false)]
            public List<GetAllDismissionReasonsResponseBodyResultPassiveList> PassiveList { get; set; }
            public class GetAllDismissionReasonsResponseBodyResultPassiveList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>家庭原因</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("voluntaryList")]
            [Validation(Required=false)]
            public List<GetAllDismissionReasonsResponseBodyResultVoluntaryList> VoluntaryList { get; set; }
            public class GetAllDismissionReasonsResponseBodyResultVoluntaryList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>家庭原因</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
