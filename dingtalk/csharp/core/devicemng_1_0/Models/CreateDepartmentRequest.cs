// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class CreateDepartmentRequest : TeaModel {
        /// <summary>
        /// 认证信息
        /// </summary>
        [NameInMap("authInfo")]
        [Validation(Required=false)]
        public string AuthInfo { get; set; }

        /// <summary>
        /// 认证方式
        /// </summary>
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// 业务扩展
        /// </summary>
        [NameInMap("bizExt")]
        [Validation(Required=false)]
        public string BizExt { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 部门类型
        /// </summary>
        [NameInMap("departmentType")]
        [Validation(Required=false)]
        public string DepartmentType { get; set; }

        /// <summary>
        /// 部门描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// 业务系统地址
        /// </summary>
        [NameInMap("systemUrl")]
        [Validation(Required=false)]
        public string SystemUrl { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
