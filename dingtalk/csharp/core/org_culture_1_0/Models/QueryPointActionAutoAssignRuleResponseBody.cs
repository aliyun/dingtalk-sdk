// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryPointActionAutoAssignRuleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPointActionAutoAssignRuleResponseBodyResult Result { get; set; }
        public class QueryPointActionAutoAssignRuleResponseBodyResult : TeaModel {
            [NameInMap("queryPointRuleResponseDTOS")]
            [Validation(Required=false)]
            public List<QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS> QueryPointRuleResponseDTOS { get; set; }
            public class QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("awardScore")]
                [Validation(Required=false)]
                public long? AwardScore { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY_VISIT</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dayLimitTimes")]
                [Validation(Required=false)]
                public long? DayLimitTimes { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>每日访问</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
