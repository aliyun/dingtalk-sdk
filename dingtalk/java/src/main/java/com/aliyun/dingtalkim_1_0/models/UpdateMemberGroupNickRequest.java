// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberGroupNickRequest extends TeaModel {
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

    // 用户ID
    @NameInMap("userId")
    public String userId;

    // 群昵称
    @NameInMap("groupNick")
    public String groupNick;

    public static UpdateMemberGroupNickRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberGroupNickRequest self = new UpdateMemberGroupNickRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMemberGroupNickRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpdateMemberGroupNickRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UpdateMemberGroupNickRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpdateMemberGroupNickRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public UpdateMemberGroupNickRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public UpdateMemberGroupNickRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public UpdateMemberGroupNickRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateMemberGroupNickRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public UpdateMemberGroupNickRequest setGroupNick(String groupNick) {
        this.groupNick = groupNick;
        return this;
    }
    public String getGroupNick() {
        return this.groupNick;
    }

}
