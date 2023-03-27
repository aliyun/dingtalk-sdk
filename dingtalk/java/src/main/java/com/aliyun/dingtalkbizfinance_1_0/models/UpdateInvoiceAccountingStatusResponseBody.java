// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateInvoiceAccountingStatusResponseBodyResult result;

    public static UpdateInvoiceAccountingStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingStatusResponseBody self = new UpdateInvoiceAccountingStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingStatusResponseBody setResult(UpdateInvoiceAccountingStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateInvoiceAccountingStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices extends TeaModel {
        /**
         * <p>错误码</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <p>错误信息</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <p>发票代码</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <p>发票号码</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices self = new UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

    public static class UpdateInvoiceAccountingStatusResponseBodyResult extends TeaModel {
        /**
         * <p>失败发票数</p>
         */
        @NameInMap("failCount")
        public Long failCount;

        /**
         * <p>失败发票列表</p>
         */
        @NameInMap("failInvoices")
        public java.util.List<UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices> failInvoices;

        /**
         * <p>是否成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static UpdateInvoiceAccountingStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingStatusResponseBodyResult self = new UpdateInvoiceAccountingStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingStatusResponseBodyResult setFailCount(Long failCount) {
            this.failCount = failCount;
            return this;
        }
        public Long getFailCount() {
            return this.failCount;
        }

        public UpdateInvoiceAccountingStatusResponseBodyResult setFailInvoices(java.util.List<UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices> failInvoices) {
            this.failInvoices = failInvoices;
            return this;
        }
        public java.util.List<UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices> getFailInvoices() {
            return this.failInvoices;
        }

        public UpdateInvoiceAccountingStatusResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
