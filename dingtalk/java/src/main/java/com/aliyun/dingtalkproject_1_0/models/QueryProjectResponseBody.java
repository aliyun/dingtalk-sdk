// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryProjectResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<QueryProjectResponseBodyResult> result;

    public static QueryProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProjectResponseBody self = new QueryProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProjectResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryProjectResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryProjectResponseBody setResult(java.util.List<QueryProjectResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryProjectResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryProjectResponseBodyResultCustomFieldsValue extends TeaModel {
        @NameInMap("customFieldValueId")
        public String customFieldValueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static QueryProjectResponseBodyResultCustomFieldsValue build(java.util.Map<String, ?> map) throws Exception {
            QueryProjectResponseBodyResultCustomFieldsValue self = new QueryProjectResponseBodyResultCustomFieldsValue();
            return TeaModel.build(map, self);
        }

        public QueryProjectResponseBodyResultCustomFieldsValue setCustomFieldValueId(String customFieldValueId) {
            this.customFieldValueId = customFieldValueId;
            return this;
        }
        public String getCustomFieldValueId() {
            return this.customFieldValueId;
        }

        public QueryProjectResponseBodyResultCustomFieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public QueryProjectResponseBodyResultCustomFieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryProjectResponseBodyResultCustomFields extends TeaModel {
        @NameInMap("customFieldId")
        public String customFieldId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<QueryProjectResponseBodyResultCustomFieldsValue> value;

        public static QueryProjectResponseBodyResultCustomFields build(java.util.Map<String, ?> map) throws Exception {
            QueryProjectResponseBodyResultCustomFields self = new QueryProjectResponseBodyResultCustomFields();
            return TeaModel.build(map, self);
        }

        public QueryProjectResponseBodyResultCustomFields setCustomFieldId(String customFieldId) {
            this.customFieldId = customFieldId;
            return this;
        }
        public String getCustomFieldId() {
            return this.customFieldId;
        }

        public QueryProjectResponseBodyResultCustomFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryProjectResponseBodyResultCustomFields setValue(java.util.List<QueryProjectResponseBodyResultCustomFieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<QueryProjectResponseBodyResultCustomFieldsValue> getValue() {
            return this.value;
        }

    }

    public static class QueryProjectResponseBodyResult extends TeaModel {
        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customFields")
        public java.util.List<QueryProjectResponseBodyResultCustomFields> customFields;

        @NameInMap("description")
        public String description;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("isSuspended")
        public Boolean isSuspended;

        @NameInMap("isTemplate")
        public Boolean isTemplate;

        @NameInMap("logo")
        public String logo;

        @NameInMap("name")
        public String name;

        @NameInMap("organizationId")
        public String organizationId;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("uniqueIdPrefix")
        public String uniqueIdPrefix;

        @NameInMap("updated")
        public String updated;

        @NameInMap("visibility")
        public String visibility;

        public static QueryProjectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryProjectResponseBodyResult self = new QueryProjectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryProjectResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public QueryProjectResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryProjectResponseBodyResult setCustomFields(java.util.List<QueryProjectResponseBodyResultCustomFields> customFields) {
            this.customFields = customFields;
            return this;
        }
        public java.util.List<QueryProjectResponseBodyResultCustomFields> getCustomFields() {
            return this.customFields;
        }

        public QueryProjectResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryProjectResponseBodyResult setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public QueryProjectResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public QueryProjectResponseBodyResult setIsSuspended(Boolean isSuspended) {
            this.isSuspended = isSuspended;
            return this;
        }
        public Boolean getIsSuspended() {
            return this.isSuspended;
        }

        public QueryProjectResponseBodyResult setIsTemplate(Boolean isTemplate) {
            this.isTemplate = isTemplate;
            return this;
        }
        public Boolean getIsTemplate() {
            return this.isTemplate;
        }

        public QueryProjectResponseBodyResult setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public QueryProjectResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProjectResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public QueryProjectResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public QueryProjectResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public QueryProjectResponseBodyResult setUniqueIdPrefix(String uniqueIdPrefix) {
            this.uniqueIdPrefix = uniqueIdPrefix;
            return this;
        }
        public String getUniqueIdPrefix() {
            return this.uniqueIdPrefix;
        }

        public QueryProjectResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public QueryProjectResponseBodyResult setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

}
