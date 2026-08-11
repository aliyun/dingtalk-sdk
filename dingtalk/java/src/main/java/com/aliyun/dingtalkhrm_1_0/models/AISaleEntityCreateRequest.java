// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityCreateRequest extends TeaModel {
    @NameInMap("entityId")
    public String entityId;

    @NameInMap("entityType")
    public String entityType;

    @NameInMap("fieldInstances")
    public java.util.List<AISaleEntityCreateRequestFieldInstances> fieldInstances;

    @NameInMap("userId")
    public String userId;

    public static AISaleEntityCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityCreateRequest self = new AISaleEntityCreateRequest();
        return TeaModel.build(map, self);
    }

    public AISaleEntityCreateRequest setEntityId(String entityId) {
        this.entityId = entityId;
        return this;
    }
    public String getEntityId() {
        return this.entityId;
    }

    public AISaleEntityCreateRequest setEntityType(String entityType) {
        this.entityType = entityType;
        return this;
    }
    public String getEntityType() {
        return this.entityType;
    }

    public AISaleEntityCreateRequest setFieldInstances(java.util.List<AISaleEntityCreateRequestFieldInstances> fieldInstances) {
        this.fieldInstances = fieldInstances;
        return this;
    }
    public java.util.List<AISaleEntityCreateRequestFieldInstances> getFieldInstances() {
        return this.fieldInstances;
    }

    public AISaleEntityCreateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class AISaleEntityCreateRequestFieldInstances extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldValue")
        public String fieldValue;

        public static AISaleEntityCreateRequestFieldInstances build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityCreateRequestFieldInstances self = new AISaleEntityCreateRequestFieldInstances();
            return TeaModel.build(map, self);
        }

        public AISaleEntityCreateRequestFieldInstances setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityCreateRequestFieldInstances setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

    }

}
