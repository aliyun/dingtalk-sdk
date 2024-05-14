// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryInstancesByMultiConditionsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("searchFields")]
        [Validation(Required=false)]
        public string SearchFields { get; set; }

        [NameInMap("sortFields")]
        [Validation(Required=false)]
        public List<QueryInstancesByMultiConditionsRequestSortFields> SortFields { get; set; }
        public class QueryInstancesByMultiConditionsRequestSortFields : TeaModel {
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            [NameInMap("sortBy")]
            [Validation(Required=false)]
            public string SortBy { get; set; }

        }

    }

}
