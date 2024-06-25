// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class FinishReviewOrderResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static FinishReviewOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FinishReviewOrderResponseBody self = new FinishReviewOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public FinishReviewOrderResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
