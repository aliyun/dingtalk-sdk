// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class TopboxCloseRequest extends TeaModel {
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
     * <p>接收人的员工号列表</p>
     */
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    /**
     * <p>机器人编码</p>
     */
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
