// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByMobileResponseBody extends TeaModel {
    @NameInMap("result")
    public UploadInvoiceByMobileResponseBodyResult result;

    public static UploadInvoiceByMobileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceByMobileResponseBody self = new UploadInvoiceByMobileResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceByMobileResponseBody setResult(UploadInvoiceByMobileResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UploadInvoiceByMobileResponseBodyResult getResult() {
        return this.result;
    }

    public static class UploadInvoiceByMobileResponseBodyResultResults extends TeaModel {
        @NameInMap("errCode")
        public String errCode;

        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        @NameInMap("reason")
        public String reason;

        @NameInMap("success")
        public Boolean success;

        public static UploadInvoiceByMobileResponseBodyResultResults build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceByMobileResponseBodyResultResults self = new UploadInvoiceByMobileResponseBodyResultResults();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceByMobileResponseBodyResultResults setErrCode(String errCode) {
            this.errCode = errCode;
            return this;
        }
        public String getErrCode() {
            return this.errCode;
        }

        public UploadInvoiceByMobileResponseBodyResultResults setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UploadInvoiceByMobileResponseBodyResultResults setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UploadInvoiceByMobileResponseBodyResultResults setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

        public UploadInvoiceByMobileResponseBodyResultResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

    public static class UploadInvoiceByMobileResponseBodyResult extends TeaModel {
        @NameInMap("results")
        public java.util.List<UploadInvoiceByMobileResponseBodyResultResults> results;

        public static UploadInvoiceByMobileResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceByMobileResponseBodyResult self = new UploadInvoiceByMobileResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceByMobileResponseBodyResult setResults(java.util.List<UploadInvoiceByMobileResponseBodyResultResults> results) {
            this.results = results;
            return this;
        }
        public java.util.List<UploadInvoiceByMobileResponseBodyResultResults> getResults() {
            return this.results;
        }

    }

}
