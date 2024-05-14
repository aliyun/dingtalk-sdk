// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdatePrivacyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("privacy")
    public String privacy;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetId")
    public String targetId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetType")
    public String targetType;

    /**
     * <p>This parameter is required.</p>
     */
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
