// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityDetailRequest extends TeaModel {
    @NameInMap("entityId")
    public String entityId;

    @NameInMap("entityType")
    public String entityType;

    @NameInMap("userId")
    public String userId;

    public static AISaleEntityDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityDetailRequest self = new AISaleEntityDetailRequest();
        return TeaModel.build(map, self);
    }

    public AISaleEntityDetailRequest setEntityId(String entityId) {
        this.entityId = entityId;
        return this;
    }
    public String getEntityId() {
        return this.entityId;
    }

    public AISaleEntityDetailRequest setEntityType(String entityType) {
        this.entityType = entityType;
        return this;
    }
    public String getEntityType() {
        return this.entityType;
    }

    public AISaleEntityDetailRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
