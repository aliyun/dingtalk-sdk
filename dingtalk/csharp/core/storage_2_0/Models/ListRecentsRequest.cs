// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class ListRecentsRequest : TeaModel {
        [NameInMap("fileTypes")]
        [Validation(Required=false)]
        public List<long?> FileTypes { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("operateTypes")]
        [Validation(Required=false)]
        public List<long?> OperateTypes { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
