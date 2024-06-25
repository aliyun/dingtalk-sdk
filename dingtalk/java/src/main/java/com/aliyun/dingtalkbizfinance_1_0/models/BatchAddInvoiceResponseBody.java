// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchAddInvoiceResponseBody extends TeaModel {
    @NameInMap("errorResult")
    public java.util.List<BatchAddInvoiceResponseBodyErrorResult> errorResult;

    @NameInMap("successResult")
    public java.util.List<BatchAddInvoiceResponseBodySuccessResult> successResult;

    public static BatchAddInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchAddInvoiceResponseBody self = new BatchAddInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchAddInvoiceResponseBody setErrorResult(java.util.List<BatchAddInvoiceResponseBodyErrorResult> errorResult) {
        this.errorResult = errorResult;
        return this;
    }
    public java.util.List<BatchAddInvoiceResponseBodyErrorResult> getErrorResult() {
        return this.errorResult;
    }

    public BatchAddInvoiceResponseBody setSuccessResult(java.util.List<BatchAddInvoiceResponseBodySuccessResult> successResult) {
        this.successResult = successResult;
        return this;
    }
    public java.util.List<BatchAddInvoiceResponseBodySuccessResult> getSuccessResult() {
        return this.successResult;
    }

    public static class BatchAddInvoiceResponseBodyErrorResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("errorKey")
        public String errorKey;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        public static BatchAddInvoiceResponseBodyErrorResult build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceResponseBodyErrorResult self = new BatchAddInvoiceResponseBodyErrorResult();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceResponseBodyErrorResult setErrorKey(String errorKey) {
            this.errorKey = errorKey;
            return this;
        }
        public String getErrorKey() {
            return this.errorKey;
        }

        public BatchAddInvoiceResponseBodyErrorResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

    }

    public static class BatchAddInvoiceResponseBodySuccessResult extends TeaModel {
        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static BatchAddInvoiceResponseBodySuccessResult build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceResponseBodySuccessResult self = new BatchAddInvoiceResponseBodySuccessResult();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceResponseBodySuccessResult setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public BatchAddInvoiceResponseBodySuccessResult setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
