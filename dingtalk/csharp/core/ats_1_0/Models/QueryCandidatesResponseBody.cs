// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class QueryCandidatesResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCandidatesResponseBodyList> List { get; set; }
        public class QueryCandidatesResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>64167133e3394c6b9959eexxxxxxxxxx</para>
            /// </summary>
            [NameInMap("candidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding2c0158xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1701014400000</para>
            /// </summary>
            [NameInMap("entryDate")]
            [Validation(Required=false)]
            public int? EntryDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>013224566462xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
