// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class UserTaskReportRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biz1231231231abcd</para>
        /// </summary>
        [NameInMap("bizNo")]
        [Validation(Required=false)]
        public string BizNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-12 12:00:00</para>
        /// </summary>
        [NameInMap("operateDate")]
        [Validation(Required=false)]
        public string OperateDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-create</para>
        /// </summary>
        [NameInMap("taskTag")]
        [Validation(Required=false)]
        public string TaskTag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2312</para>
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
