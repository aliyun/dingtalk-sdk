// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0.Models
{
    public class GetSendAndReceiveReportListResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<GetSendAndReceiveReportListResponseBodyDataList> DataList { get; set; }
        public class GetSendAndReceiveReportListResponseBodyDataList : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
