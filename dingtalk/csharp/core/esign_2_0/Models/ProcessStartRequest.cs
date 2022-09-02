// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class ProcessStartRequest : TeaModel {
        /// <summary>
        /// 是否自动发起
        /// </summary>
        [NameInMap("autoStart")]
        [Validation(Required=false)]
        public string AutoStart { get; set; }

        /// <summary>
        /// 抄送人列表
        /// </summary>
        [NameInMap("ccs")]
        [Validation(Required=false)]
        public List<ProcessStartRequestCcs> Ccs { get; set; }
        public class ProcessStartRequestCcs : TeaModel {
            /// <summary>
            /// OUTER_USER必填
            /// </summary>
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// OUTER_USER必填
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// 用户类型（"DING_USER":钉钉用户，"OUTER_USER":外部用户）
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// 发给企业方必填
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// DING_USER必填
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 文件列表
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<ProcessStartRequestFiles> Files { get; set; }
        public class ProcessStartRequestFiles : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// 发起方userId
        /// </summary>
        [NameInMap("initiatorUserId")]
        [Validation(Required=false)]
        public string InitiatorUserId { get; set; }

        /// <summary>
        /// 参与方列表
        /// </summary>
        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<ProcessStartRequestParticipants> Participants { get; set; }
        public class ProcessStartRequestParticipants : TeaModel {
            /// <summary>
            /// OUTER_USER必填
            /// </summary>
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// OUTER_USER必填
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// 用户类型（"DING_USER":钉钉用户，"OUTER_USER":外部用户）
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// OUTER_USER需要盖企业章必填(如果不传，默认会赋值当前企业名称)
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// 签署印章类型（1：企业章 2：个人章  1,2：个人和企业章）
            /// </summary>
            [NameInMap("signRequirements")]
            [Validation(Required=false)]
            public string SignRequirements { get; set; }

            /// <summary>
            /// DING_USER必填
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 回跳地址
        /// </summary>
        [NameInMap("redirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 来源信息(目前支持传入审批信息和跳转地址)
        /// </summary>
        [NameInMap("sourceInfo")]
        [Validation(Required=false)]
        public ProcessStartRequestSourceInfo SourceInfo { get; set; }
        public class ProcessStartRequestSourceInfo : TeaModel {
            /// <summary>
            /// 移动端跳转地址
            /// </summary>
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            /// <summary>
            /// pc端跳转地址
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            /// <summary>
            /// 展示文案
            /// </summary>
            [NameInMap("showText")]
            [Validation(Required=false)]
            public string ShowText { get; set; }

        }

        /// <summary>
        /// 任务名称（默认文件名）
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
