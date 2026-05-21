// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitCustomerSplitDataResponseBody extends TeaModel {
    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public SubmitCustomerSplitDataResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SubmitCustomerSplitDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitCustomerSplitDataResponseBody self = new SubmitCustomerSplitDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitCustomerSplitDataResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public SubmitCustomerSplitDataResponseBody setResult(SubmitCustomerSplitDataResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SubmitCustomerSplitDataResponseBodyResult getResult() {
        return this.result;
    }

    public SubmitCustomerSplitDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SubmitCustomerSplitDataResponseBodyResult extends TeaModel {
        @NameInMap("requestId")
        public String requestId;

        public static SubmitCustomerSplitDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SubmitCustomerSplitDataResponseBodyResult self = new SubmitCustomerSplitDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SubmitCustomerSplitDataResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
