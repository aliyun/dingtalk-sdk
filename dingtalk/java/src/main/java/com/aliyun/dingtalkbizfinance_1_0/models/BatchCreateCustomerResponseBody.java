// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateCustomerResponseBody extends TeaModel {
    @NameInMap("errorResult")
    public java.util.List<BatchCreateCustomerResponseBodyErrorResult> errorResult;

    @NameInMap("success")
    public Boolean success;

    public static BatchCreateCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateCustomerResponseBody self = new BatchCreateCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchCreateCustomerResponseBody setErrorResult(java.util.List<BatchCreateCustomerResponseBodyErrorResult> errorResult) {
        this.errorResult = errorResult;
        return this;
    }
    public java.util.List<BatchCreateCustomerResponseBodyErrorResult> getErrorResult() {
        return this.errorResult;
    }

    public BatchCreateCustomerResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchCreateCustomerResponseBodyErrorResult extends TeaModel {
        @NameInMap("errorKey")
        public String errorKey;

        @NameInMap("errorMsg")
        public String errorMsg;

        public static BatchCreateCustomerResponseBodyErrorResult build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateCustomerResponseBodyErrorResult self = new BatchCreateCustomerResponseBodyErrorResult();
            return TeaModel.build(map, self);
        }

        public BatchCreateCustomerResponseBodyErrorResult setErrorKey(String errorKey) {
            this.errorKey = errorKey;
            return this;
        }
        public String getErrorKey() {
            return this.errorKey;
        }

        public BatchCreateCustomerResponseBodyErrorResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

    }

}
