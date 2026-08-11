// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityListRequest extends TeaModel {
    @NameInMap("conditions")
    public java.util.List<AISaleEntityListRequestConditions> conditions;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("cursor")
    public String cursor;

    /**
     * <strong>example:</strong>
     * <p>CUSTOMER</p>
     */
    @NameInMap("entityType")
    public String entityType;

    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>userId123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AISaleEntityListRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityListRequest self = new AISaleEntityListRequest();
        return TeaModel.build(map, self);
    }

    public AISaleEntityListRequest setConditions(java.util.List<AISaleEntityListRequestConditions> conditions) {
        this.conditions = conditions;
        return this;
    }
    public java.util.List<AISaleEntityListRequestConditions> getConditions() {
        return this.conditions;
    }

    public AISaleEntityListRequest setCursor(String cursor) {
        this.cursor = cursor;
        return this;
    }
    public String getCursor() {
        return this.cursor;
    }

    public AISaleEntityListRequest setEntityType(String entityType) {
        this.entityType = entityType;
        return this;
    }
    public String getEntityType() {
        return this.entityType;
    }

    public AISaleEntityListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public AISaleEntityListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class AISaleEntityListRequestConditions extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("operator")
        public String operator;

        @NameInMap("value")
        public String value;

        public static AISaleEntityListRequestConditions build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityListRequestConditions self = new AISaleEntityListRequestConditions();
            return TeaModel.build(map, self);
        }

        public AISaleEntityListRequestConditions setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityListRequestConditions setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public AISaleEntityListRequestConditions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
