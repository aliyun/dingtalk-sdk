// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SendContractCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>signing</p>
     */
    @NameInMap("cardType")
    public String cardType;

    @NameInMap("contractInfo")
    public SendContractCardRequestContractInfo contractInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding5f62ac8a3c24952ebc961a6cb783455b</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <strong>example:</strong>
     * <p>PROC_Xxxxxxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    @NameInMap("receiveGroups")
    public java.util.List<String> receiveGroups;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receivers")
    public java.util.List<SendContractCardRequestReceivers> receivers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sender")
    public SendContractCardRequestSender sender;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("syncSingleChat")
    public Boolean syncSingleChat;

    public static SendContractCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendContractCardRequest self = new SendContractCardRequest();
        return TeaModel.build(map, self);
    }

    public SendContractCardRequest setCardType(String cardType) {
        this.cardType = cardType;
        return this;
    }
    public String getCardType() {
        return this.cardType;
    }

    public SendContractCardRequest setContractInfo(SendContractCardRequestContractInfo contractInfo) {
        this.contractInfo = contractInfo;
        return this;
    }
    public SendContractCardRequestContractInfo getContractInfo() {
        return this.contractInfo;
    }

    public SendContractCardRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SendContractCardRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public SendContractCardRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public SendContractCardRequest setReceiveGroups(java.util.List<String> receiveGroups) {
        this.receiveGroups = receiveGroups;
        return this;
    }
    public java.util.List<String> getReceiveGroups() {
        return this.receiveGroups;
    }

    public SendContractCardRequest setReceivers(java.util.List<SendContractCardRequestReceivers> receivers) {
        this.receivers = receivers;
        return this;
    }
    public java.util.List<SendContractCardRequestReceivers> getReceivers() {
        return this.receivers;
    }

    public SendContractCardRequest setSender(SendContractCardRequestSender sender) {
        this.sender = sender;
        return this;
    }
    public SendContractCardRequestSender getSender() {
        return this.sender;
    }

    public SendContractCardRequest setSyncSingleChat(Boolean syncSingleChat) {
        this.syncSingleChat = syncSingleChat;
        return this;
    }
    public Boolean getSyncSingleChat() {
        return this.syncSingleChat;
    }

    public static class SendContractCardRequestContractInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>HT_xxxxxxx</p>
         */
        @NameInMap("contractCode")
        public String contractCode;

        /**
         * <strong>example:</strong>
         * <p>合同</p>
         */
        @NameInMap("contractName")
        public String contractName;

        /**
         * <strong>example:</strong>
         * <p>1242153453</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("signUserName")
        public String signUserName;

        public static SendContractCardRequestContractInfo build(java.util.Map<String, ?> map) throws Exception {
            SendContractCardRequestContractInfo self = new SendContractCardRequestContractInfo();
            return TeaModel.build(map, self);
        }

        public SendContractCardRequestContractInfo setContractCode(String contractCode) {
            this.contractCode = contractCode;
            return this;
        }
        public String getContractCode() {
            return this.contractCode;
        }

        public SendContractCardRequestContractInfo setContractName(String contractName) {
            this.contractName = contractName;
            return this;
        }
        public String getContractName() {
            return this.contractName;
        }

        public SendContractCardRequestContractInfo setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public SendContractCardRequestContractInfo setSignUserName(String signUserName) {
            this.signUserName = signUserName;
            return this;
        }
        public String getSignUserName() {
            return this.signUserName;
        }

    }

    public static class SendContractCardRequestReceivers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding5f62ac8a3c24952ebc961a6cb783455b</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>1622265907855672</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>可以为空</p>
         */
        @NameInMap("userType")
        public String userType;

        public static SendContractCardRequestReceivers build(java.util.Map<String, ?> map) throws Exception {
            SendContractCardRequestReceivers self = new SendContractCardRequestReceivers();
            return TeaModel.build(map, self);
        }

        public SendContractCardRequestReceivers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public SendContractCardRequestReceivers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SendContractCardRequestReceivers setUserType(String userType) {
            this.userType = userType;
            return this;
        }
        public String getUserType() {
            return this.userType;
        }

    }

    public static class SendContractCardRequestSender extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding5f62ac8a3c24952ebc961a6cb783455b</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>1622265907855672</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>可以为空</p>
         */
        @NameInMap("userType")
        public String userType;

        public static SendContractCardRequestSender build(java.util.Map<String, ?> map) throws Exception {
            SendContractCardRequestSender self = new SendContractCardRequestSender();
            return TeaModel.build(map, self);
        }

        public SendContractCardRequestSender setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public SendContractCardRequestSender setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SendContractCardRequestSender setUserType(String userType) {
            this.userType = userType;
            return this;
        }
        public String getUserType() {
            return this.userType;
        }

    }

}
