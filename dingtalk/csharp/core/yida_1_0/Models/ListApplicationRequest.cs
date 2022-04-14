// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationRequest : TeaModel {
        /// <summary>
        /// 应用过滤条件, 不填则获取发布到了宜搭应用中心的宜搭应用, 填createdByMe获取我创建的宜搭应用, 填managedByMe获取我管理的宜搭应用
        /// </summary>
        [NameInMap("appFilter")]
        [Validation(Required=false)]
        public string AppFilter { get; set; }

        /// <summary>
        /// 应用名称检索关键词
        /// </summary>
        [NameInMap("appNameSearchKeyword")]
        [Validation(Required=false)]
        public string AppNameSearchKeyword { get; set; }

        /// <summary>
        /// 钉钉组织id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// corpId+userId+CorpToken做md5加密计算生成的字符串(每个企业有自己的唯一corpToken), 获取具体计算详情请联系宜搭 dingtalk://dingtalkclient/action/sendmsg?dingtalk_id=somjffs
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// 钉钉userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
