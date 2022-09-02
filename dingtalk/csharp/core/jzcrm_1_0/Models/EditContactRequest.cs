// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditContactRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditContactRequestData Data { get; set; }
        public class EditContactRequestData : TeaModel {
            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 住址
            /// </summary>
            [NameInMap("lxr_address")]
            [Validation(Required=false)]
            public string LxrAddress { get; set; }

            /// <summary>
            /// 生日
            /// </summary>
            [NameInMap("lxr_birthday")]
            [Validation(Required=false)]
            public string LxrBirthday { get; set; }

            /// <summary>
            /// 称谓
            /// </summary>
            [NameInMap("lxr_chengwei")]
            [Validation(Required=false)]
            public string LxrChengwei { get; set; }

            /// <summary>
            /// 证件号码
            /// </summary>
            [NameInMap("lxr_ctnumber")]
            [Validation(Required=false)]
            public string LxrCtnumber { get; set; }

            /// <summary>
            /// 证件类型
            /// </summary>
            [NameInMap("lxr_cttype")]
            [Validation(Required=false)]
            public string LxrCttype { get; set; }

            /// <summary>
            /// 对应客户
            /// </summary>
            [NameInMap("lxr_customerid")]
            [Validation(Required=false)]
            public string LxrCustomerid { get; set; }

            /// <summary>
            /// 部门
            /// </summary>
            [NameInMap("lxr_department")]
            [Validation(Required=false)]
            public string LxrDepartment { get; set; }

            /// <summary>
            /// 钉钉号
            /// </summary>
            [NameInMap("lxr_dingtalk")]
            [Validation(Required=false)]
            public string LxrDingtalk { get; set; }

            /// <summary>
            /// Email
            /// </summary>
            [NameInMap("lxr_email")]
            [Validation(Required=false)]
            public string LxrEmail { get; set; }

            /// <summary>
            /// 传真
            /// </summary>
            [NameInMap("lxr_fax")]
            [Validation(Required=false)]
            public string LxrFax { get; set; }

            /// <summary>
            /// 分类
            /// </summary>
            [NameInMap("lxr_group")]
            [Validation(Required=false)]
            public string LxrGroup { get; set; }

            /// <summary>
            /// 手机
            /// </summary>
            [NameInMap("lxr_handset")]
            [Validation(Required=false)]
            public string LxrHandset { get; set; }

            /// <summary>
            /// 职务
            /// </summary>
            [NameInMap("lxr_headship")]
            [Validation(Required=false)]
            public string LxrHeadship { get; set; }

            /// <summary>
            /// 爱好
            /// </summary>
            [NameInMap("lxr_like")]
            [Validation(Required=false)]
            public string LxrLike { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            [NameInMap("lxr_name")]
            [Validation(Required=false)]
            public string LxrName { get; set; }

            /// <summary>
            /// 联系名片
            /// </summary>
            [NameInMap("lxr_photo")]
            [Validation(Required=false)]
            public string LxrPhoto { get; set; }

            /// <summary>
            /// 负责业务
            /// </summary>
            [NameInMap("lxr_preside")]
            [Validation(Required=false)]
            public string LxrPreside { get; set; }

            /// <summary>
            /// 邮编
            /// </summary>
            [NameInMap("lxr_pst")]
            [Validation(Required=false)]
            public string LxrPst { get; set; }

            /// <summary>
            /// QQ
            /// </summary>
            [NameInMap("lxr_qq")]
            [Validation(Required=false)]
            public string LxrQq { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("lxr_remark")]
            [Validation(Required=false)]
            public string LxrRemark { get; set; }

            /// <summary>
            /// 性别（男，女）
            /// </summary>
            [NameInMap("lxr_sex")]
            [Validation(Required=false)]
            public string LxrSex { get; set; }

            /// <summary>
            /// Skype
            /// </summary>
            [NameInMap("lxr_skype")]
            [Validation(Required=false)]
            public string LxrSkype { get; set; }

            /// <summary>
            /// 家庭电话
            /// </summary>
            [NameInMap("lxr_tel")]
            [Validation(Required=false)]
            public string LxrTel { get; set; }

            /// <summary>
            /// 类型（联系人，主联系人）
            /// </summary>
            [NameInMap("lxr_type")]
            [Validation(Required=false)]
            public string LxrType { get; set; }

            /// <summary>
            /// 旺旺
            /// </summary>
            [NameInMap("lxr_wangwang")]
            [Validation(Required=false)]
            public string LxrWangwang { get; set; }

            /// <summary>
            /// 微信号
            /// </summary>
            [NameInMap("lxr_weixin")]
            [Validation(Required=false)]
            public string LxrWeixin { get; set; }

            /// <summary>
            /// 工作电话
            /// </summary>
            [NameInMap("lxr_worktel")]
            [Validation(Required=false)]
            public string LxrWorktel { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写197
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        /// <summary>
        /// 数据id，不填或者填0为新增数据
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
