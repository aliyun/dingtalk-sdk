// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditGoodsRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditGoodsRequestData Data { get; set; }
        public class EditGoodsRequestData : TeaModel {
            /// <summary>
            /// 上架时间
            /// </summary>
            [NameInMap("addedtime")]
            [Validation(Required=false)]
            public string Addedtime { get; set; }

            /// <summary>
            /// 成本价格
            /// </summary>
            [NameInMap("cbprice")]
            [Validation(Required=false)]
            public string Cbprice { get; set; }

            /// <summary>
            /// 基准产品
            /// </summary>
            [NameInMap("cp_parentid")]
            [Validation(Required=false)]
            public string CpParentid { get; set; }

            /// <summary>
            /// 产品产地
            /// </summary>
            [NameInMap("cparea")]
            [Validation(Required=false)]
            public string Cparea { get; set; }

            /// <summary>
            /// 条形码
            /// </summary>
            [NameInMap("cpbarcode")]
            [Validation(Required=false)]
            public string Cpbarcode { get; set; }

            /// <summary>
            /// 产品品牌
            /// </summary>
            [NameInMap("cpbrand")]
            [Validation(Required=false)]
            public string Cpbrand { get; set; }

            /// <summary>
            /// 产品说明
            /// </summary>
            [NameInMap("cpcontent")]
            [Validation(Required=false)]
            public string Cpcontent { get; set; }

            /// <summary>
            /// 产品规格
            /// </summary>
            [NameInMap("cpguige")]
            [Validation(Required=false)]
            public string Cpguige { get; set; }

            /// <summary>
            /// 产品图片
            /// </summary>
            [NameInMap("cpimg")]
            [Validation(Required=false)]
            public string Cpimg { get; set; }

            /// <summary>
            /// 产品名称
            /// </summary>
            [NameInMap("cpname")]
            [Validation(Required=false)]
            public string Cpname { get; set; }

            /// <summary>
            /// 产品编号
            /// </summary>
            [NameInMap("cpno")]
            [Validation(Required=false)]
            public string Cpno { get; set; }

            /// <summary>
            /// 产品备注
            /// </summary>
            [NameInMap("cpremark")]
            [Validation(Required=false)]
            public string Cpremark { get; set; }

            /// <summary>
            /// 产品型号
            /// </summary>
            [NameInMap("cptype")]
            [Validation(Required=false)]
            public string Cptype { get; set; }

            /// <summary>
            /// 产品单位
            /// </summary>
            [NameInMap("cpunit")]
            [Validation(Required=false)]
            public string Cpunit { get; set; }

            /// <summary>
            /// 产品重量
            /// </summary>
            [NameInMap("cpweight")]
            [Validation(Required=false)]
            public string Cpweight { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 默认供应商
            /// </summary>
            [NameInMap("gysid")]
            [Validation(Required=false)]
            public string Gysid { get; set; }

            /// <summary>
            /// 批次号管理（是，否）
            /// </summary>
            [NameInMap("ispicimanage")]
            [Validation(Required=false)]
            public string Ispicimanage { get; set; }

            /// <summary>
            /// 序列号管理（是，否）
            /// </summary>
            [NameInMap("issnmanage")]
            [Validation(Required=false)]
            public string Issnmanage { get; set; }

            /// <summary>
            /// 是否算库存（计算，不计算，计算(按基准规格)）
            /// </summary>
            [NameInMap("isstock")]
            [Validation(Required=false)]
            public string Isstock { get; set; }

            /// <summary>
            /// 产品状态（正常，停售，下架）
            /// </summary>
            [NameInMap("isstop")]
            [Validation(Required=false)]
            public string Isstop { get; set; }

            /// <summary>
            /// 零售价格
            /// </summary>
            [NameInMap("preprice1")]
            [Validation(Required=false)]
            public string Preprice1 { get; set; }

            /// <summary>
            /// 预设价格1
            /// </summary>
            [NameInMap("preprice2")]
            [Validation(Required=false)]
            public string Preprice2 { get; set; }

            /// <summary>
            /// 预设价格2
            /// </summary>
            [NameInMap("preprice3")]
            [Validation(Required=false)]
            public string Preprice3 { get; set; }

            /// <summary>
            /// 预设价格3
            /// </summary>
            [NameInMap("preprice4")]
            [Validation(Required=false)]
            public string Preprice4 { get; set; }

            /// <summary>
            /// 库存下限
            /// </summary>
            [NameInMap("stockdown")]
            [Validation(Required=false)]
            public string Stockdown { get; set; }

            /// <summary>
            /// 库存上限
            /// </summary>
            [NameInMap("stockup")]
            [Validation(Required=false)]
            public string Stockup { get; set; }

            /// <summary>
            /// 产品类别
            /// </summary>
            [NameInMap("typeid")]
            [Validation(Required=false)]
            public string Typeid { get; set; }

            /// <summary>
            /// 单位换算
            /// </summary>
            [NameInMap("unitrate")]
            [Validation(Required=false)]
            public string Unitrate { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写154
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
