// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendAiCardRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>aaa_event</p>
     */
    @NameInMap("actionType")
    public String actionType;

    @NameInMap("bizData")
    public String bizData;

    /**
     * <strong>example:</strong>
     * <p>AI_MANAGER_PRINCIPAL</p>
     */
    @NameInMap("cardChannel")
    public String cardChannel;

    /**
     * <strong>example:</strong>
     * <p>ding23423</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>234234234</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <strong>example:</strong>
     * <p>XIWO</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    public static SendAiCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendAiCardRequest self = new SendAiCardRequest();
        return TeaModel.build(map, self);
    }

    public SendAiCardRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public SendAiCardRequest setBizData(String bizData) {
        this.bizData = bizData;
        return this;
    }
    public String getBizData() {
        return this.bizData;
    }

    public SendAiCardRequest setCardChannel(String cardChannel) {
        this.cardChannel = cardChannel;
        return this;
    }
    public String getCardChannel() {
        return this.cardChannel;
    }

    public SendAiCardRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SendAiCardRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public SendAiCardRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

}
