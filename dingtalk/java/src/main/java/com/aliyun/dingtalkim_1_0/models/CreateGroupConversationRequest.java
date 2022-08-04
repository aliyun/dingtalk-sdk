// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupConversationRequest extends TeaModel {
    // 钉外成员列表。
    @NameInMap("appUserIds")
    public java.util.List<String> appUserIds;

    // 群头像。
    @NameInMap("groupAvatar")
    public String groupAvatar;

    // 群名称。
    @NameInMap("groupName")
    public String groupName;

    // 群主(钉内用户)userId。
    @NameInMap("groupOwnerId")
    public String groupOwnerId;

    // 群主类型<2.钉内用户类型 3.钉外用户类型>，如果不指定的话，默认是钉钉用户类型
    @NameInMap("groupOwnerType")
    public Integer groupOwnerType;

    // 群模板Id。
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    // 操作者在业务系统内的唯一标识。
    @NameInMap("operatorId")
    public String operatorId;

    // 钉内成员列表。
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
