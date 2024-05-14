// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateBatchTradeOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("accountNo")
    public String accountNo;

    @NameInMap("batchRemark")
    public String batchRemark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("batchTradeDetails")
    public java.util.List<CreateBatchTradeOrderRequestBatchTradeDetails> batchTradeDetails;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outBatchNo")
    public String outBatchNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("staffId")
    public String staffId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalAmount")
    public String totalAmount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tradeTitle")
    public String tradeTitle;

    public static CreateBatchTradeOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBatchTradeOrderRequest self = new CreateBatchTradeOrderRequest();
        return TeaModel.build(map, self);
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

    public CreateBatchTradeOrderRequest setBatchRemark(String batchRemark) {
        this.batchRemark = batchRemark;
        return this;
    }
    public String getBatchRemark() {
        return this.batchRemark;
    }

    public CreateBatchTradeOrderRequest setBatchTradeDetails(java.util.List<CreateBatchTradeOrderRequestBatchTradeDetails> batchTradeDetails) {
        this.batchTradeDetails = batchTradeDetails;
        return this;
    }
    public java.util.List<CreateBatchTradeOrderRequestBatchTradeDetails> getBatchTradeDetails() {
        return this.batchTradeDetails;
    }

    public CreateBatchTradeOrderRequest setOutBatchNo(String outBatchNo) {
        this.outBatchNo = outBatchNo;
        return this;
    }
    public String getOutBatchNo() {
        return this.outBatchNo;
    }

    public CreateBatchTradeOrderRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public CreateBatchTradeOrderRequest setTotalAmount(String totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public String getTotalAmount() {
        return this.totalAmount;
    }

    public CreateBatchTradeOrderRequest setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public CreateBatchTradeOrderRequest setTradeTitle(String tradeTitle) {
        this.tradeTitle = tradeTitle;
        return this;
    }
    public String getTradeTitle() {
        return this.tradeTitle;
    }

    public static class CreateBatchTradeOrderRequestBatchTradeDetails extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("amount")
        public String amount;

        @NameInMap("memo")
        public String memo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payeeAccountName")
        public String payeeAccountName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payeeAccountNo")
        public String payeeAccountNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payeeAccountType")
        public String payeeAccountType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("serialNo")
        public Long serialNo;

        public static CreateBatchTradeOrderRequestBatchTradeDetails build(java.util.Map<String, ?> map) throws Exception {
            CreateBatchTradeOrderRequestBatchTradeDetails self = new CreateBatchTradeOrderRequestBatchTradeDetails();
            return TeaModel.build(map, self);
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreateBatchTradeOrderRequestBatchTradeDetails setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
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

        public CreateBatchTradeOrderRequestBatchTradeDetails setSerialNo(Long serialNo) {
            this.serialNo = serialNo;
            return this;
        }
        public Long getSerialNo() {
            return this.serialNo;
        }

    }

}
