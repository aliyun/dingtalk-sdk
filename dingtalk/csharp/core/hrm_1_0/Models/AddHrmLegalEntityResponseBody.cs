// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AddHrmLegalEntityResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddHrmLegalEntityResponseBodyResult Result { get; set; }
        public class AddHrmLegalEntityResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding123</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-01</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-01</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("legalEntityId")]
            [Validation(Required=false)]
            public string LegalEntityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>公司1</para>
            /// </summary>
            [NameInMap("legalEntityName")]
            [Validation(Required=false)]
            public string LegalEntityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>公1</para>
            /// </summary>
            [NameInMap("legalEntityShortName")]
            [Validation(Required=false)]
            public string LegalEntityShortName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("legalEntityStatus")]
            [Validation(Required=false)]
            public int? LegalEntityStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>法人</para>
            /// </summary>
            [NameInMap("legalPersonName")]
            [Validation(Required=false)]
            public string LegalPersonName { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
