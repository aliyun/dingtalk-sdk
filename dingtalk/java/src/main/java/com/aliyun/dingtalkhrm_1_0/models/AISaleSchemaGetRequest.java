// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleSchemaGetRequest extends TeaModel {
    @NameInMap("entityType")
    public String entityType;

    @NameInMap("userId")
    public String userId;

    public static AISaleSchemaGetRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleSchemaGetRequest self = new AISaleSchemaGetRequest();
        return TeaModel.build(map, self);
    }

    public AISaleSchemaGetRequest setEntityType(String entityType) {
        this.entityType = entityType;
        return this;
    }
    public String getEntityType() {
        return this.entityType;
    }

    public AISaleSchemaGetRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
