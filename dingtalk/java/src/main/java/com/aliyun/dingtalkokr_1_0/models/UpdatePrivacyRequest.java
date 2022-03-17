// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdatePrivacyRequest extends TeaModel {
    // 权限修改的类型
    @NameInMap("privacy")
    public String privacy;

    // 当前目标的 ID
    @NameInMap("targetId")
    public String targetId;

    // 当前目标的权限类型。
    @NameInMap("targetType")
    public String targetType;

    // 当前用户的userId。
    @NameInMap("userId")
    public String userId;

    public static UpdatePrivacyRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePrivacyRequest self = new UpdatePrivacyRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePrivacyRequest setPrivacy(String privacy) {
        this.privacy = privacy;
        return this;
    }
    public String getPrivacy() {
        return this.privacy;
    }

    public UpdatePrivacyRequest setTargetId(String targetId) {
        this.targetId = targetId;
        return this;
    }
    public String getTargetId() {
        return this.targetId;
    }

    public UpdatePrivacyRequest setTargetType(String targetType) {
        this.targetType = targetType;
        return this;
    }
    public String getTargetType() {
        return this.targetType;
    }

    public UpdatePrivacyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
