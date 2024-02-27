// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SpecialRuleBatchReceiverRequest extends TeaModel {
    @NameInMap("batchNo")
    public String batchNo;

    @NameInMap("cardOptions")
    public String cardOptions;

    @NameInMap("data")
    public java.util.List<SpecialRuleBatchReceiverRequestData> data;

    @NameInMap("ruleCode")
    public String ruleCode;

    @NameInMap("secretKey")
    public String secretKey;

    @NameInMap("specialStrategy")
    public Boolean specialStrategy;

    @NameInMap("taskBatchNo")
    public String taskBatchNo;

    public static SpecialRuleBatchReceiverRequest build(java.util.Map<String, ?> map) throws Exception {
        SpecialRuleBatchReceiverRequest self = new SpecialRuleBatchReceiverRequest();
        return TeaModel.build(map, self);
    }

    public SpecialRuleBatchReceiverRequest setBatchNo(String batchNo) {
        this.batchNo = batchNo;
        return this;
    }
    public String getBatchNo() {
        return this.batchNo;
    }

    public SpecialRuleBatchReceiverRequest setCardOptions(String cardOptions) {
        this.cardOptions = cardOptions;
        return this;
    }
    public String getCardOptions() {
        return this.cardOptions;
    }

    public SpecialRuleBatchReceiverRequest setData(java.util.List<SpecialRuleBatchReceiverRequestData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SpecialRuleBatchReceiverRequestData> getData() {
        return this.data;
    }

    public SpecialRuleBatchReceiverRequest setRuleCode(String ruleCode) {
        this.ruleCode = ruleCode;
        return this;
    }
    public String getRuleCode() {
        return this.ruleCode;
    }

    public SpecialRuleBatchReceiverRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public SpecialRuleBatchReceiverRequest setSpecialStrategy(Boolean specialStrategy) {
        this.specialStrategy = specialStrategy;
        return this;
    }
    public Boolean getSpecialStrategy() {
        return this.specialStrategy;
    }

    public SpecialRuleBatchReceiverRequest setTaskBatchNo(String taskBatchNo) {
        this.taskBatchNo = taskBatchNo;
        return this;
    }
    public String getTaskBatchNo() {
        return this.taskBatchNo;
    }

    public static class SpecialRuleBatchReceiverRequestDataAttrs extends TeaModel {
        @NameInMap("listUnitId")
        public java.util.List<Long> listUnitId;

        public static SpecialRuleBatchReceiverRequestDataAttrs build(java.util.Map<String, ?> map) throws Exception {
            SpecialRuleBatchReceiverRequestDataAttrs self = new SpecialRuleBatchReceiverRequestDataAttrs();
            return TeaModel.build(map, self);
        }

        public SpecialRuleBatchReceiverRequestDataAttrs setListUnitId(java.util.List<Long> listUnitId) {
            this.listUnitId = listUnitId;
            return this;
        }
        public java.util.List<Long> getListUnitId() {
            return this.listUnitId;
        }

    }

    public static class SpecialRuleBatchReceiverRequestData extends TeaModel {
        @NameInMap("atAccount")
        public String atAccount;

        @NameInMap("attrs")
        public SpecialRuleBatchReceiverRequestDataAttrs attrs;

        @NameInMap("callbackUrl")
        public String callbackUrl;

        @NameInMap("cardCallbackUrl")
        public String cardCallbackUrl;

        @NameInMap("content")
        public java.util.Map<String, java.util.Map<String, ?>> content;

        @NameInMap("isAtAll")
        public Boolean isAtAll;

        @NameInMap("privateContent")
        public java.util.Map<String, java.util.Map<String, ?>> privateContent;

        @NameInMap("receiverAccount")
        public String receiverAccount;

        @NameInMap("receiverType")
        public Integer receiverType;

        @NameInMap("serialNumber")
        public String serialNumber;

        public static SpecialRuleBatchReceiverRequestData build(java.util.Map<String, ?> map) throws Exception {
            SpecialRuleBatchReceiverRequestData self = new SpecialRuleBatchReceiverRequestData();
            return TeaModel.build(map, self);
        }

        public SpecialRuleBatchReceiverRequestData setAtAccount(String atAccount) {
            this.atAccount = atAccount;
            return this;
        }
        public String getAtAccount() {
            return this.atAccount;
        }

        public SpecialRuleBatchReceiverRequestData setAttrs(SpecialRuleBatchReceiverRequestDataAttrs attrs) {
            this.attrs = attrs;
            return this;
        }
        public SpecialRuleBatchReceiverRequestDataAttrs getAttrs() {
            return this.attrs;
        }

        public SpecialRuleBatchReceiverRequestData setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

        public SpecialRuleBatchReceiverRequestData setCardCallbackUrl(String cardCallbackUrl) {
            this.cardCallbackUrl = cardCallbackUrl;
            return this;
        }
        public String getCardCallbackUrl() {
            return this.cardCallbackUrl;
        }

        public SpecialRuleBatchReceiverRequestData setContent(java.util.Map<String, java.util.Map<String, ?>> content) {
            this.content = content;
            return this;
        }
        public java.util.Map<String, java.util.Map<String, ?>> getContent() {
            return this.content;
        }

        public SpecialRuleBatchReceiverRequestData setIsAtAll(Boolean isAtAll) {
            this.isAtAll = isAtAll;
            return this;
        }
        public Boolean getIsAtAll() {
            return this.isAtAll;
        }

        public SpecialRuleBatchReceiverRequestData setPrivateContent(java.util.Map<String, java.util.Map<String, ?>> privateContent) {
            this.privateContent = privateContent;
            return this;
        }
        public java.util.Map<String, java.util.Map<String, ?>> getPrivateContent() {
            return this.privateContent;
        }

        public SpecialRuleBatchReceiverRequestData setReceiverAccount(String receiverAccount) {
            this.receiverAccount = receiverAccount;
            return this;
        }
        public String getReceiverAccount() {
            return this.receiverAccount;
        }

        public SpecialRuleBatchReceiverRequestData setReceiverType(Integer receiverType) {
            this.receiverType = receiverType;
            return this;
        }
        public Integer getReceiverType() {
            return this.receiverType;
        }

        public SpecialRuleBatchReceiverRequestData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

    }

}
