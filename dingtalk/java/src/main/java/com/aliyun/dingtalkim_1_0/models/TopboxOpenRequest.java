// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class TopboxOpenRequest extends TeaModel {
    @NameInMap("conversationType")
    public Integer conversationType;

    @NameInMap("coolAppCode")
    public String coolAppCode;

    @NameInMap("expiredTime")
    public Long expiredTime;

    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("platforms")
    public String platforms;

    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    @NameInMap("robotCode")
    public String robotCode;

    public static TopboxOpenRequest build(java.util.Map<String, ?> map) throws Exception {
        TopboxOpenRequest self = new TopboxOpenRequest();
        return TeaModel.build(map, self);
    }

    public TopboxOpenRequest setConversationType(Integer conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public Integer getConversationType() {
        return this.conversationType;
    }

    public TopboxOpenRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public TopboxOpenRequest setExpiredTime(Long expiredTime) {
        this.expiredTime = expiredTime;
        return this;
    }
    public Long getExpiredTime() {
        return this.expiredTime;
    }

    public TopboxOpenRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public TopboxOpenRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public TopboxOpenRequest setPlatforms(String platforms) {
        this.platforms = platforms;
        return this;
    }
    public String getPlatforms() {
        return this.platforms;
    }

    public TopboxOpenRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public TopboxOpenRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
