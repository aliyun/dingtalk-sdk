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

    public static class CreateProjectResponseBodyResultCustomFieldsValue extends TeaModel {
        @NameInMap("customFieldValueId")
        public String customFieldValueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static CreateProjectResponseBodyResultCustomFieldsValue build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectResponseBodyResultCustomFieldsValue self = new CreateProjectResponseBodyResultCustomFieldsValue();
            return TeaModel.build(map, self);
        }

        public CreateProjectResponseBodyResultCustomFieldsValue setCustomFieldValueId(String customFieldValueId) {
            this.customFieldValueId = customFieldValueId;
            return this;
        }
        public String getCustomFieldValueId() {
            return this.customFieldValueId;
        }

        public CreateProjectResponseBodyResultCustomFieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public CreateProjectResponseBodyResultCustomFieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateProjectResponseBodyResultCustomFields extends TeaModel {
        @NameInMap("customFieldId")
        public String customFieldId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<CreateProjectResponseBodyResultCustomFieldsValue> value;

        public static CreateProjectResponseBodyResultCustomFields build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectResponseBodyResultCustomFields self = new CreateProjectResponseBodyResultCustomFields();
            return TeaModel.build(map, self);
        }

        public CreateProjectResponseBodyResultCustomFields setCustomFieldId(String customFieldId) {
            this.customFieldId = customFieldId;
            return this;
        }
        public String getCustomFieldId() {
            return this.customFieldId;
        }

        public CreateProjectResponseBodyResultCustomFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateProjectResponseBodyResultCustomFields setValue(java.util.List<CreateProjectResponseBodyResultCustomFieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<CreateProjectResponseBodyResultCustomFieldsValue> getValue() {
            return this.value;
        }

    }

    public static class CreateProjectResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>0517xxxxxxx</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customFields")
        public java.util.List<CreateProjectResponseBodyResultCustomFields> customFields;

        /**
         * <strong>example:</strong>
         * <p>6398042ec98a4e4e33xxxxxx</p>
         */
        @NameInMap("defaultCollectionId")
        public String defaultCollectionId;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isArchived")
        public Boolean isArchived;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isSuspended")
        public Boolean isSuspended;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isTemplate")
        public Boolean isTemplate;

        /**
         * <strong>example:</strong>
         * <p>&quot;<a href="https://tcs-ga.teambition.net/thumb/xxxxxxx">https://tcs-ga.teambition.net/thumb/xxxxxxx</a></p>
         */
        @NameInMap("logo")
        public String logo;

        /**
         * <strong>example:</strong>
         * <p>项目1</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>taskflow</p>
         */
        @NameInMap("normalType")
        public String normalType;

        /**
         * <strong>example:</strong>
         * <p>62c25e3b376ecxxxxxxx</p>
         */
        @NameInMap("projectId")
        public String projectId;

        /**
         * <strong>example:</strong>
         * <p>6398042ec98a4e4e33</p>
         */
        @NameInMap("rootCollectionId")
        public String rootCollectionId;

        /**
         * <strong>example:</strong>
         * <p>62c25e3b376ecxxxxxxx</p>
         */
        @NameInMap("sourceId")
        public String sourceId;

        /**
         * <strong>example:</strong>
         * <p>&quot;&quot;</p>
         */
        @NameInMap("uniqueIdPrefix")
        public String uniqueIdPrefix;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <strong>example:</strong>
         * <p>project</p>
         */
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

        public CreateProjectResponseBodyResult setCustomFields(java.util.List<CreateProjectResponseBodyResultCustomFields> customFields) {
            this.customFields = customFields;
            return this;
        }
        public java.util.List<CreateProjectResponseBodyResultCustomFields> getCustomFields() {
            return this.customFields;
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
