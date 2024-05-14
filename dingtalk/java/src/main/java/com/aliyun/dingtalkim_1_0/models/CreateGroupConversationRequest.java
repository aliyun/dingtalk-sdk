// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupConversationRequest extends TeaModel {
    @NameInMap("appUserIds")
    public java.util.List<String> appUserIds;

    @NameInMap("groupAvatar")
    public String groupAvatar;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupOwnerId")
    public String groupOwnerId;

    @NameInMap("groupOwnerType")
    public Integer groupOwnerType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateGroupConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupConversationRequest self = new CreateGroupConversationRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupConversationRequest setAppUserIds(java.util.List<String> appUserIds) {
        this.appUserIds = appUserIds;
        return this;
    }
    public java.util.List<String> getAppUserIds() {
        return this.appUserIds;
    }

    public CreateGroupConversationRequest setGroupAvatar(String groupAvatar) {
        this.groupAvatar = groupAvatar;
        return this;
    }
    public String getGroupAvatar() {
        return this.groupAvatar;
    }

    public CreateGroupConversationRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateGroupConversationRequest setGroupOwnerId(String groupOwnerId) {
        this.groupOwnerId = groupOwnerId;
        return this;
    }
    public String getGroupOwnerId() {
        return this.groupOwnerId;
    }

    public CreateGroupConversationRequest setGroupOwnerType(Integer groupOwnerType) {
        this.groupOwnerType = groupOwnerType;
        return this;
    }
    public Integer getGroupOwnerType() {
        return this.groupOwnerType;
    }

    public CreateGroupConversationRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateGroupConversationRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateGroupConversationRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
