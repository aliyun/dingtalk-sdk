// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeOrderResponseBody extends TeaModel {
    // 批量交易订单VO
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
        // 批次号
        @NameInMap("outBatchNo")
        public String outBatchNo;

        // 支付宝批次订单号
        @NameInMap("alipayTransId")
        public String alipayTransId;

        // 状态
        @NameInMap("status")
        public String status;

        // 成功笔数
        @NameInMap("successCount")
        public Long successCount;

        // 成功金额（元）
        @NameInMap("successAmount")
        public String successAmount;

        // 失败笔数
        @NameInMap("failCount")
        public Long failCount;

        // 明细处理失败的支付汇总金额
        @NameInMap("failAmount")
        public String failAmount;

        // 批次的总金额（元）
        @NameInMap("totalAmount")
        public String totalAmount;

        // 批次完成交易时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 批次受理交易时间
        @NameInMap("gmtSubmit")
        public String gmtSubmit;

        // 失败原因
        @NameInMap("failReason")
        public String failReason;

        // 付款方需要支付的金额（元）
        @NameInMap("paymentAmount")
        public String paymentAmount;

        // 支付币种
        @NameInMap("paymentCurrency")
        public String paymentCurrency;

        // 付款人staffId
        @NameInMap("payerStaffId")
        public String payerStaffId;

        public static QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs build(java.util.Map<String, ?> map) throws Exception {
            QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs self = new QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs();
            return TeaModel.build(map, self);
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setOutBatchNo(String outBatchNo) {
            this.outBatchNo = outBatchNo;
            return this;
        }
        public String getOutBatchNo() {
            return this.outBatchNo;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setAlipayTransId(String alipayTransId) {
            this.alipayTransId = alipayTransId;
            return this;
        }
        public String getAlipayTransId() {
            return this.alipayTransId;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setSuccessCount(Long successCount) {
            this.successCount = successCount;
            return this;
        }
        public Long getSuccessCount() {
            return this.successCount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setSuccessAmount(String successAmount) {
            this.successAmount = successAmount;
            return this;
        }
        public String getSuccessAmount() {
            return this.successAmount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setFailCount(Long failCount) {
            this.failCount = failCount;
            return this;
        }
        public Long getFailCount() {
            return this.failCount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setFailAmount(String failAmount) {
            this.failAmount = failAmount;
            return this;
        }
        public String getFailAmount() {
            return this.failAmount;
        }

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setTotalAmount(String totalAmount) {
            this.totalAmount = totalAmount;
            return this;
        }
        public String getTotalAmount() {
            return this.totalAmount;
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

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setFailReason(String failReason) {
            this.failReason = failReason;
            return this;
        }
        public String getFailReason() {
            return this.failReason;
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

        public QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs setPayerStaffId(String payerStaffId) {
            this.payerStaffId = payerStaffId;
            return this;
        }
        public String getPayerStaffId() {
            return this.payerStaffId;
        }

    }

}
