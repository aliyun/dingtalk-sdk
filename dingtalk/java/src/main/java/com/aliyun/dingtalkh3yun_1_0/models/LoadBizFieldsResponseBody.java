// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizFieldsResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 提示信息
    @NameInMap("message")
    public String message;

    // 返回结果
    @NameInMap("data")
    public LoadBizFieldsResponseBodyData data;

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

    public LoadBizFieldsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public LoadBizFieldsResponseBody setData(LoadBizFieldsResponseBodyData data) {
        this.data = data;
        return this;
    }
    public LoadBizFieldsResponseBodyData getData() {
        return this.data;
    }

    public static class LoadBizFieldsResponseBodyDataFields extends TeaModel {
        // 显示名称
        @NameInMap("label")
        public String label;

        // 字段名称
        @NameInMap("fieldName")
        public String fieldName;

        // 字段、自定义组件的数据类型。Bool=逻辑型，DataTime=日期型、日期组件，Double=双精度数值型，Int=整形，Long=长整形，String=长文本，ShortString=短文本，ByteArray=二进制流， Image=图片类型、图片组件，File=附件类型组件，TimeSpan=时间段。Unit=参与者（单人），UnitArray=参与者（多人），Html=html类型，Xml=xml类型 BizObject=业务对象，BizObjectArray=业务对象数组、子表组件，Association=关联到其他对象、关联组件，AssociationArray=关联对象数组，Map=地图类型，Address=地址类型，Formula=公式型空间，Signature=签名控件，Plugin=文字识别Bool
        @NameInMap("bizDataType")
        public String bizDataType;

        public static LoadBizFieldsResponseBodyDataFields build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyDataFields self = new LoadBizFieldsResponseBodyDataFields();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyDataFields setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public LoadBizFieldsResponseBodyDataFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public LoadBizFieldsResponseBodyDataFields setBizDataType(String bizDataType) {
            this.bizDataType = bizDataType;
            return this;
        }
        public String getBizDataType() {
            return this.bizDataType;
        }

    }

    public static class LoadBizFieldsResponseBodyDataChildFormsFields extends TeaModel {
        // 显示名称
        @NameInMap("label")
        public String label;

        // 字段名或组件名
        @NameInMap("fieldName")
        public String fieldName;

        // 字段数据类型
        @NameInMap("bizDataType")
        public String bizDataType;

        public static LoadBizFieldsResponseBodyDataChildFormsFields build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyDataChildFormsFields self = new LoadBizFieldsResponseBodyDataChildFormsFields();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyDataChildFormsFields setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public LoadBizFieldsResponseBodyDataChildFormsFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public LoadBizFieldsResponseBodyDataChildFormsFields setBizDataType(String bizDataType) {
            this.bizDataType = bizDataType;
            return this;
        }
        public String getBizDataType() {
            return this.bizDataType;
        }

    }

    public static class LoadBizFieldsResponseBodyDataChildForms extends TeaModel {
        // 子表编码
        @NameInMap("schemaCode")
        public String schemaCode;

        // 子表名称
        @NameInMap("formName")
        public String formName;

        // 子表字段
        @NameInMap("fields")
        public java.util.List<LoadBizFieldsResponseBodyDataChildFormsFields> fields;

        public static LoadBizFieldsResponseBodyDataChildForms build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyDataChildForms self = new LoadBizFieldsResponseBodyDataChildForms();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyDataChildForms setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

        public LoadBizFieldsResponseBodyDataChildForms setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

        public LoadBizFieldsResponseBodyDataChildForms setFields(java.util.List<LoadBizFieldsResponseBodyDataChildFormsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<LoadBizFieldsResponseBodyDataChildFormsFields> getFields() {
            return this.fields;
        }

    }

    public static class LoadBizFieldsResponseBodyData extends TeaModel {
        // 表单编码
        @NameInMap("schemaCode")
        public String schemaCode;

        // 表单名称
        @NameInMap("formName")
        public String formName;

        // 字段、组件结构数组
        @NameInMap("fields")
        public java.util.List<LoadBizFieldsResponseBodyDataFields> fields;

        // 子表结构
        @NameInMap("childForms")
        public java.util.List<LoadBizFieldsResponseBodyDataChildForms> childForms;

        public static LoadBizFieldsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            LoadBizFieldsResponseBodyData self = new LoadBizFieldsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public LoadBizFieldsResponseBodyData setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

        public LoadBizFieldsResponseBodyData setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

        public LoadBizFieldsResponseBodyData setFields(java.util.List<LoadBizFieldsResponseBodyDataFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<LoadBizFieldsResponseBodyDataFields> getFields() {
            return this.fields;
        }

        public LoadBizFieldsResponseBodyData setChildForms(java.util.List<LoadBizFieldsResponseBodyDataChildForms> childForms) {
            this.childForms = childForms;
            return this;
        }
        public java.util.List<LoadBizFieldsResponseBodyDataChildForms> getChildForms() {
            return this.childForms;
        }

    }

}
