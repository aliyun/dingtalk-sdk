// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UnbindApplyReceiptAndInvoiceRelatedResponseBody extends TeaModel {
    // 批量更新发票返回结果
    // 
    @NameInMap("batchUpdateInvoiceResponse")
    public UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse batchUpdateInvoiceResponse;

    // 是否成功
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

    public UnbindApplyReceiptAndInvoiceRelatedResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList extends TeaModel {
        // 发票编码
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 发票号码
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
        // 错误结果列表
        // 
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

}
