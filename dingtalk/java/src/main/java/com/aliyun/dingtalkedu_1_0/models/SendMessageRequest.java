// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fromUserId")
    public String fromUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("toUserIdList")
    public java.util.List<String> toUserIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public Long type;

    public static SendMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMessageRequest self = new SendMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendMessageRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SendMessageRequest setFromUserId(String fromUserId) {
        this.fromUserId = fromUserId;
        return this;
    }
    public String getFromUserId() {
        return this.fromUserId;
    }

    public SendMessageRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public SendMessageRequest setToUserIdList(java.util.List<String> toUserIdList) {
        this.toUserIdList = toUserIdList;
        return this;
    }
    public java.util.List<String> getToUserIdList() {
        return this.toUserIdList;
    }

    public SendMessageRequest setType(Long type) {
        this.type = type;
        return this;
    }
    public Long getType() {
        return this.type;
    }

}
