// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UnbindApplyReceiptAndInvoiceRelatedRequest extends TeaModel {
    /**
     * <p>审批单id</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <p>发票模型</p>
     */
    @NameInMap("invoiceKeyVOList")
    public java.util.List<UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList> invoiceKeyVOList;

    /**
     * <p>操作员</p>
     */
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
         * <p>发票代码</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <p>发票号码</p>
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
