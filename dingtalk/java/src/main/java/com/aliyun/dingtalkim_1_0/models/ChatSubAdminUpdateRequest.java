// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChatSubAdminUpdateRequest extends TeaModel {
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 企业员工工号列表
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    // 设置2添加为管理员，设置3删除该管理员
    @NameInMap("role")
    public Integer role;

    public static ChatSubAdminUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatSubAdminUpdateRequest self = new ChatSubAdminUpdateRequest();
        return TeaModel.build(map, self);
    }

    public ChatSubAdminUpdateRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public ChatSubAdminUpdateRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public ChatSubAdminUpdateRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public ChatSubAdminUpdateRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public ChatSubAdminUpdateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public ChatSubAdminUpdateRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public ChatSubAdminUpdateRequest setRole(Integer role) {
        this.role = role;
        return this;
    }
    public Integer getRole() {
        return this.role;
    }

}
