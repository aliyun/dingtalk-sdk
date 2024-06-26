// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UnbindApplyReceiptAndInvoiceRelatedResponseBody extends TeaModel {
    @NameInMap("batchUpdateInvoiceResponse")
    public UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse batchUpdateInvoiceResponse;

    @NameInMap("errorInvoiceKeyVOList")
    public java.util.List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> errorInvoiceKeyVOList;

    @NameInMap("success")
    public Boolean success;

    public static UnbindApplyReceiptAndInvoiceRelatedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnbindApplyReceiptAndInvoiceRelatedResponseBody self = new UnbindApplyReceiptAndInvoiceRelatedResponseBody();
        return TeaModel.build(map, self);
    }

    public UnbindApplyReceiptAndInvoiceRelatedResponseBody setBatchUpdateInvoiceResponse(UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse batchUpdateInvoiceResponse) {
        this.batchUpdateInvoiceResponse = batchUpdateInvoiceResponse;
        return this;
    }
    public UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse getBatchUpdateInvoiceResponse() {
        return this.batchUpdateInvoiceResponse;
    }

    public UnbindApplyReceiptAndInvoiceRelatedResponseBody setErrorInvoiceKeyVOList(java.util.List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> errorInvoiceKeyVOList) {
        this.errorInvoiceKeyVOList = errorInvoiceKeyVOList;
        return this;
    }
    public java.util.List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> getErrorInvoiceKeyVOList() {
        return this.errorInvoiceKeyVOList;
    }

    public UnbindApplyReceiptAndInvoiceRelatedResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList self = new UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

    public static class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse extends TeaModel {
        @NameInMap("invoiceKeyVOList")
        public java.util.List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> invoiceKeyVOList;

        public static UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
            UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse self = new UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse();
            return TeaModel.build(map, self);
        }

        public UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse setInvoiceKeyVOList(java.util.List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> invoiceKeyVOList) {
            this.invoiceKeyVOList = invoiceKeyVOList;
            return this;
        }
        public java.util.List<UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> getInvoiceKeyVOList() {
            return this.invoiceKeyVOList;
        }

    }

    public static class UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList extends TeaModel {
        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList self = new UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
