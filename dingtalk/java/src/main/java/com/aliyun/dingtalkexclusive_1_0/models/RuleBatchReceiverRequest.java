// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class RuleBatchReceiverRequest extends TeaModel {
    @NameInMap("batchNo")
    public String batchNo;

    @NameInMap("cardOptions")
    public String cardOptions;

    @NameInMap("data")
    public java.util.List<RuleBatchReceiverRequestData> data;

    @NameInMap("ruleCode")
    public String ruleCode;

    @NameInMap("secretKey")
    public String secretKey;

    @NameInMap("specialStrategy")
    public Boolean specialStrategy;

    @NameInMap("taskBatchNo")
    public String taskBatchNo;

    public static RuleBatchReceiverRequest build(java.util.Map<String, ?> map) throws Exception {
        RuleBatchReceiverRequest self = new RuleBatchReceiverRequest();
        return TeaModel.build(map, self);
    }

    public RuleBatchReceiverRequest setBatchNo(String batchNo) {
        this.batchNo = batchNo;
        return this;
    }
    public String getBatchNo() {
        return this.batchNo;
    }

    public RuleBatchReceiverRequest setCardOptions(String cardOptions) {
        this.cardOptions = cardOptions;
        return this;
    }
    public String getCardOptions() {
        return this.cardOptions;
    }

    public RuleBatchReceiverRequest setData(java.util.List<RuleBatchReceiverRequestData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<RuleBatchReceiverRequestData> getData() {
        return this.data;
    }

    public RuleBatchReceiverRequest setRuleCode(String ruleCode) {
        this.ruleCode = ruleCode;
        return this;
    }
    public String getRuleCode() {
        return this.ruleCode;
    }

    public RuleBatchReceiverRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public RuleBatchReceiverRequest setSpecialStrategy(Boolean specialStrategy) {
        this.specialStrategy = specialStrategy;
        return this;
    }
    public Boolean getSpecialStrategy() {
        return this.specialStrategy;
    }

    public RuleBatchReceiverRequest setTaskBatchNo(String taskBatchNo) {
        this.taskBatchNo = taskBatchNo;
        return this;
    }
    public String getTaskBatchNo() {
        return this.taskBatchNo;
    }

    public static class RuleBatchReceiverRequestDataAttrs extends TeaModel {
        @NameInMap("listUnitId")
        public java.util.List<Long> listUnitId;

        public static RuleBatchReceiverRequestDataAttrs build(java.util.Map<String, ?> map) throws Exception {
            RuleBatchReceiverRequestDataAttrs self = new RuleBatchReceiverRequestDataAttrs();
            return TeaModel.build(map, self);
        }

        public RuleBatchReceiverRequestDataAttrs setListUnitId(java.util.List<Long> listUnitId) {
            this.listUnitId = listUnitId;
            return this;
        }
        public java.util.List<Long> getListUnitId() {
            return this.listUnitId;
        }

    }

    public static class RuleBatchReceiverRequestData extends TeaModel {
        @NameInMap("atAccount")
        public String atAccount;

        @NameInMap("attrs")
        public RuleBatchReceiverRequestDataAttrs attrs;

        @NameInMap("callbackUrl")
        public String callbackUrl;

        @NameInMap("cardCallbackUrl")
        public String cardCallbackUrl;

        @NameInMap("content")
        public java.util.Map<String, java.util.Map<String, ?>> content;

        @NameInMap("isAtAll")
        public Boolean isAtAll;

        @NameInMap("receiverAccount")
        public String receiverAccount;

        @NameInMap("receiverType")
        public Integer receiverType;

        @NameInMap("serialNumber")
        public String serialNumber;

        public static RuleBatchReceiverRequestData build(java.util.Map<String, ?> map) throws Exception {
            RuleBatchReceiverRequestData self = new RuleBatchReceiverRequestData();
            return TeaModel.build(map, self);
        }

        public RuleBatchReceiverRequestData setAtAccount(String atAccount) {
            this.atAccount = atAccount;
            return this;
        }
        public String getAtAccount() {
            return this.atAccount;
        }

        public RuleBatchReceiverRequestData setAttrs(RuleBatchReceiverRequestDataAttrs attrs) {
            this.attrs = attrs;
            return this;
        }
        public RuleBatchReceiverRequestDataAttrs getAttrs() {
            return this.attrs;
        }

        public RuleBatchReceiverRequestData setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

        public RuleBatchReceiverRequestData setCardCallbackUrl(String cardCallbackUrl) {
            this.cardCallbackUrl = cardCallbackUrl;
            return this;
        }
        public String getCardCallbackUrl() {
            return this.cardCallbackUrl;
        }

        public RuleBatchReceiverRequestData setContent(java.util.Map<String, java.util.Map<String, ?>> content) {
            this.content = content;
            return this;
        }
        public java.util.Map<String, java.util.Map<String, ?>> getContent() {
            return this.content;
        }

        public RuleBatchReceiverRequestData setIsAtAll(Boolean isAtAll) {
            this.isAtAll = isAtAll;
            return this;
        }
        public Boolean getIsAtAll() {
            return this.isAtAll;
        }

        public RuleBatchReceiverRequestData setReceiverAccount(String receiverAccount) {
            this.receiverAccount = receiverAccount;
            return this;
        }
        public String getReceiverAccount() {
            return this.receiverAccount;
        }

        public RuleBatchReceiverRequestData setReceiverType(Integer receiverType) {
            this.receiverType = receiverType;
            return this;
        }
        public Integer getReceiverType() {
            return this.receiverType;
        }

        public RuleBatchReceiverRequestData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

    }

}
