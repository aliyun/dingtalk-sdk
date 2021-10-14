// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <summary>
        /// 第三方会员ID
        /// </summary>
        [NameInMap("foreignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// 第三方会员名称
        /// </summary>
        [NameInMap("foreignName")]
        [Validation(Required=false)]
        public string ForeignName { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("openInstanceId")]
        [Validation(Required=false)]
        public string OpenInstanceId { get; set; }

        /// <summary>
        /// 智能客服产品
        /// </summary>
        [NameInMap("productionType")]
        [Validation(Required=false)]
        public int? ProductionType { get; set; }

        /// <summary>
        /// 工单表单
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<CreateTicketRequestProperties> Properties { get; set; }
        public class CreateTicketRequestProperties : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 会员来源
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// 工单模板ID
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 工单标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
