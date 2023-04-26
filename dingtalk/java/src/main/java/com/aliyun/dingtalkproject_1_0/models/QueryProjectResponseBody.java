// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryProjectResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryProjectResponseBodyResult> result;

    public static QueryProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProjectResponseBody self = new QueryProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProjectResponseBody setResult(java.util.List<QueryProjectResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryProjectResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryProjectResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static QueryProjectResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            QueryProjectResponseBodyResultCustomfieldsValue self = new QueryProjectResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public QueryProjectResponseBodyResultCustomfieldsValue setFieldvalueId(String fieldvalueId) {
            this.fieldvalueId = fieldvalueId;
            return this;
        }
        public String getFieldvalueId() {
            return this.fieldvalueId;
        }

        public QueryProjectResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public QueryProjectResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryProjectResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("customfieldId")
        public String customfieldId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<QueryProjectResponseBodyResultCustomfieldsValue> value;

        public static QueryProjectResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            QueryProjectResponseBodyResultCustomfields self = new QueryProjectResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public QueryProjectResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public QueryProjectResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryProjectResponseBodyResultCustomfields setValue(java.util.List<QueryProjectResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<QueryProjectResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class QueryProjectResponseBodyResult extends TeaModel {
        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfields")
        public java.util.List<QueryProjectResponseBodyResultCustomfields> customfields;

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

        public QueryProjectResponseBodyResult setCustomfields(java.util.List<QueryProjectResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<QueryProjectResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
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
