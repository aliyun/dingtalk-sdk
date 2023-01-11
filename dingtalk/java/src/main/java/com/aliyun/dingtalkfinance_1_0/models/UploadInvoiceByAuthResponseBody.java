// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByAuthResponseBody extends TeaModel {
    /**
     * <p>结果</p>
     */
    @NameInMap("result")
    public UploadInvoiceByAuthResponseBodyResult result;

    public static UploadInvoiceByAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceByAuthResponseBody self = new UploadInvoiceByAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceByAuthResponseBody setResult(UploadInvoiceByAuthResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UploadInvoiceByAuthResponseBodyResult getResult() {
        return this.result;
    }

    public static class UploadInvoiceByAuthResponseBodyResultResults extends TeaModel {
        /**
         * <p>业务错误码</p>
         */
        @NameInMap("errCode")
        public String errCode;

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

        /**
         * <p>失败原因</p>
         */
        @NameInMap("reason")
        public String reason;

        /**
         * <p>是否成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static UploadInvoiceByAuthResponseBodyResultResults build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceByAuthResponseBodyResultResults self = new UploadInvoiceByAuthResponseBodyResultResults();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceByAuthResponseBodyResultResults setErrCode(String errCode) {
            this.errCode = errCode;
            return this;
        }
        public String getErrCode() {
            return this.errCode;
        }

        public UploadInvoiceByAuthResponseBodyResultResults setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UploadInvoiceByAuthResponseBodyResultResults setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UploadInvoiceByAuthResponseBodyResultResults setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

        public UploadInvoiceByAuthResponseBodyResultResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

    public static class UploadInvoiceByAuthResponseBodyResult extends TeaModel {
        /**
         * <p>上传结果</p>
         */
        @NameInMap("results")
        public java.util.List<UploadInvoiceByAuthResponseBodyResultResults> results;

        public static UploadInvoiceByAuthResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceByAuthResponseBodyResult self = new UploadInvoiceByAuthResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceByAuthResponseBodyResult setResults(java.util.List<UploadInvoiceByAuthResponseBodyResultResults> results) {
            this.results = results;
            return this;
        }
        public java.util.List<UploadInvoiceByAuthResponseBodyResultResults> getResults() {
            return this.results;
        }

    }

}
