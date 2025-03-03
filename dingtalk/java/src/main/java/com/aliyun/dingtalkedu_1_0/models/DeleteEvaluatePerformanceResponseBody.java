// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteEvaluatePerformanceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteEvaluatePerformanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteEvaluatePerformanceResponseBody self = new DeleteEvaluatePerformanceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteEvaluatePerformanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
