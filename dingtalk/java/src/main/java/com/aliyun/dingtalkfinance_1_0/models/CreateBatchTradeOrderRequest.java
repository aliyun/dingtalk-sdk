// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateBatchTradeOrderRequest extends TeaModel {
    // 员工staffId
    @NameInMap("staffId")
    public String staffId;

    // 付款账号唯一id
    @NameInMap("accountId")
    public String accountId;

    // 付款账号(注意：用户上送的是脱敏数据)
    @NameInMap("accountNo")
    public String accountNo;

    // 交易抬头
    @NameInMap("tradeTitle")
    public String tradeTitle;

    // 外部商户批次号
    @NameInMap("outBatchNo")
    public String outBatchNo;

    // 批次备注
    @NameInMap("batchRemark")
    public String batchRemark;

    // 总笔数（必填）
    @NameInMap("totalCount")
    public Long totalCount;

    // 总金额（必填，单位：元）
    @NameInMap("totalAmount")
    public String totalAmount;

    // 交易明细列表
    @NameInMap("batchTradeDetails")
    public java.util.List<CreateBatchTradeOrderRequestBatchTradeDetails> batchTradeDetails;

    public static CreateBatchTradeOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBatchTradeOrderRequest self = new CreateBatchTradeOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreateBatchTradeOrderRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public CreateBatchTradeOrderRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public CreateBatchTradeOrderRequest setAccountNo(String accountNo) {
        this.accountNo = accountNo;
        return this;
    }
    public String getAccountNo() {
        return this.accountNo;
    }

    public CreateBatchTradeOrderRequest setTradeTitle(String tradeTitle) {
        this.tradeTitle = tradeTitle;
        return this;
    }
    public String getTradeTitle() {
        return this.tradeTitle;
    }

    public CreateBatchTradeOrderRequest setOutBatchNo(String outBatchNo) {
        this.outBatchNo = outBatchNo;
        return this;
    }
    public String getOutBatchNo() {
        return this.outBatchNo;
    }

    public CreateBatchTradeOrderRequest setBatchRemark(String batchRemark) {
        this.batchRemark = batchRemark;
        return this;
    }
    public String getBatchRemark() {
        return this.batchRemark;
    }

    public CreateBatchTradeOrderRequest setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public CreateBatchTradeOrderRequest setTotalAmount(String totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public String getTotalAmount() {
        return this.totalAmount;
    }

    public CreateBatchTradeOrderRequest setBatchTradeDetails(java.util.List<CreateBatchTradeOrderRequestBatchTradeDetails> batchTradeDetails) {
        this.batchTradeDetails = batchTradeDetails;
        return this;
    }
    public java.util.List<CreateBatchTradeOrderRequestBatchTradeDetails> getBatchTradeDetails() {
        return this.batchTradeDetails;
    }

    public static class CreateBatchTradeOrderRequestBatchTradeDetails extends TeaModel {
        // 序号（必填）
        @NameInMap("serialNo")
        public Long serialNo;

        // 金额（必填，单位：元）
        @NameInMap("amount")
        public String amount;

        // 收款方户名（必填）
        @NameInMap("payeeAccountName")
        public String payeeAccountName;

        // 收款方账号（必填）
        @NameInMap("payeeAccountNo")
        public String payeeAccountNo;

        // 收款方账号类型（必填）
        @NameInMap("payeeAccountType")
        public String payeeAccountType;

        // 备注（选填）
        @NameInMap("memo")
        public String memo;

        public static CreateBatchTradeOrderRequestBatchTradeDetails build(java.util.Map<String, ?> map) throws Exception {
            CreateBatchTradeOrderRequestBatchTradeDetails self = new CreateBatchTradeOrderRequestBatchTradeDetails();
            return TeaModel.build(map, self);
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setSerialNo(Long serialNo) {
            this.serialNo = serialNo;
            return this;
        }
        public Long getSerialNo() {
            return this.serialNo;
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setPayeeAccountName(String payeeAccountName) {
            this.payeeAccountName = payeeAccountName;
            return this;
        }
        public String getPayeeAccountName() {
            return this.payeeAccountName;
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setPayeeAccountNo(String payeeAccountNo) {
            this.payeeAccountNo = payeeAccountNo;
            return this;
        }
        public String getPayeeAccountNo() {
            return this.payeeAccountNo;
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setPayeeAccountType(String payeeAccountType) {
            this.payeeAccountType = payeeAccountType;
            return this;
        }
        public String getPayeeAccountType() {
            return this.payeeAccountType;
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
