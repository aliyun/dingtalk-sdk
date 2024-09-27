// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class StaffLabelRecordsQueryRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<StaffLabelRecordsQueryRequestBody> Body { get; set; }
        public class StaffLabelRecordsQueryRequestBody : TeaModel {
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<StaffLabelRecordsQueryRequestBodyLabels> Labels { get; set; }
            public class StaffLabelRecordsQueryRequestBodyLabels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>long_termism_score</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>values</para>
                /// </summary>
                [NameInMap("typeCode")]
                [Validation(Required=false)]
                public string TypeCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0140180438261064274667</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0140180438261064274667</para>
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
