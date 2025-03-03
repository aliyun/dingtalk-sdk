// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddEvaluatePerformanceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddEvaluatePerformanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddEvaluatePerformanceResponseBody self = new AddEvaluatePerformanceResponseBody();
        return TeaModel.build(map, self);
    }

    public AddEvaluatePerformanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
