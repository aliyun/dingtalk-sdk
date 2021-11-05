// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSubAdminRequest extends TeaModel {
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

    @NameInMap("dingClientId")
    public String dingClientId;

    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 用户ID清单
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    // 2-群管理员 3-普通群成员
    @NameInMap("role")
    public Long role;

    public static UpdateGroupSubAdminRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSubAdminRequest self = new UpdateGroupSubAdminRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSubAdminRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpdateGroupSubAdminRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UpdateGroupSubAdminRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpdateGroupSubAdminRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public UpdateGroupSubAdminRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public UpdateGroupSubAdminRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public UpdateGroupSubAdminRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateGroupSubAdminRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public UpdateGroupSubAdminRequest setRole(Long role) {
        this.role = role;
        return this;
    }
    public Long getRole() {
        return this.role;
    }

}
