// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class ListStarsRequest : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("sortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        [NameInMap("supportResourceTypes")]
        [Validation(Required=false)]
        public List<string> SupportResourceTypes { get; set; }

    }

}
