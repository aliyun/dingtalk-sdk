// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesDispatchTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opsoft</para>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task</para>
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("defectsAmount")]
        [Validation(Required=false)]
        public string DefectsAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("dispatchStaffName")]
        [Validation(Required=false)]
        public string DispatchStaffName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>170000000332</para>
        /// </summary>
        [NameInMap("dispatchStaffNo")]
        [Validation(Required=false)]
        public string DispatchStaffNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("fineAmount")]
        [Validation(Required=false)]
        public string FineAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("overdue")]
        [Validation(Required=false)]
        public int? Overdue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>321</para>
        /// </summary>
        [NameInMap("planQuantity")]
        [Validation(Required=false)]
        public long? PlanQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>打磨</para>
        /// </summary>
        [NameInMap("processName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fsdfs3fsd2234wds</para>
        /// </summary>
        [NameInMap("processUuid")]
        [Validation(Required=false)]
        public string ProcessUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingfsdfs3fsd2234wds</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>毛坯KM50二级盖</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20<em>20</em>3</para>
        /// </summary>
        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingfsdfs3fsd2234wds</para>
        /// </summary>
        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0220423001</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WORKING</para>
        /// </summary>
        [NameInMap("projectStatus")]
        [Validation(Required=false)]
        public string ProjectStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;userId&quot;:&quot;123&quot;,&quot;name&quot;:&quot;汉俊&quot;,&quot;planQuantity&quot;:30}]</para>
        /// </summary>
        [NameInMap("taskOperators")]
        [Validation(Required=false)]
        public string TaskOperators { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-12 23:59:59</para>
        /// </summary>
        [NameInMap("taskPlanEndTime")]
        [Validation(Required=false)]
        public string TaskPlanEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-12 23:59:59</para>
        /// </summary>
        [NameInMap("taskPlanStartTime")]
        [Validation(Required=false)]
        public string TaskPlanStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WORKING</para>
        /// </summary>
        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dfsdfs3fsd2234wds</para>
        /// </summary>
        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fsdfs3fsd2234wds</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
