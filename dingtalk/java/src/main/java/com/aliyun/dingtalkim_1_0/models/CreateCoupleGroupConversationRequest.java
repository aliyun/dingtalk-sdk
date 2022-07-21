// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupConversationRequest extends TeaModel {
    // 钉外人员业务Id
    @NameInMap("appUserId")
    public String appUserId;

    // 群头像
    @NameInMap("groupAvatar")
    public String groupAvatar;

    // 群名称
    @NameInMap("groupName")
    public String groupName;

    // 钉外群主业务Id
    @NameInMap("groupOwnerId")
    public String groupOwnerId;

    // 群模板
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    // 操作者的钉钉Id
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateCoupleGroupConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupConversationRequest self = new CreateCoupleGroupConversationRequest();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupConversationRequest setAppUserId(String appUserId) {
        this.appUserId = appUserId;
        return this;
    }
    public String getAppUserId() {
        return this.appUserId;
    }

    public CreateCoupleGroupConversationRequest setGroupAvatar(String groupAvatar) {
        this.groupAvatar = groupAvatar;
        return this;
    }
    public String getGroupAvatar() {
        return this.groupAvatar;
    }

    public CreateCoupleGroupConversationRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateCoupleGroupConversationRequest setGroupOwnerId(String groupOwnerId) {
        this.groupOwnerId = groupOwnerId;
        return this;
    }
    public String getGroupOwnerId() {
        return this.groupOwnerId;
    }

    public CreateCoupleGroupConversationRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateCoupleGroupConversationRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
