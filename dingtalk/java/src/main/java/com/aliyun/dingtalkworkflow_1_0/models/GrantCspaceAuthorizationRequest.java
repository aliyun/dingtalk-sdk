// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GrantCspaceAuthorizationRequest extends TeaModel {
    // 权限有效时间，单位为秒。
    @NameInMap("durationSeconds")
    public Long durationSeconds;

    // 审批控件 id。
    @NameInMap("spaceId")
    public String spaceId;

    // 权限类型。
    @NameInMap("type")
    public String type;

    // 用户 id。
    @NameInMap("userId")
    public String userId;

    public static GrantCspaceAuthorizationRequest build(java.util.Map<String, ?> map) throws Exception {
        GrantCspaceAuthorizationRequest self = new GrantCspaceAuthorizationRequest();
        return TeaModel.build(map, self);
    }

    public GrantCspaceAuthorizationRequest setDurationSeconds(Long durationSeconds) {
        this.durationSeconds = durationSeconds;
        return this;
    }
    public Long getDurationSeconds() {
        return this.durationSeconds;
    }

    public GrantCspaceAuthorizationRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public GrantCspaceAuthorizationRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public GrantCspaceAuthorizationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
