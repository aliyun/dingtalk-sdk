// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceResponseBody extends TeaModel {
    // 结果
    @NameInMap("result")
    public UploadInvoiceResponseBodyResult result;

    public static UploadInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceResponseBody self = new UploadInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceResponseBody setResult(UploadInvoiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UploadInvoiceResponseBodyResult getResult() {
        return this.result;
    }

    public static class UploadInvoiceResponseBodyResultResults extends TeaModel {
        // 业务错误码
        @NameInMap("errCode")
        public String errCode;

        // 发票代码
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 发票号码
        @NameInMap("invoiceNo")
        public String invoiceNo;

        // 失败原因
        @NameInMap("reason")
        public String reason;

        // 是否成功
        @NameInMap("success")
        public Boolean success;

        public static UploadInvoiceResponseBodyResultResults build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceResponseBodyResultResults self = new UploadInvoiceResponseBodyResultResults();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceResponseBodyResultResults setErrCode(String errCode) {
            this.errCode = errCode;
            return this;
        }
        public String getErrCode() {
            return this.errCode;
        }

        public UploadInvoiceResponseBodyResultResults setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UploadInvoiceResponseBodyResultResults setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UploadInvoiceResponseBodyResultResults setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

        public UploadInvoiceResponseBodyResultResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

    public static class UploadInvoiceResponseBodyResult extends TeaModel {
        // 上传结果
        @NameInMap("results")
        public java.util.List<UploadInvoiceResponseBodyResultResults> results;

        public static UploadInvoiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceResponseBodyResult self = new UploadInvoiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceResponseBodyResult setResults(java.util.List<UploadInvoiceResponseBodyResultResults> results) {
            this.results = results;
            return this;
        }
        public java.util.List<UploadInvoiceResponseBodyResultResults> getResults() {
            return this.results;
        }

    }

}
