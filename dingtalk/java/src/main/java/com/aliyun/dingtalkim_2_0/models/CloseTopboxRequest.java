// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CloseTopboxRequest extends TeaModel {
    // 会话类型。
    @NameInMap("conversationType")
    public Integer conversationType;

    // 酷应用编码。
    @NameInMap("coolAppCode")
    public String coolAppCode;

    // 群模板id。
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    // 会话id。
    @NameInMap("openConversationId")
    public String openConversationId;

    // 唯一标识一张卡片的外部ID。
    @NameInMap("outTrackId")
    public String outTrackId;

    // 单聊助手会话，机器人编码。
    @NameInMap("robotCode")
    public String robotCode;

    // 单聊助手会话，用户unionId。
    @NameInMap("unoinId")
    public String unoinId;

    // 单聊助手会话，用户userId。
    @NameInMap("userId")
    public String userId;

    public static CloseTopboxRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseTopboxRequest self = new CloseTopboxRequest();
        return TeaModel.build(map, self);
    }

    public CloseTopboxRequest setConversationType(Integer conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public Integer getConversationType() {
        return this.conversationType;
    }

    public CloseTopboxRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public CloseTopboxRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CloseTopboxRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CloseTopboxRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public CloseTopboxRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public CloseTopboxRequest setUnoinId(String unoinId) {
        this.unoinId = unoinId;
        return this;
    }
    public String getUnoinId() {
        return this.unoinId;
    }

    public CloseTopboxRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
