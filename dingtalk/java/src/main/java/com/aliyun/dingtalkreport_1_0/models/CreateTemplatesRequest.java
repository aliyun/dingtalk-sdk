// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class CreateTemplatesRequest extends TeaModel {
    @NameInMap("allowAddReceivers")
    public Boolean allowAddReceivers;

    @NameInMap("allowEdit")
    public Boolean allowEdit;

    @NameInMap("allowGetLocation")
    public Boolean allowGetLocation;

    @NameInMap("authDeptIds")
    public java.util.List<String> authDeptIds;

    @NameInMap("authUserIds")
    public java.util.List<String> authUserIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>182942</p>
     */
    @NameInMap("creator")
    public String creator;

    @NameInMap("defaultReceivedCids")
    public java.util.List<String> defaultReceivedCids;

    @NameInMap("defaultReceivedMasterLevels")
    public java.util.List<String> defaultReceivedMasterLevels;

    @NameInMap("defaultReceivers")
    public java.util.List<String> defaultReceivers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fields")
    public java.util.List<CreateTemplatesRequestFields> fields;

    /**
     * <strong>example:</strong>
     * <p><a href="https://xxx.jpg">https://xxx.jpg</a></p>
     */
    @NameInMap("logo")
    public String logo;

    /**
     * <strong>example:</strong>
     * <p>1000</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("maxWordCount")
    public Integer maxWordCount;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("minWordCount")
    public Integer minWordCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>工作日报</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("templateManagers")
    public java.util.List<String> templateManagers;

    public static CreateTemplatesRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTemplatesRequest self = new CreateTemplatesRequest();
        return TeaModel.build(map, self);
    }

    public CreateTemplatesRequest setAllowAddReceivers(Boolean allowAddReceivers) {
        this.allowAddReceivers = allowAddReceivers;
        return this;
    }
    public Boolean getAllowAddReceivers() {
        return this.allowAddReceivers;
    }

    public CreateTemplatesRequest setAllowEdit(Boolean allowEdit) {
        this.allowEdit = allowEdit;
        return this;
    }
    public Boolean getAllowEdit() {
        return this.allowEdit;
    }

    public CreateTemplatesRequest setAllowGetLocation(Boolean allowGetLocation) {
        this.allowGetLocation = allowGetLocation;
        return this;
    }
    public Boolean getAllowGetLocation() {
        return this.allowGetLocation;
    }

    public CreateTemplatesRequest setAuthDeptIds(java.util.List<String> authDeptIds) {
        this.authDeptIds = authDeptIds;
        return this;
    }
    public java.util.List<String> getAuthDeptIds() {
        return this.authDeptIds;
    }

    public CreateTemplatesRequest setAuthUserIds(java.util.List<String> authUserIds) {
        this.authUserIds = authUserIds;
        return this;
    }
    public java.util.List<String> getAuthUserIds() {
        return this.authUserIds;
    }

    public CreateTemplatesRequest setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public CreateTemplatesRequest setDefaultReceivedCids(java.util.List<String> defaultReceivedCids) {
        this.defaultReceivedCids = defaultReceivedCids;
        return this;
    }
    public java.util.List<String> getDefaultReceivedCids() {
        return this.defaultReceivedCids;
    }

    public CreateTemplatesRequest setDefaultReceivedMasterLevels(java.util.List<String> defaultReceivedMasterLevels) {
        this.defaultReceivedMasterLevels = defaultReceivedMasterLevels;
        return this;
    }
    public java.util.List<String> getDefaultReceivedMasterLevels() {
        return this.defaultReceivedMasterLevels;
    }

    public CreateTemplatesRequest setDefaultReceivers(java.util.List<String> defaultReceivers) {
        this.defaultReceivers = defaultReceivers;
        return this;
    }
    public java.util.List<String> getDefaultReceivers() {
        return this.defaultReceivers;
    }

    public CreateTemplatesRequest setFields(java.util.List<CreateTemplatesRequestFields> fields) {
        this.fields = fields;
        return this;
    }
    public java.util.List<CreateTemplatesRequestFields> getFields() {
        return this.fields;
    }

    public CreateTemplatesRequest setLogo(String logo) {
        this.logo = logo;
        return this;
    }
    public String getLogo() {
        return this.logo;
    }

    public CreateTemplatesRequest setMaxWordCount(Integer maxWordCount) {
        this.maxWordCount = maxWordCount;
        return this;
    }
    public Integer getMaxWordCount() {
        return this.maxWordCount;
    }

    public CreateTemplatesRequest setMinWordCount(Integer minWordCount) {
        this.minWordCount = minWordCount;
        return this;
    }
    public Integer getMinWordCount() {
        return this.minWordCount;
    }

    public CreateTemplatesRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateTemplatesRequest setTemplateManagers(java.util.List<String> templateManagers) {
        this.templateManagers = templateManagers;
        return this;
    }
    public java.util.List<String> getTemplateManagers() {
        return this.templateManagers;
    }

    public static class CreateTemplatesRequestFieldsDataValueOpenInfo extends TeaModel {
        @NameInMap("attribute")
        public java.util.Map<String, String> attribute;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("openId")
        public String openId;

        public static CreateTemplatesRequestFieldsDataValueOpenInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateTemplatesRequestFieldsDataValueOpenInfo self = new CreateTemplatesRequestFieldsDataValueOpenInfo();
            return TeaModel.build(map, self);
        }

        public CreateTemplatesRequestFieldsDataValueOpenInfo setAttribute(java.util.Map<String, String> attribute) {
            this.attribute = attribute;
            return this;
        }
        public java.util.Map<String, String> getAttribute() {
            return this.attribute;
        }

        public CreateTemplatesRequestFieldsDataValueOpenInfo setOpenId(String openId) {
            this.openId = openId;
            return this;
        }
        public String getOpenId() {
            return this.openId;
        }

    }

    public static class CreateTemplatesRequestFieldsDataValue extends TeaModel {
        @NameInMap("openInfo")
        public CreateTemplatesRequestFieldsDataValueOpenInfo openInfo;

        @NameInMap("options")
        public java.util.List<String> options;

        @NameInMap("placeholder")
        public String placeholder;

        public static CreateTemplatesRequestFieldsDataValue build(java.util.Map<String, ?> map) throws Exception {
            CreateTemplatesRequestFieldsDataValue self = new CreateTemplatesRequestFieldsDataValue();
            return TeaModel.build(map, self);
        }

        public CreateTemplatesRequestFieldsDataValue setOpenInfo(CreateTemplatesRequestFieldsDataValueOpenInfo openInfo) {
            this.openInfo = openInfo;
            return this;
        }
        public CreateTemplatesRequestFieldsDataValueOpenInfo getOpenInfo() {
            return this.openInfo;
        }

        public CreateTemplatesRequestFieldsDataValue setOptions(java.util.List<String> options) {
            this.options = options;
            return this;
        }
        public java.util.List<String> getOptions() {
            return this.options;
        }

        public CreateTemplatesRequestFieldsDataValue setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

    }

    public static class CreateTemplatesRequestFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("dataType")
        public Integer dataType;

        @NameInMap("dataValue")
        public CreateTemplatesRequestFieldsDataValue dataValue;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("need")
        public Boolean need;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("order")
        public Integer order;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("sort")
        public Integer sort;

        public static CreateTemplatesRequestFields build(java.util.Map<String, ?> map) throws Exception {
            CreateTemplatesRequestFields self = new CreateTemplatesRequestFields();
            return TeaModel.build(map, self);
        }

        public CreateTemplatesRequestFields setDataType(Integer dataType) {
            this.dataType = dataType;
            return this;
        }
        public Integer getDataType() {
            return this.dataType;
        }

        public CreateTemplatesRequestFields setDataValue(CreateTemplatesRequestFieldsDataValue dataValue) {
            this.dataValue = dataValue;
            return this;
        }
        public CreateTemplatesRequestFieldsDataValue getDataValue() {
            return this.dataValue;
        }

        public CreateTemplatesRequestFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public CreateTemplatesRequestFields setNeed(Boolean need) {
            this.need = need;
            return this;
        }
        public Boolean getNeed() {
            return this.need;
        }

        public CreateTemplatesRequestFields setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

        public CreateTemplatesRequestFields setSort(Integer sort) {
            this.sort = sort;
            return this;
        }
        public Integer getSort() {
            return this.sort;
        }

    }

}
