// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeliverUnifyCardRequest extends TeaModel {
    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardData")
    public String cardData;

    @NameInMap("dynamicDataConfig")
    public String dynamicDataConfig;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("lastMessageI18n")
    public java.util.Map<String, String> lastMessageI18n;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>receiver_id</p>
     */
    @NameInMap("receiverId")
    public String receiverId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user/chat</p>
     */
    @NameInMap("receiverType")
    public String receiverType;

    @NameInMap("userPrivateData")
    public String userPrivateData;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeliverUnifyCardRequest build(java.util.Map<String, ?> map) throws Exception {
        DeliverUnifyCardRequest self = new DeliverUnifyCardRequest();
        return TeaModel.build(map, self);
    }

    public DeliverUnifyCardRequest setAtUnionIds(java.util.List<String> atUnionIds) {
        this.atUnionIds = atUnionIds;
        return this;
    }
    public java.util.List<String> getAtUnionIds() {
        return this.atUnionIds;
    }

    public DeliverUnifyCardRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public DeliverUnifyCardRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public DeliverUnifyCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public DeliverUnifyCardRequest setDynamicDataConfig(String dynamicDataConfig) {
        this.dynamicDataConfig = dynamicDataConfig;
        return this;
    }
    public String getDynamicDataConfig() {
        return this.dynamicDataConfig;
    }

    public DeliverUnifyCardRequest setLastMessageI18n(java.util.Map<String, String> lastMessageI18n) {
        this.lastMessageI18n = lastMessageI18n;
        return this;
    }
    public java.util.Map<String, String> getLastMessageI18n() {
        return this.lastMessageI18n;
    }

    public DeliverUnifyCardRequest setReceiverId(String receiverId) {
        this.receiverId = receiverId;
        return this;
    }
    public String getReceiverId() {
        return this.receiverId;
    }

    public DeliverUnifyCardRequest setReceiverType(String receiverType) {
        this.receiverType = receiverType;
        return this;
    }
    public String getReceiverType() {
        return this.receiverType;
    }

    public DeliverUnifyCardRequest setUserPrivateData(String userPrivateData) {
        this.userPrivateData = userPrivateData;
        return this;
    }
    public String getUserPrivateData() {
        return this.userPrivateData;
    }

    public DeliverUnifyCardRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
