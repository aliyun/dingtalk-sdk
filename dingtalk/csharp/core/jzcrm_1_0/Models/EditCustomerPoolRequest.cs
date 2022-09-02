// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditCustomerPoolRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditCustomerPoolRequestData Data { get; set; }
        public class EditCustomerPoolRequestData : TeaModel {
            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 家庭地址
            /// </summary>
            [NameInMap("kh_address")]
            [Validation(Required=false)]
            public string KhAddress { get; set; }

            /// <summary>
            /// 称谓
            /// </summary>
            [NameInMap("kh_appellation")]
            [Validation(Required=false)]
            public string KhAppellation { get; set; }

            /// <summary>
            /// 爱好
            /// </summary>
            [NameInMap("kh_befontof")]
            [Validation(Required=false)]
            public string KhBefontof { get; set; }

            /// <summary>
            /// 开票资料
            /// </summary>
            [NameInMap("kh_billinfo")]
            [Validation(Required=false)]
            public string KhBillinfo { get; set; }

            /// <summary>
            /// 城市
            /// </summary>
            [NameInMap("kh_city")]
            [Validation(Required=false)]
            public string KhCity { get; set; }

            /// <summary>
            /// 类别（企业客户，个人客户，供应商，个人供应商）
            /// </summary>
            [NameInMap("kh_class")]
            [Validation(Required=false)]
            public string KhClass { get; set; }

            /// <summary>
            /// 单位地址
            /// </summary>
            [NameInMap("kh_coaddress")]
            [Validation(Required=false)]
            public string KhCoaddress { get; set; }

            /// <summary>
            /// 联系人分类
            /// </summary>
            [NameInMap("kh_contype")]
            [Validation(Required=false)]
            public string KhContype { get; set; }

            /// <summary>
            /// 国家地区
            /// </summary>
            [NameInMap("kh_country")]
            [Validation(Required=false)]
            public string KhCountry { get; set; }

            /// <summary>
            /// 信用等级（低，中，高）
            /// </summary>
            [NameInMap("kh_creditgrade")]
            [Validation(Required=false)]
            public string KhCreditgrade { get; set; }

            /// <summary>
            /// 证件号码
            /// </summary>
            [NameInMap("kh_ctnumber")]
            [Validation(Required=false)]
            public string KhCtnumber { get; set; }

            /// <summary>
            /// 证件类型
            /// </summary>
            [NameInMap("kh_cttype")]
            [Validation(Required=false)]
            public string KhCttype { get; set; }

            /// <summary>
            /// 部门
            /// </summary>
            [NameInMap("kh_department")]
            [Validation(Required=false)]
            public string KhDepartment { get; set; }

            /// <summary>
            /// 钉钉号
            /// </summary>
            [NameInMap("kh_dingtalk")]
            [Validation(Required=false)]
            public string KhDingtalk { get; set; }

            /// <summary>
            /// 邮箱
            /// </summary>
            [NameInMap("kh_email")]
            [Validation(Required=false)]
            public string KhEmail { get; set; }

            /// <summary>
            /// 人员规模
            /// </summary>
            [NameInMap("kh_employees")]
            [Validation(Required=false)]
            public string KhEmployees { get; set; }

            /// <summary>
            /// 传真
            /// </summary>
            [NameInMap("kh_fax")]
            [Validation(Required=false)]
            public string KhFax { get; set; }

            /// <summary>
            /// 来源
            /// </summary>
            [NameInMap("kh_from")]
            [Validation(Required=false)]
            public string KhFrom { get; set; }

            /// <summary>
            /// 最后跟踪
            /// </summary>
            [NameInMap("kh_genzongtime")]
            [Validation(Required=false)]
            public string KhGenzongtime { get; set; }

            /// <summary>
            /// 手机
            /// </summary>
            [NameInMap("kh_handset")]
            [Validation(Required=false)]
            public string KhHandset { get; set; }

            /// <summary>
            /// 职务
            /// </summary>
            [NameInMap("kh_headship")]
            [Validation(Required=false)]
            public string KhHeadship { get; set; }

            /// <summary>
            /// 热点分类
            /// </summary>
            [NameInMap("kh_hotfl")]
            [Validation(Required=false)]
            public string KhHotfl { get; set; }

            /// <summary>
            /// 热度（无，低热，中热，高热）
            /// </summary>
            [NameInMap("kh_hotlevel")]
            [Validation(Required=false)]
            public string KhHotlevel { get; set; }

            /// <summary>
            /// 热点说明
            /// </summary>
            [NameInMap("kh_hotmemo")]
            [Validation(Required=false)]
            public string KhHotmemo { get; set; }

            /// <summary>
            /// 热点客户（是，否）
            /// </summary>
            [NameInMap("kh_hottype")]
            [Validation(Required=false)]
            public string KhHottype { get; set; }

            /// <summary>
            /// 行业
            /// </summary>
            [NameInMap("kh_industry")]
            [Validation(Required=false)]
            public string KhIndustry { get; set; }

            /// <summary>
            /// 公司简介
            /// </summary>
            [NameInMap("kh_info")]
            [Validation(Required=false)]
            public string KhInfo { get; set; }

            /// <summary>
            /// 客户级别
            /// </summary>
            [NameInMap("kh_jibie")]
            [Validation(Required=false)]
            public string KhJibie { get; set; }

            /// <summary>
            /// 客户名称
            /// </summary>
            [NameInMap("kh_name")]
            [Validation(Required=false)]
            public string KhName { get; set; }

            /// <summary>
            /// 上级客户
            /// </summary>
            [NameInMap("kh_pkhid")]
            [Validation(Required=false)]
            public string KhPkhid { get; set; }

            /// <summary>
            /// 负责业务
            /// </summary>
            [NameInMap("kh_preside")]
            [Validation(Required=false)]
            public string KhPreside { get; set; }

            /// <summary>
            /// 省份
            /// </summary>
            [NameInMap("kh_province")]
            [Validation(Required=false)]
            public string KhProvince { get; set; }

            /// <summary>
            /// 邮编
            /// </summary>
            [NameInMap("kh_pst")]
            [Validation(Required=false)]
            public string KhPst { get; set; }

            /// <summary>
            /// QQ
            /// </summary>
            [NameInMap("kh_qq")]
            [Validation(Required=false)]
            public string KhQq { get; set; }

            /// <summary>
            /// 关系等级
            /// </summary>
            [NameInMap("kh_ralagrade")]
            [Validation(Required=false)]
            public string KhRalagrade { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("kh_remark")]
            [Validation(Required=false)]
            public string KhRemark { get; set; }

            /// <summary>
            /// 性别（男，女）
            /// </summary>
            [NameInMap("kh_sex")]
            [Validation(Required=false)]
            public string KhSex { get; set; }

            /// <summary>
            /// 助记简称
            /// </summary>
            [NameInMap("kh_shortname")]
            [Validation(Required=false)]
            public string KhShortname { get; set; }

            /// <summary>
            /// Skype
            /// </summary>
            [NameInMap("kh_skype")]
            [Validation(Required=false)]
            public string KhSkype { get; set; }

            /// <summary>
            /// 编号
            /// </summary>
            [NameInMap("kh_sn")]
            [Validation(Required=false)]
            public string KhSn { get; set; }

            /// <summary>
            /// 阶段
            /// </summary>
            [NameInMap("kh_status")]
            [Validation(Required=false)]
            public string KhStatus { get; set; }

            /// <summary>
            /// 家庭电话
            /// </summary>
            [NameInMap("kh_tel")]
            [Validation(Required=false)]
            public string KhTel { get; set; }

            /// <summary>
            /// 种类
            /// </summary>
            [NameInMap("kh_type")]
            [Validation(Required=false)]
            public string KhType { get; set; }

            /// <summary>
            /// 价值评估（低，中，高）
            /// </summary>
            [NameInMap("kh_valrating")]
            [Validation(Required=false)]
            public string KhValrating { get; set; }

            /// <summary>
            /// 旺旺
            /// </summary>
            [NameInMap("kh_wangwang")]
            [Validation(Required=false)]
            public string KhWangwang { get; set; }

            /// <summary>
            /// 网址
            /// </summary>
            [NameInMap("kh_web")]
            [Validation(Required=false)]
            public string KhWeb { get; set; }

            /// <summary>
            /// 微信号
            /// </summary>
            [NameInMap("kh_weixin")]
            [Validation(Required=false)]
            public string KhWeixin { get; set; }

            /// <summary>
            /// 工作电话
            /// </summary>
            [NameInMap("kh_worktel")]
            [Validation(Required=false)]
            public string KhWorktel { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写238
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
