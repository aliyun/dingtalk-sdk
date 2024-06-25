// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class PreCreateGroupBillOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("billItemList")
    public java.util.List<PreCreateGroupBillOrderRequestBillItemList> billItemList;

    @NameInMap("extParams")
    public java.util.Map<String, String> extParams;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("headCount")
    public Long headCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("isAverageAmount")
    public Integer isAverageAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dhqhadsnkj2qweqsw2</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <strong>example:</strong>
     * <p>opemcesdjuwqw2uwnedj==</p>
     */
    @NameInMap("openCid")
    public String openCid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20230918291921929193911</p>
     */
    @NameInMap("outBizNo")
    public String outBizNo;

    /**
     * <strong>example:</strong>
     * <p>ding32fff839a3e0105d</p>
     */
    @NameInMap("payeeCorpId")
    public String payeeCorpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ECEjwiiwenwnw2q2sdd</p>
     */
    @NameInMap("payeeUnionId")
    public String payeeUnionId;

    /**
     * <strong>example:</strong>
     * <p>饿了么拼单-测试</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10.24</p>
     */
    @NameInMap("totalAmount")
    public String totalAmount;

    public static PreCreateGroupBillOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        PreCreateGroupBillOrderRequest self = new PreCreateGroupBillOrderRequest();
        return TeaModel.build(map, self);
    }

    public PreCreateGroupBillOrderRequest setBillItemList(java.util.List<PreCreateGroupBillOrderRequestBillItemList> billItemList) {
        this.billItemList = billItemList;
        return this;
    }
    public java.util.List<PreCreateGroupBillOrderRequestBillItemList> getBillItemList() {
        return this.billItemList;
    }

    public PreCreateGroupBillOrderRequest setExtParams(java.util.Map<String, String> extParams) {
        this.extParams = extParams;
        return this;
    }
    public java.util.Map<String, String> getExtParams() {
        return this.extParams;
    }

    public PreCreateGroupBillOrderRequest setHeadCount(Long headCount) {
        this.headCount = headCount;
        return this;
    }
    public Long getHeadCount() {
        return this.headCount;
    }

    public PreCreateGroupBillOrderRequest setIsAverageAmount(Integer isAverageAmount) {
        this.isAverageAmount = isAverageAmount;
        return this;
    }
    public Integer getIsAverageAmount() {
        return this.isAverageAmount;
    }

    public PreCreateGroupBillOrderRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public PreCreateGroupBillOrderRequest setOpenCid(String openCid) {
        this.openCid = openCid;
        return this;
    }
    public String getOpenCid() {
        return this.openCid;
    }

    public PreCreateGroupBillOrderRequest setOutBizNo(String outBizNo) {
        this.outBizNo = outBizNo;
        return this;
    }
    public String getOutBizNo() {
        return this.outBizNo;
    }

    public PreCreateGroupBillOrderRequest setPayeeCorpId(String payeeCorpId) {
        this.payeeCorpId = payeeCorpId;
        return this;
    }
    public String getPayeeCorpId() {
        return this.payeeCorpId;
    }

    public PreCreateGroupBillOrderRequest setPayeeUnionId(String payeeUnionId) {
        this.payeeUnionId = payeeUnionId;
        return this;
    }
    public String getPayeeUnionId() {
        return this.payeeUnionId;
    }

    public PreCreateGroupBillOrderRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public PreCreateGroupBillOrderRequest setTotalAmount(String totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public String getTotalAmount() {
        return this.totalAmount;
    }

    public static class PreCreateGroupBillOrderRequestBillItemList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>5.12</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>cshadbikahdksnajhada</p>
         */
        @NameInMap("payerUnionId")
        public String payerUnionId;

        public static PreCreateGroupBillOrderRequestBillItemList build(java.util.Map<String, ?> map) throws Exception {
            PreCreateGroupBillOrderRequestBillItemList self = new PreCreateGroupBillOrderRequestBillItemList();
            return TeaModel.build(map, self);
        }

        public PreCreateGroupBillOrderRequestBillItemList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public PreCreateGroupBillOrderRequestBillItemList setPayerUnionId(String payerUnionId) {
            this.payerUnionId = payerUnionId;
            return this;
        }
        public String getPayerUnionId() {
            return this.payerUnionId;
        }

    }

}
