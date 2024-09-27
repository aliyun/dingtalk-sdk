// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelatedViewTabDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetRelatedViewTabDataResponseBodyResult Result { get; set; }
        public class GetRelatedViewTabDataResponseBodyResult : TeaModel {
            [NameInMap("page")]
            [Validation(Required=false)]
            public GetRelatedViewTabDataResponseBodyResultPage Page { get; set; }
            public class GetRelatedViewTabDataResponseBodyResultPage : TeaModel {
                [NameInMap("hasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                [NameInMap("list")]
                [Validation(Required=false)]
                public List<GetRelatedViewTabDataResponseBodyResultPageList> List { get; set; }
                public class GetRelatedViewTabDataResponseBodyResultPageList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>西游四人组:孙悟空</para>
                    /// </summary>
                    [NameInMap("abstractMessage")]
                    [Validation(Required=false)]
                    public string AbstractMessage { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>王凯提交的楚衣的流程表单2</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("nextToken")]
                [Validation(Required=false)]
                public long? NextToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

    }

}
