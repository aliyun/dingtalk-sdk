// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerResponseBody extends TeaModel {
    // 客户CODE
    @NameInMap("customerCode")
    public String customerCode;

    public static CreateCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomerResponseBody self = new CreateCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomerResponseBody setCustomerCode(String customerCode) {
        this.customerCode = customerCode;
        return this;
    }
    public String getCustomerCode() {
        return this.customerCode;
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
