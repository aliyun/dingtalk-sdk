// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchExecuteProcessInstancesResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ResultValue> result;

    @NameInMap("success")
    public Boolean success;

    public static BatchExecuteProcessInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchExecuteProcessInstancesResponseBody self = new BatchExecuteProcessInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchExecuteProcessInstancesResponseBody setResult(java.util.Map<String, ResultValue> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ResultValue> getResult() {
        return this.result;
    }

    public BatchExecuteProcessInstancesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
