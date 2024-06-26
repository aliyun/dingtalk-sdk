// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplyReceiptAndInvoiceRelatedResponseBody extends TeaModel {
    @NameInMap("batchUpdateInvoiceResponse")
    public UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse batchUpdateInvoiceResponse;

    @NameInMap("errorInvoiceKeyVOList")
    public java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> errorInvoiceKeyVOList;

    @NameInMap("success")
    public Boolean success;

    public static UpdateApplyReceiptAndInvoiceRelatedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateApplyReceiptAndInvoiceRelatedResponseBody self = new UpdateApplyReceiptAndInvoiceRelatedResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateApplyReceiptAndInvoiceRelatedResponseBody setBatchUpdateInvoiceResponse(UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse batchUpdateInvoiceResponse) {
        this.batchUpdateInvoiceResponse = batchUpdateInvoiceResponse;
        return this;
    }
    public UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse getBatchUpdateInvoiceResponse() {
        return this.batchUpdateInvoiceResponse;
    }

    public UpdateApplyReceiptAndInvoiceRelatedResponseBody setErrorInvoiceKeyVOList(java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> errorInvoiceKeyVOList) {
        this.errorInvoiceKeyVOList = errorInvoiceKeyVOList;
        return this;
    }
    public java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList> getErrorInvoiceKeyVOList() {
        return this.errorInvoiceKeyVOList;
    }

    public UpdateApplyReceiptAndInvoiceRelatedResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList extends TeaModel {
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

        public static UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList self = new UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

    public static class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse extends TeaModel {
        @NameInMap("invoiceKeyVOList")
        public java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> invoiceKeyVOList;

        public static UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
            UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse self = new UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse();
            return TeaModel.build(map, self);
        }

        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse setInvoiceKeyVOList(java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> invoiceKeyVOList) {
            this.invoiceKeyVOList = invoiceKeyVOList;
            return this;
        }
        public java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList> getInvoiceKeyVOList() {
            return this.invoiceKeyVOList;
        }

    }

    public static class UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList extends TeaModel {
        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList self = new UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
