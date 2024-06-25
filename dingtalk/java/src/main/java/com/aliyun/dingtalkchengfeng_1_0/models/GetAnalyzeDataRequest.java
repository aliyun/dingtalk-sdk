// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAnalyzeDataRequest extends TeaModel {
    @NameInMap("periodIds")
    public java.util.List<String> periodIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>32222</p>
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
