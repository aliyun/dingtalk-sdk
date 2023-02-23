// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateStoreGroupConversationRequest extends TeaModel {
    /**
     * <p>钉外账号在业务系统内的唯一标识。</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <p>外部业务唯一标识（店铺唯一标识）。</p>
     */
    @NameInMap("businessUniqueKey")
    public String businessUniqueKey;

    /**
     * <p>群头像地址。</p>
     */
    @NameInMap("groupAvatar")
    public String groupAvatar;

    /**
     * <p>群名称。</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>群模板Id。</p>
     */
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    /**
     * <p>操作者在业务系统内的唯一标识。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>钉内成员列表。</p>
     */
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
