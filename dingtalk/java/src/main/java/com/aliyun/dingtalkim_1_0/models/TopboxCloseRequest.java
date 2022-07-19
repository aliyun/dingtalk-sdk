// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class TopboxCloseRequest extends TeaModel {
    // 发送的会话类型：单聊-0, 群聊-1
    @NameInMap("conversationType")
    public Integer conversationType;

    // 酷应用编码
    @NameInMap("coolAppCode")
    public String coolAppCode;

    // 接收卡片的群的openConversationId
    @NameInMap("openConversationId")
    public String openConversationId;

    // 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
    @NameInMap("outTrackId")
    public String outTrackId;

    // 接收人的员工号列表
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    // 机器人编码
    @NameInMap("robotCode")
    public String robotCode;

    public static TopboxCloseRequest build(java.util.Map<String, ?> map) throws Exception {
        TopboxCloseRequest self = new TopboxCloseRequest();
        return TeaModel.build(map, self);
    }

    public TopboxCloseRequest setConversationType(Integer conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public Integer getConversationType() {
        return this.conversationType;
    }

    public TopboxCloseRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public TopboxCloseRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public TopboxCloseRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public TopboxCloseRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public TopboxCloseRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
