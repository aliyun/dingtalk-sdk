// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryMsgSendRecordsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1766479616000</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("msgTypeList")]
        [Validation(Required=false)]
        public List<string> MsgTypeList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1766479616000</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jYdrJoCmTo0iE</para>
        /// </summary>
        [NameInMap("unionid")]
        [Validation(Required=false)]
        public string Unionid { get; set; }

    }

}
