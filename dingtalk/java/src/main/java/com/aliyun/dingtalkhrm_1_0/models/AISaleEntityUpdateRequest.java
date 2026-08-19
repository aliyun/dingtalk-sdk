// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityUpdateRequest extends TeaModel {
    @NameInMap("entityId")
    public String entityId;

    @NameInMap("entityType")
    public String entityType;

    @NameInMap("fieldInstances")
    public java.util.List<AISaleEntityUpdateRequestFieldInstances> fieldInstances;

    @NameInMap("source")
    public String source;

    @NameInMap("userId")
    public String userId;

    public static AISaleEntityUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityUpdateRequest self = new AISaleEntityUpdateRequest();
        return TeaModel.build(map, self);
    }

    public AISaleEntityUpdateRequest setEntityId(String entityId) {
        this.entityId = entityId;
        return this;
    }
    public String getEntityId() {
        return this.entityId;
    }

    public AISaleEntityUpdateRequest setEntityType(String entityType) {
        this.entityType = entityType;
        return this;
    }
    public String getEntityType() {
        return this.entityType;
    }

    public AISaleEntityUpdateRequest setFieldInstances(java.util.List<AISaleEntityUpdateRequestFieldInstances> fieldInstances) {
        this.fieldInstances = fieldInstances;
        return this;
    }
    public java.util.List<AISaleEntityUpdateRequestFieldInstances> getFieldInstances() {
        return this.fieldInstances;
    }

    public AISaleEntityUpdateRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public AISaleEntityUpdateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class AISaleEntityUpdateRequestFieldInstances extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldValue")
        public String fieldValue;

        public static AISaleEntityUpdateRequestFieldInstances build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityUpdateRequestFieldInstances self = new AISaleEntityUpdateRequestFieldInstances();
            return TeaModel.build(map, self);
        }

        public AISaleEntityUpdateRequestFieldInstances setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityUpdateRequestFieldInstances setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

    }

}
