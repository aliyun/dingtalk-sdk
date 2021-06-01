// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateTheGroupRolesOfGroupMemberRequest extends TeaModel {
    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 用户ID
    @NameInMap("userId")
    public String userId;

    // 群角色列表
    @NameInMap("openRoleIds")
    public java.util.List<String> openRoleIds;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    public static UpdateTheGroupRolesOfGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTheGroupRolesOfGroupMemberRequest self = new UpdateTheGroupRolesOfGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setOpenRoleIds(java.util.List<String> openRoleIds) {
        this.openRoleIds = openRoleIds;
        return this;
    }
    public java.util.List<String> getOpenRoleIds() {
        return this.openRoleIds;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

}
