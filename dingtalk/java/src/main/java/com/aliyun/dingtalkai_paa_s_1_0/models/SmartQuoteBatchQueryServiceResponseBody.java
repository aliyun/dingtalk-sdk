// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteBatchQueryServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public SmartQuoteBatchQueryServiceResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SmartQuoteBatchQueryServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteBatchQueryServiceResponseBody self = new SmartQuoteBatchQueryServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SmartQuoteBatchQueryServiceResponseBody setResult(SmartQuoteBatchQueryServiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SmartQuoteBatchQueryServiceResponseBodyResult getResult() {
        return this.result;
    }

    public SmartQuoteBatchQueryServiceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SmartQuoteBatchQueryServiceResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        public static SmartQuoteBatchQueryServiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SmartQuoteBatchQueryServiceResponseBodyResult self = new SmartQuoteBatchQueryServiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SmartQuoteBatchQueryServiceResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
