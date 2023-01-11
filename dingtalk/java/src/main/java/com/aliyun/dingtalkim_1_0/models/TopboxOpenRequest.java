// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class TopboxOpenRequest extends TeaModel {
    /**
     * <p>发送的会话类型：单聊-0, 群聊-1</p>
     */
    @NameInMap("conversationType")
    public Integer conversationType;

    /**
     * <p>酷应用编码</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>吊顶的过期时间（绝对时间）</p>
     */
    @NameInMap("expiredTime")
    public Long expiredTime;

    /**
     * <p>接收卡片的群的openConversationId</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <p>期望吊顶的端（多个"|"隔开，如："ios|win|"）</p>
     */
    @NameInMap("platforms")
    public String platforms;

    /**
     * <p>接收人的员工号列表</p>
     */
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    /**
     * <p>机器人编码</p>
     */
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
