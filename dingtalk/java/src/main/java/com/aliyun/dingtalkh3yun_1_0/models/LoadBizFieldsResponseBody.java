// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizFieldsResponseBody extends TeaModel {
    /**
     * <p>状态码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("data")
    public LoadBizFieldsResponseBodyData data;

    /**
     * <p>提示信息</p>
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
        /**
         * <p>字段数据类型</p>
         */
        @NameInMap("bizDataType")
        public String bizDataType;

        /**
         * <p>字段名或组件名</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <p>显示名称</p>
         */
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
        /**
         * <p>子表字段</p>
         */
        @NameInMap("fields")
        public java.util.List<LoadBizFieldsResponseBodyDataChildFormsFields> fields;

        /**
         * <p>子表名称</p>
         */
        @NameInMap("formName")
        public String formName;

        /**
         * <p>子表编码</p>
         */
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
        /**
         * <p>字段、自定义组件的数据类型。Bool=逻辑型，DataTime=日期型、日期组件，Double=双精度数值型，Int=整形，Long=长整形，String=长文本，ShortString=短文本，ByteArray=二进制流， Image=图片类型、图片组件，File=附件类型组件，TimeSpan=时间段。Unit=参与者（单人），UnitArray=参与者（多人），Html=html类型，Xml=xml类型 BizObject=业务对象，BizObjectArray=业务对象数组、子表组件，Association=关联到其他对象、关联组件，AssociationArray=关联对象数组，Map=地图类型，Address=地址类型，Formula=公式型空间，Signature=签名控件，Plugin=文字识别Bool</p>
         */
        @NameInMap("bizDataType")
        public String bizDataType;

        /**
         * <p>字段名称</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <p>显示名称</p>
         */
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
        /**
         * <p>子表结构</p>
         */
        @NameInMap("childForms")
        public java.util.List<LoadBizFieldsResponseBodyDataChildForms> childForms;

        /**
         * <p>字段、组件结构数组</p>
         */
        @NameInMap("fields")
        public java.util.List<LoadBizFieldsResponseBodyDataFields> fields;

        /**
         * <p>表单名称</p>
         */
        @NameInMap("formName")
        public String formName;

        /**
         * <p>表单编码</p>
         */
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
