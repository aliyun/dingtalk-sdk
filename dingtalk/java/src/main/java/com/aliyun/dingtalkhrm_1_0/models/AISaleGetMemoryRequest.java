// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleGetMemoryRequest extends TeaModel {
    @NameInMap("creatorId")
    public String creatorId;

    @NameInMap("cursor")
    public String cursor;

    @NameInMap("customerScopeId")
    public String customerScopeId;

    @NameInMap("entityId")
    public String entityId;

    @NameInMap("entityIds")
    public java.util.List<String> entityIds;

    @NameInMap("entityType")
    public String entityType;

    @NameInMap("keyword")
    public String keyword;

    @NameInMap("memoryCategory")
    public String memoryCategory;

    @NameInMap("minImportance")
    public Integer minImportance;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("userId")
    public String userId;

    public static AISaleGetMemoryRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleGetMemoryRequest self = new AISaleGetMemoryRequest();
        return TeaModel.build(map, self);
    }

    public AISaleGetMemoryRequest setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public AISaleGetMemoryRequest setCursor(String cursor) {
        this.cursor = cursor;
        return this;
    }
    public String getCursor() {
        return this.cursor;
    }

    public AISaleGetMemoryRequest setCustomerScopeId(String customerScopeId) {
        this.customerScopeId = customerScopeId;
        return this;
    }
    public String getCustomerScopeId() {
        return this.customerScopeId;
    }

    public AISaleGetMemoryRequest setEntityId(String entityId) {
        this.entityId = entityId;
        return this;
    }
    public String getEntityId() {
        return this.entityId;
    }

    public AISaleGetMemoryRequest setEntityIds(java.util.List<String> entityIds) {
        this.entityIds = entityIds;
        return this;
    }
    public java.util.List<String> getEntityIds() {
        return this.entityIds;
    }

    public AISaleGetMemoryRequest setEntityType(String entityType) {
        this.entityType = entityType;
        return this;
    }
    public String getEntityType() {
        return this.entityType;
    }

    public AISaleGetMemoryRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public AISaleGetMemoryRequest setMemoryCategory(String memoryCategory) {
        this.memoryCategory = memoryCategory;
        return this;
    }
    public String getMemoryCategory() {
        return this.memoryCategory;
    }

    public AISaleGetMemoryRequest setMinImportance(Integer minImportance) {
        this.minImportance = minImportance;
        return this;
    }
    public Integer getMinImportance() {
        return this.minImportance;
    }

    public AISaleGetMemoryRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public AISaleGetMemoryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
