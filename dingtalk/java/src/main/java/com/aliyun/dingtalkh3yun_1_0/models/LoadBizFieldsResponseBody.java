// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizFieldsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public LoadBizFieldsResponseBodyData data;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("message")
    public String message;

    public static LoadBizFieldsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LoadBizFieldsResponseBody self = new LoadBizFieldsResponseBody();
        return TeaModel.build(map, self);
    }

    public LoadBizFieldsResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public LoadBizFieldsResponseBody setData(LoadBizFieldsResponseBodyData data) {
        this.data = data;
        return this;
    }
    public LoadBizFieldsResponseBodyData getData() {
        return this.data;
    }

    public LoadBizFieldsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class LoadBizFieldsResponseBodyDataChildFormsFields extends TeaModel {
        @NameInMap("bizDataType")
        public String bizDataType;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("label")
        public String label;

        public static LoadBizFieldsResponseBodyDataChildFormsFields build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyDataChildFormsFields self = new LoadBizFieldsResponseBodyDataChildFormsFields();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyDataChildFormsFields setBizDataType(String bizDataType) {
            this.bizDataType = bizDataType;
            return this;
        }
        public String getBizDataType() {
            return this.bizDataType;
        }

        public LoadBizFieldsResponseBodyDataChildFormsFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public LoadBizFieldsResponseBodyDataChildFormsFields setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

    }

    public static class LoadBizFieldsResponseBodyDataChildForms extends TeaModel {
        @NameInMap("fields")
        public java.util.List<LoadBizFieldsResponseBodyDataChildFormsFields> fields;

        @NameInMap("formName")
        public String formName;

        @NameInMap("schemaCode")
        public String schemaCode;

        public static LoadBizFieldsResponseBodyDataChildForms build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyDataChildForms self = new LoadBizFieldsResponseBodyDataChildForms();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyDataChildForms setFields(java.util.List<LoadBizFieldsResponseBodyDataChildFormsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<LoadBizFieldsResponseBodyDataChildFormsFields> getFields() {
            return this.fields;
        }

        public LoadBizFieldsResponseBodyDataChildForms setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

        public LoadBizFieldsResponseBodyDataChildForms setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

    }

    public static class LoadBizFieldsResponseBodyDataFields extends TeaModel {
        @NameInMap("bizDataType")
        public String bizDataType;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("label")
        public String label;

        public static LoadBizFieldsResponseBodyDataFields build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyDataFields self = new LoadBizFieldsResponseBodyDataFields();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyDataFields setBizDataType(String bizDataType) {
            this.bizDataType = bizDataType;
            return this;
        }
        public String getBizDataType() {
            return this.bizDataType;
        }

        public LoadBizFieldsResponseBodyDataFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public LoadBizFieldsResponseBodyDataFields setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

    }

    public static class LoadBizFieldsResponseBodyData extends TeaModel {
        @NameInMap("childForms")
        public java.util.List<LoadBizFieldsResponseBodyDataChildForms> childForms;

        @NameInMap("fields")
        public java.util.List<LoadBizFieldsResponseBodyDataFields> fields;

        @NameInMap("formName")
        public String formName;

        @NameInMap("schemaCode")
        public String schemaCode;

        public static LoadBizFieldsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyData self = new LoadBizFieldsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyData setChildForms(java.util.List<LoadBizFieldsResponseBodyDataChildForms> childForms) {
            this.childForms = childForms;
            return this;
        }
        public java.util.List<LoadBizFieldsResponseBodyDataChildForms> getChildForms() {
            return this.childForms;
        }

        public LoadBizFieldsResponseBodyData setFields(java.util.List<LoadBizFieldsResponseBodyDataFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<LoadBizFieldsResponseBodyDataFields> getFields() {
            return this.fields;
        }

        public LoadBizFieldsResponseBodyData setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

        public LoadBizFieldsResponseBodyData setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

    }

}
