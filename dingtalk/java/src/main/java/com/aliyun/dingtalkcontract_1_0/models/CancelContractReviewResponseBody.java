// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CancelContractReviewResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static CancelContractReviewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelContractReviewResponseBody self = new CancelContractReviewResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelContractReviewResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public CancelContractReviewResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
