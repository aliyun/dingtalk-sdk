// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetPermissionRequest extends TeaModel {
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

    @NameInMap("withKr")
    public Boolean withKr;

    @NameInMap("withObjective")
    public Boolean withObjective;

    public static GetPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionRequest self = new GetPermissionRequest();
        return TeaModel.build(map, self);
    }

    public GetPermissionRequest setTargetId(String targetId) {
        this.targetId = targetId;
        return this;
    }
    public String getTargetId() {
        return this.targetId;
    }

    public GetPermissionRequest setTargetType(String targetType) {
        this.targetType = targetType;
        return this;
    }
    public String getTargetType() {
        return this.targetType;
    }

    public GetPermissionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetPermissionRequest setWithKr(Boolean withKr) {
        this.withKr = withKr;
        return this;
    }
    public Boolean getWithKr() {
        return this.withKr;
    }

    public GetPermissionRequest setWithObjective(Boolean withObjective) {
        this.withObjective = withObjective;
        return this;
    }
    public Boolean getWithObjective() {
        return this.withObjective;
    }

}
