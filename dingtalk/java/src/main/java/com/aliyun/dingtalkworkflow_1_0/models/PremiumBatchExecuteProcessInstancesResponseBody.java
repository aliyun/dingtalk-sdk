// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumBatchExecuteProcessInstancesResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ResultValue> result;

    @NameInMap("success")
    public Boolean success;

    public static PremiumBatchExecuteProcessInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumBatchExecuteProcessInstancesResponseBody self = new PremiumBatchExecuteProcessInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumBatchExecuteProcessInstancesResponseBody setResult(java.util.Map<String, ResultValue> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ResultValue> getResult() {
        return this.result;
    }

    public PremiumBatchExecuteProcessInstancesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
