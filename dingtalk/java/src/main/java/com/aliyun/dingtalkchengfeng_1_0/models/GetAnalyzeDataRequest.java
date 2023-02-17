// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAnalyzeDataRequest extends TeaModel {
    /**
     * <p>周期ID列表</p>
     */
    @NameInMap("periodIds")
    public java.util.List<String> periodIds;

    /**
     * <p>部门编号(钉钉部门号)</p>
     */
    @NameInMap("deptId")
    public String deptId;

    public static GetAnalyzeDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAnalyzeDataRequest self = new GetAnalyzeDataRequest();
        return TeaModel.build(map, self);
    }

    public GetAnalyzeDataRequest setPeriodIds(java.util.List<String> periodIds) {
        this.periodIds = periodIds;
        return this;
    }
    public java.util.List<String> getPeriodIds() {
        return this.periodIds;
    }

    public GetAnalyzeDataRequest setDeptId(String deptId) {
        this.deptId = deptId;
        return this;
    }
    public String getDeptId() {
        return this.deptId;
    }

}
