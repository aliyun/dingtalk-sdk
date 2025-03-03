// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ClearEvaluatePerformanceCountResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ClearEvaluatePerformanceCountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ClearEvaluatePerformanceCountResponseBody self = new ClearEvaluatePerformanceCountResponseBody();
        return TeaModel.build(map, self);
    }

    public ClearEvaluatePerformanceCountResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
