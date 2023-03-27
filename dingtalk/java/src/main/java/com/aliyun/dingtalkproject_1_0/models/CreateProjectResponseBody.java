// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectResponseBody extends TeaModel {
    /**
     * <p>返回结果。</p>
     */
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
        /**
         * <p>自定义字段值ID。</p>
         */
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        /**
         * <p>自定义字段值元属性。</p>
         */
        @NameInMap("metaString")
        public String metaString;

        /**
         * <p>自定义字段值内容。</p>
         */
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
        /**
         * <p>自定义字段ID。</p>
         */
        @NameInMap("customfieldId")
        public String customfieldId;

        /**
         * <p>自定义字段类型。</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>自定义字段值列表。</p>
         */
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
        /**
         * <p>创建时间。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建人ID。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>自定义字段值集合。</p>
         */
        @NameInMap("customfields")
        public java.util.List<CreateProjectResponseBodyResultCustomfields> customfields;

        /**
         * <p>项目默认文件夹ID。</p>
         */
        @NameInMap("defaultCollectionId")
        public String defaultCollectionId;

        /**
         * <p>是否在回收站。</p>
         */
        @NameInMap("isArchived")
        public Boolean isArchived;

        /**
         * <p>是否归档。</p>
         */
        @NameInMap("isSuspended")
        public Boolean isSuspended;

        /**
         * <p>是否为模版项目。</p>
         */
        @NameInMap("isTemplate")
        public Boolean isTemplate;

        /**
         * <p>项目封面。</p>
         */
        @NameInMap("logo")
        public String logo;

        /**
         * <p>项目名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>项目类型。</p>
         */
        @NameInMap("normalType")
        public String normalType;

        /**
         * <p>项目ID。</p>
         */
        @NameInMap("projectId")
        public String projectId;

        /**
         * <p>项目根文件夹ID。</p>
         */
        @NameInMap("rootCollectionId")
        public String rootCollectionId;

        /**
         * <p>来源项目ID。</p>
         */
        @NameInMap("sourceId")
        public String sourceId;

        /**
         * <p>任务ID前缀。</p>
         */
        @NameInMap("uniqueIdPrefix")
        public String uniqueIdPrefix;

        /**
         * <p>更新时间。</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <p>项目可见性。</p>
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
