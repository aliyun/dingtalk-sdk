// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateBranchVisibleSettingInCooperateRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateBranchVisibleSettingInCooperateRequestBody> Body { get; set; }
        public class UpdateBranchVisibleSettingInCooperateRequestBody : TeaModel {
            /// <summary>
            /// 分支的企业ID
            /// </summary>
            [NameInMap("branchCorpId")]
            [Validation(Required=false)]
            public string BranchCorpId { get; set; }

            /// <summary>
            /// 设置可见性类型 0 ：在主干通讯录隐藏分支(其它分支包含主组织都看不到,额外设置可以看到) 1 ： 仅可见分支所在部门(只能看到自己企业加入的成员，额外设置可以看到其它成员)
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

            /// <summary>
            /// 是否开启 true：开启，false：关闭
            /// </summary>
            [NameInMap("open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            /// <summary>
            /// 设置例外的加入合作空间/关联组织的分支企业CorpId列表
            /// </summary>
            [NameInMap("visibleBranchCorpIds")]
            [Validation(Required=false)]
            public List<string> VisibleBranchCorpIds { get; set; }

            /// <summary>
            /// 设置例外的部门ID列表
            /// </summary>
            [NameInMap("visibleDeptIds")]
            [Validation(Required=false)]
            public List<long?> VisibleDeptIds { get; set; }

        }

    }

}
