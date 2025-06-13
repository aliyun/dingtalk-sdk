// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ContractAiReviewResultNotifyResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static ContractAiReviewResultNotifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ContractAiReviewResultNotifyResponseBody self = new ContractAiReviewResultNotifyResponseBody();
        return TeaModel.build(map, self);
    }

    public ContractAiReviewResultNotifyResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public ContractAiReviewResultNotifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
