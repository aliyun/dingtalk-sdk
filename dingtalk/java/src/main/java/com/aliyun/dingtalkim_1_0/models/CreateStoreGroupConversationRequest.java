// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateStoreGroupConversationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("businessUniqueKey")
    public String businessUniqueKey;

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
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    /**
     * <p>This parameter is required.</p>
     */
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
