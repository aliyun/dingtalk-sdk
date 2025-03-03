// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateEvaluatePerformanceCountResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateEvaluatePerformanceCountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateEvaluatePerformanceCountResponseBody self = new UpdateEvaluatePerformanceCountResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateEvaluatePerformanceCountResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
