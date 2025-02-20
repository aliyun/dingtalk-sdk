// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CancelReviewOrderResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static CancelReviewOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelReviewOrderResponseBody self = new CancelReviewOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelReviewOrderResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public CancelReviewOrderResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
