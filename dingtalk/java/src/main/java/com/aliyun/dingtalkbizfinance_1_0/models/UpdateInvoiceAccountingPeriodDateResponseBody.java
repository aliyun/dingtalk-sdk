// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingPeriodDateResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateInvoiceAccountingPeriodDateResponseBodyResult result;

    public static UpdateInvoiceAccountingPeriodDateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingPeriodDateResponseBody self = new UpdateInvoiceAccountingPeriodDateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingPeriodDateResponseBody setResult(UpdateInvoiceAccountingPeriodDateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateInvoiceAccountingPeriodDateResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices extends TeaModel {
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

        public static UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices self = new UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

    public static class UpdateInvoiceAccountingPeriodDateResponseBodyResult extends TeaModel {
        /**
         * <p>失败发票数</p>
         */
        @NameInMap("failCount")
        public Long failCount;

        /**
         * <p>失败发票列表</p>
         */
        @NameInMap("failInvoices")
        public java.util.List<UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices> failInvoices;

        /**
         * <p>是否成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static UpdateInvoiceAccountingPeriodDateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingPeriodDateResponseBodyResult self = new UpdateInvoiceAccountingPeriodDateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyResult setFailCount(Long failCount) {
            this.failCount = failCount;
            return this;
        }
        public Long getFailCount() {
            return this.failCount;
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyResult setFailInvoices(java.util.List<UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices> failInvoices) {
            this.failInvoices = failInvoices;
            return this;
        }
        public java.util.List<UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices> getFailInvoices() {
            return this.failInvoices;
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
