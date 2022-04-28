// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupBlackboardRequest extends TeaModel {
    // 文本内容
    @NameInMap("content")
    public String content;

    // 群会话的 Id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 是否发DING
    @NameInMap("sendDing")
    public Boolean sendDing;

    // 是否设为置顶
    @NameInMap("sticky")
    public Boolean sticky;

    // 业务唯一键
    @NameInMap("uniqueId")
    public String uniqueId;

    // 操作用户的 userId
    @NameInMap("userId")
    public String userId;

    public static CreateGroupBlackboardRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupBlackboardRequest self = new CreateGroupBlackboardRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupBlackboardRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateGroupBlackboardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CreateGroupBlackboardRequest setSendDing(Boolean sendDing) {
        this.sendDing = sendDing;
        return this;
    }
    public Boolean getSendDing() {
        return this.sendDing;
    }

    public CreateGroupBlackboardRequest setSticky(Boolean sticky) {
        this.sticky = sticky;
        return this;
    }
    public Boolean getSticky() {
        return this.sticky;
    }

    public CreateGroupBlackboardRequest setUniqueId(String uniqueId) {
        this.uniqueId = uniqueId;
        return this;
    }
    public String getUniqueId() {
        return this.uniqueId;
    }

    public CreateGroupBlackboardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
