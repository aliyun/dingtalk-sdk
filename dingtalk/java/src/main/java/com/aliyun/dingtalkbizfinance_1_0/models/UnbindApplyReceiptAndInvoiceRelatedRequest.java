// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UnbindApplyReceiptAndInvoiceRelatedRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("invoiceKeyVOList")
    public java.util.List<UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList> invoiceKeyVOList;

    @NameInMap("operator")
    public String operator;

    public static UnbindApplyReceiptAndInvoiceRelatedRequest build(java.util.Map<String, ?> map) throws Exception {
        UnbindApplyReceiptAndInvoiceRelatedRequest self = new UnbindApplyReceiptAndInvoiceRelatedRequest();
        return TeaModel.build(map, self);
    }

    public UnbindApplyReceiptAndInvoiceRelatedRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public UnbindApplyReceiptAndInvoiceRelatedRequest setInvoiceKeyVOList(java.util.List<UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList> invoiceKeyVOList) {
        this.invoiceKeyVOList = invoiceKeyVOList;
        return this;
    }
    public java.util.List<UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList> getInvoiceKeyVOList() {
        return this.invoiceKeyVOList;
    }

    public UnbindApplyReceiptAndInvoiceRelatedRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public static class UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList extends TeaModel {
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

        public static UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList self = new UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
