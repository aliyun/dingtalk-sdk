// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetNotifyMeRequest : TeaModel {
        /// <summary>
        /// 应用标识列表
        /// </summary>
        [NameInMap("appTypes")]
        [Validation(Required=false)]
        public string AppTypes { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 抄送到达时间开始
        /// </summary>
        [NameInMap("createFromTimeGMT")]
        [Validation(Required=false)]
        public long? CreateFromTimeGMT { get; set; }

        /// <summary>
        /// 抄送到达时间结束
        /// </summary>
        [NameInMap("createToTimeGMT")]
        [Validation(Required=false)]
        public long? CreateToTimeGMT { get; set; }

        /// <summary>
        /// 数据提交时间开始
        /// </summary>
        [NameInMap("instanceCreateFromTimeGMT")]
        [Validation(Required=false)]
        public long? InstanceCreateFromTimeGMT { get; set; }

        /// <summary>
        /// 数据提交时间结束
        /// </summary>
        [NameInMap("instanceCreateToTimeGMT")]
        [Validation(Required=false)]
        public long? InstanceCreateToTimeGMT { get; set; }

        /// <summary>
        /// 表单中组件数据模糊搜
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 语言环境
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 流程code列表
        /// </summary>
        [NameInMap("processCodes")]
        [Validation(Required=false)]
        public string ProcessCodes { get; set; }

        /// <summary>
        /// 验权token
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
