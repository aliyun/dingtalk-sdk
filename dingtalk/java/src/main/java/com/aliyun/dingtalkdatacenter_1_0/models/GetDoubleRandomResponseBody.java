// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDoubleRandomResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;InspectPlanId&quot;: &quot;44030020191021&quot;,       &quot;InspectTypeName&quot;: &quot;定向&quot;,       &quot;InspectPlanName&quot;: &quot;2019能效标识生产企业计量监督抽查1&quot;,       &quot;InspectItem&quot;: &quot;&quot;,       &quot;InspectResult&quot;: &quot;&quot;,       &quot;InspectDepartment&quot;: &quot;深圳市市场监督管理局龙岗局&quot;,       &quot;InspectDate&quot;: &quot;2019-10-14&quot;,       &quot;InspectTaskId&quot;: &quot;44030020191021&quot;,       &quot;InspectTaskName&quot;: &quot;2019能效标识生产企业计量监督抽查1&quot;     }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetDoubleRandomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDoubleRandomResponseBody self = new GetDoubleRandomResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDoubleRandomResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetDoubleRandomResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
