// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupPermissionRequest extends TeaModel {
    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 群权限项
    @NameInMap("permissionGroup")
    public String permissionGroup;

    // 状态,0-关闭，1-开启
    @NameInMap("status")
    public String status;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static UpdateGroupPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupPermissionRequest self = new UpdateGroupPermissionRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupPermissionRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateGroupPermissionRequest setPermissionGroup(String permissionGroup) {
        this.permissionGroup = permissionGroup;
        return this;
    }
    public String getPermissionGroup() {
        return this.permissionGroup;
    }

    public UpdateGroupPermissionRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpdateGroupPermissionRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpdateGroupPermissionRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UpdateGroupPermissionRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpdateGroupPermissionRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public UpdateGroupPermissionRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
