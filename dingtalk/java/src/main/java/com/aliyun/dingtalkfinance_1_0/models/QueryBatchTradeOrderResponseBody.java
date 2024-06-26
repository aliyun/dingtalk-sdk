// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeOrderResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("batchTradeOrderVOs")
    public java.util.List<QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs> batchTradeOrderVOs;

    public static QueryBatchTradeOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeOrderResponseBody self = new QueryBatchTradeOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeOrderResponseBody setBatchTradeOrderVOs(java.util.List<QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs> batchTradeOrderVOs) {
        this.batchTradeOrderVOs = batchTradeOrderVOs;
        return this;
    }
    public java.util.List<QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs> getBatchTradeOrderVOs() {
        return this.batchTradeOrderVOs;
    }

    public static class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021090102102122200002121</p>
         */
        @NameInMap("alipayTransId")
        public String alipayTransId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("failAmount")
        public String failAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("failCount")
        public Long failCount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>收款人不存在</p>
         */
        @NameInMap("failReason")
        public String failReason;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-01 12:00:00</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-01 11:00:00</p>
         */
        @NameInMap("gmtSubmit")
        public String gmtSubmit;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20210901001</p>
         */
        @NameInMap("outBatchNo")
        public String outBatchNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>213654465</p>
         */
        @NameInMap("payerStaffId")
        public String payerStaffId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1.00</p>
         */
        @NameInMap("paymentAmount")
        public String paymentAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>CNY</p>
         */
        @NameInMap("paymentCurrency")
        public String paymentCurrency;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>SUCCESS</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1.00</p>
         */
        @NameInMap("successAmount")
        public String successAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("successCount")
        public Long successCount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1.00</p>
         */
        @NameInMap("totalAmount")
        public String totalAmount;

        public static QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs build(java.util.Map<String, ?> map) throws Exception {
            QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs self = new QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs();
            return TeaModel.build(map, self);
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setAlipayTransId(String alipayTransId) {
            this.alipayTransId = alipayTransId;
            return this;
        }
        public String getAlipayTransId() {
            return this.alipayTransId;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setFailAmount(String failAmount) {
            this.failAmount = failAmount;
            return this;
        }
        public String getFailAmount() {
            return this.failAmount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setFailCount(Long failCount) {
            this.failCount = failCount;
            return this;
        }
        public Long getFailCount() {
            return this.failCount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setFailReason(String failReason) {
            this.failReason = failReason;
            return this;
        }
        public String getFailReason() {
            return this.failReason;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setGmtSubmit(String gmtSubmit) {
            this.gmtSubmit = gmtSubmit;
            return this;
        }
        public String getGmtSubmit() {
            return this.gmtSubmit;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setOutBatchNo(String outBatchNo) {
            this.outBatchNo = outBatchNo;
            return this;
        }
        public String getOutBatchNo() {
            return this.outBatchNo;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setPayerStaffId(String payerStaffId) {
            this.payerStaffId = payerStaffId;
            return this;
        }
        public String getPayerStaffId() {
            return this.payerStaffId;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setPaymentAmount(String paymentAmount) {
            this.paymentAmount = paymentAmount;
            return this;
        }
        public String getPaymentAmount() {
            return this.paymentAmount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setPaymentCurrency(String paymentCurrency) {
            this.paymentCurrency = paymentCurrency;
            return this;
        }
        public String getPaymentCurrency() {
            return this.paymentCurrency;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setSuccessAmount(String successAmount) {
            this.successAmount = successAmount;
            return this;
        }
        public String getSuccessAmount() {
            return this.successAmount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setSuccessCount(Long successCount) {
            this.successCount = successCount;
            return this;
        }
        public Long getSuccessCount() {
            return this.successCount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setTotalAmount(String totalAmount) {
            this.totalAmount = totalAmount;
            return this;
        }
        public String getTotalAmount() {
            return this.totalAmount;
        }

    }

}
