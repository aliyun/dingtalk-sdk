// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class PreCreateGroupBillOrderRequest extends TeaModel {
    @NameInMap("billItemList")
    public java.util.List<PreCreateGroupBillOrderRequestBillItemList> billItemList;

    @NameInMap("extParams")
    public java.util.Map<String, String> extParams;

    @NameInMap("headCount")
    public Long headCount;

    @NameInMap("isAverageAmount")
    public Integer isAverageAmount;

    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("openCid")
    public String openCid;

    @NameInMap("outBizNo")
    public String outBizNo;

    @NameInMap("payeeCorpId")
    public String payeeCorpId;

    @NameInMap("payeeUnionId")
    public String payeeUnionId;

    @NameInMap("remark")
    public String remark;

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
        @NameInMap("amount")
        public String amount;

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
