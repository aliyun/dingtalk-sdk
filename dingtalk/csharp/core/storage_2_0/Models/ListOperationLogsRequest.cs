// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class ListOperationLogsRequest : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public ListOperationLogsRequestOption Option { get; set; }
        public class ListOperationLogsRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>下载:download_file</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>next_token</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>union_id</para>
            /// </summary>
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>知识库:org_biz_meta</para>
            /// </summary>
            [NameInMap("scenes")]
            [Validation(Required=false)]
            public List<string> Scenes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>YndMj49yWj95B3qAfGz5pY9d83pmz5aA</para>
            /// </summary>
            [NameInMap("subjectId")]
            [Validation(Required=false)]
            public string SubjectId { get; set; }

        }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
