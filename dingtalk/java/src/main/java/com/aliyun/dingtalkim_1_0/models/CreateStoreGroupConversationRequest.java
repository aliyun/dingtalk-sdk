// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateStoreGroupConversationRequest extends TeaModel {
    // 钉外用户在业务系统内的唯一标识
    @NameInMap("appUserId")
    public String appUserId;

    // 外部业务唯一标识（店铺唯一标识）
    @NameInMap("businessUniqueKey")
    public String businessUniqueKey;

    // 群头像
    @NameInMap("groupAvatar")
    public String groupAvatar;

    // 群名称
    @NameInMap("groupName")
    public String groupName;

    // 群模板
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    // 操作者在业务系统内的唯一标识
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateStoreGroupConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateStoreGroupConversationRequest self = new CreateStoreGroupConversationRequest();
        return TeaModel.build(map, self);
    }

    public CreateStoreGroupConversationRequest setAppUserId(String appUserId) {
        this.appUserId = appUserId;
        return this;
    }
    public String getAppUserId() {
        return this.appUserId;
    }

    public CreateStoreGroupConversationRequest setBusinessUniqueKey(String businessUniqueKey) {
        this.businessUniqueKey = businessUniqueKey;
        return this;
    }
    public String getBusinessUniqueKey() {
        return this.businessUniqueKey;
    }

    public CreateStoreGroupConversationRequest setGroupAvatar(String groupAvatar) {
        this.groupAvatar = groupAvatar;
        return this;
    }
    public String getGroupAvatar() {
        return this.groupAvatar;
    }

    public CreateStoreGroupConversationRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateStoreGroupConversationRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateStoreGroupConversationRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateStoreGroupConversationRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
