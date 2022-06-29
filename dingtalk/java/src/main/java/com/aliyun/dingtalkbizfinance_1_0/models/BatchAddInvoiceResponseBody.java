// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchAddInvoiceResponseBody extends TeaModel {
    // 错误信息
    @NameInMap("result")
    public java.util.List<BatchAddInvoiceResponseBodyResult> result;

    public static BatchAddInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchAddInvoiceResponseBody self = new BatchAddInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchAddInvoiceResponseBody setResult(java.util.List<BatchAddInvoiceResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<BatchAddInvoiceResponseBodyResult> getResult() {
        return this.result;
    }

    public static class BatchAddInvoiceResponseBodyResult extends TeaModel {
        // 错误数据的key
        @NameInMap("errorKey")
        public String errorKey;

        // 错误信息
        @NameInMap("errorMsg")
        public String errorMsg;

        public static BatchAddInvoiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceResponseBodyResult self = new BatchAddInvoiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceResponseBodyResult setErrorKey(String errorKey) {
            this.errorKey = errorKey;
            return this;
        }
        public String getErrorKey() {
            return this.errorKey;
        }

        public BatchAddInvoiceResponseBodyResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

    }

}
