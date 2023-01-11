// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeletePermissionRequest extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("policyType")
    public Long policyType;

    @NameInMap("targetId")
    public String targetId;

    @NameInMap("targetType")
    public String targetType;

    @NameInMap("type")
    public String type;

    /**
     * <p>当前用户的userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeletePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeletePermissionRequest self = new DeletePermissionRequest();
        return TeaModel.build(map, self);
    }

    public DeletePermissionRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public DeletePermissionRequest setPolicyType(Long policyType) {
        this.policyType = policyType;
        return this;
    }
    public Long getPolicyType() {
        return this.policyType;
    }

    public DeletePermissionRequest setTargetId(String targetId) {
        this.targetId = targetId;
        return this;
    }
    public String getTargetId() {
        return this.targetId;
    }

    public DeletePermissionRequest setTargetType(String targetType) {
        this.targetType = targetType;
        return this;
    }
    public String getTargetType() {
        return this.targetType;
    }

    public DeletePermissionRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public DeletePermissionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
