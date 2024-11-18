// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteQueryServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public SmartQuoteQueryServiceResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SmartQuoteQueryServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteQueryServiceResponseBody self = new SmartQuoteQueryServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SmartQuoteQueryServiceResponseBody setResult(SmartQuoteQueryServiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SmartQuoteQueryServiceResponseBodyResult getResult() {
        return this.result;
    }

    public SmartQuoteQueryServiceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SmartQuoteQueryServiceResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        public static SmartQuoteQueryServiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SmartQuoteQueryServiceResponseBodyResult self = new SmartQuoteQueryServiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SmartQuoteQueryServiceResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
