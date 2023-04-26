// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateProjectResponseBodyResult result;

    public static CreateProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectResponseBody self = new CreateProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateProjectResponseBody setResult(CreateProjectResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateProjectResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateProjectResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static CreateProjectResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectResponseBodyResultCustomfieldsValue self = new CreateProjectResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public CreateProjectResponseBodyResultCustomfieldsValue setFieldvalueId(String fieldvalueId) {
            this.fieldvalueId = fieldvalueId;
            return this;
        }
        public String getFieldvalueId() {
            return this.fieldvalueId;
        }

        public CreateProjectResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public CreateProjectResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateProjectResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("customfieldId")
        public String customfieldId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<CreateProjectResponseBodyResultCustomfieldsValue> value;

        public static CreateProjectResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectResponseBodyResultCustomfields self = new CreateProjectResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public CreateProjectResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public CreateProjectResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateProjectResponseBodyResultCustomfields setValue(java.util.List<CreateProjectResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<CreateProjectResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class CreateProjectResponseBodyResult extends TeaModel {
        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfields")
        public java.util.List<CreateProjectResponseBodyResultCustomfields> customfields;

        @NameInMap("defaultCollectionId")
        public String defaultCollectionId;

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

        @NameInMap("normalType")
        public String normalType;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("rootCollectionId")
        public String rootCollectionId;

        @NameInMap("sourceId")
        public String sourceId;

        @NameInMap("uniqueIdPrefix")
        public String uniqueIdPrefix;

        @NameInMap("updated")
        public String updated;

        @NameInMap("visibility")
        public String visibility;

        public static CreateProjectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectResponseBodyResult self = new CreateProjectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateProjectResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public CreateProjectResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public CreateProjectResponseBodyResult setCustomfields(java.util.List<CreateProjectResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<CreateProjectResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

        public CreateProjectResponseBodyResult setDefaultCollectionId(String defaultCollectionId) {
            this.defaultCollectionId = defaultCollectionId;
            return this;
        }
        public String getDefaultCollectionId() {
            return this.defaultCollectionId;
        }

        public CreateProjectResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public CreateProjectResponseBodyResult setIsSuspended(Boolean isSuspended) {
            this.isSuspended = isSuspended;
            return this;
        }
        public Boolean getIsSuspended() {
            return this.isSuspended;
        }

        public CreateProjectResponseBodyResult setIsTemplate(Boolean isTemplate) {
            this.isTemplate = isTemplate;
            return this;
        }
        public Boolean getIsTemplate() {
            return this.isTemplate;
        }

        public CreateProjectResponseBodyResult setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public CreateProjectResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateProjectResponseBodyResult setNormalType(String normalType) {
            this.normalType = normalType;
            return this;
        }
        public String getNormalType() {
            return this.normalType;
        }

        public CreateProjectResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public CreateProjectResponseBodyResult setRootCollectionId(String rootCollectionId) {
            this.rootCollectionId = rootCollectionId;
            return this;
        }
        public String getRootCollectionId() {
            return this.rootCollectionId;
        }

        public CreateProjectResponseBodyResult setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public CreateProjectResponseBodyResult setUniqueIdPrefix(String uniqueIdPrefix) {
            this.uniqueIdPrefix = uniqueIdPrefix;
            return this;
        }
        public String getUniqueIdPrefix() {
            return this.uniqueIdPrefix;
        }

        public CreateProjectResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public CreateProjectResponseBodyResult setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

}
