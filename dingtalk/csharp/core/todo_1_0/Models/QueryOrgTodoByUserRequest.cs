// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryOrgTodoByUserRequest : TeaModel {
        [NameInMap("fromDueTime")]
        [Validation(Required=false)]
        public long? FromDueTime { get; set; }

        [NameInMap("isDone")]
        [Validation(Required=false)]
        public bool? IsDone { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("needPersonalTodo")]
        [Validation(Required=false)]
        public bool? NeedPersonalTodo { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("roleTypes")]
        [Validation(Required=false)]
        public List<List<string>> RoleTypes { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("toDueTime")]
        [Validation(Required=false)]
        public long? ToDueTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TODO</para>
        /// </summary>
        [NameInMap("todoType")]
        [Validation(Required=false)]
        public string TodoType { get; set; }

    }

}
