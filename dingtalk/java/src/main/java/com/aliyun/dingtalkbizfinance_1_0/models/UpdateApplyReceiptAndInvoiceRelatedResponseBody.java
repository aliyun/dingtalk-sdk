// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplyReceiptAndInvoiceRelatedResponseBody extends TeaModel {
    // 失败发票列表list
    @NameInMap("invoiceKeyVOList")
    public java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList> invoiceKeyVOList;

    public static UpdateApplyReceiptAndInvoiceRelatedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateApplyReceiptAndInvoiceRelatedResponseBody self = new UpdateApplyReceiptAndInvoiceRelatedResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateApplyReceiptAndInvoiceRelatedResponseBody setInvoiceKeyVOList(java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList> invoiceKeyVOList) {
        this.invoiceKeyVOList = invoiceKeyVOList;
        return this;
    }
    public java.util.List<UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList> getInvoiceKeyVOList() {
        return this.invoiceKeyVOList;
    }

    public static class UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList extends TeaModel {
        // 失败发票列表list
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 失败发票列表list
        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList self = new UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateApplyReceiptAndInvoiceRelatedResponseBodyInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
