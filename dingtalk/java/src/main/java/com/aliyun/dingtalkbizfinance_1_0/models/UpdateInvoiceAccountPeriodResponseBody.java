// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountPeriodResponseBody extends TeaModel {
    // 错误信息
    @NameInMap("errorResult")
    public java.util.List<UpdateInvoiceAccountPeriodResponseBodyErrorResult> errorResult;

    // 成功信息
    @NameInMap("successResult")
    public java.util.List<UpdateInvoiceAccountPeriodResponseBodySuccessResult> successResult;

    public static UpdateInvoiceAccountPeriodResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountPeriodResponseBody self = new UpdateInvoiceAccountPeriodResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountPeriodResponseBody setErrorResult(java.util.List<UpdateInvoiceAccountPeriodResponseBodyErrorResult> errorResult) {
        this.errorResult = errorResult;
        return this;
    }
    public java.util.List<UpdateInvoiceAccountPeriodResponseBodyErrorResult> getErrorResult() {
        return this.errorResult;
    }

    public UpdateInvoiceAccountPeriodResponseBody setSuccessResult(java.util.List<UpdateInvoiceAccountPeriodResponseBodySuccessResult> successResult) {
        this.successResult = successResult;
        return this;
    }
    public java.util.List<UpdateInvoiceAccountPeriodResponseBodySuccessResult> getSuccessResult() {
        return this.successResult;
    }

    public static class UpdateInvoiceAccountPeriodResponseBodyErrorResult extends TeaModel {
        // 错误数据的key
        @NameInMap("errorKey")
        public String errorKey;

        // 错误信息
        @NameInMap("errorMsg")
        public String errorMsg;

        public static UpdateInvoiceAccountPeriodResponseBodyErrorResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountPeriodResponseBodyErrorResult self = new UpdateInvoiceAccountPeriodResponseBodyErrorResult();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountPeriodResponseBodyErrorResult setErrorKey(String errorKey) {
            this.errorKey = errorKey;
            return this;
        }
        public String getErrorKey() {
            return this.errorKey;
        }

        public UpdateInvoiceAccountPeriodResponseBodyErrorResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

    }

    public static class UpdateInvoiceAccountPeriodResponseBodySuccessResult extends TeaModel {
        // 发票代码
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 发票号码
        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateInvoiceAccountPeriodResponseBodySuccessResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountPeriodResponseBodySuccessResult self = new UpdateInvoiceAccountPeriodResponseBodySuccessResult();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountPeriodResponseBodySuccessResult setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAccountPeriodResponseBodySuccessResult setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
