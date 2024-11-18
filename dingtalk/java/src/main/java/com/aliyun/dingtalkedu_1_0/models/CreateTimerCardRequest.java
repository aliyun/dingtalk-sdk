// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTimerCardRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("actionTime")
    public Long actionTime;

    @NameInMap("bizData")
    public String bizData;

    /**
     * <strong>example:</strong>
     * <p>CARD_EVENT</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <strong>example:</strong>
     * <p>ding13424</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>20241213123213</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <strong>example:</strong>
     * <p>XIWO</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    @NameInMap("memo")
    public String memo;

    public static CreateTimerCardRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTimerCardRequest self = new CreateTimerCardRequest();
        return TeaModel.build(map, self);
    }

    public CreateTimerCardRequest setActionTime(Long actionTime) {
        this.actionTime = actionTime;
        return this;
    }
    public Long getActionTime() {
        return this.actionTime;
    }

    public CreateTimerCardRequest setBizData(String bizData) {
        this.bizData = bizData;
        return this;
    }
    public String getBizData() {
        return this.bizData;
    }

    public CreateTimerCardRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public CreateTimerCardRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateTimerCardRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public CreateTimerCardRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public CreateTimerCardRequest setMemo(String memo) {
        this.memo = memo;
        return this;
    }
    public String getMemo() {
        return this.memo;
    }

}
