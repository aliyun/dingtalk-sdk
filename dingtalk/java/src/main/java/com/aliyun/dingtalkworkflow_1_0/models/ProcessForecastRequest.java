// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ProcessForecastRequest extends TeaModel {
    // 部门ID
    @NameInMap("deptId")
    public Integer deptId;

    // 表单数据内容，控件列表
    @NameInMap("formComponentValues")
    public java.util.List<ProcessForecastRequestFormComponentValues> formComponentValues;

    // 审批流的唯一码
    @NameInMap("processCode")
    public String processCode;

    // 审批发起人的userId
    @NameInMap("userId")
    public String userId;

    public static ProcessForecastRequest build(java.util.Map<String, ?> map) throws Exception {
        ProcessForecastRequest self = new ProcessForecastRequest();
        return TeaModel.build(map, self);
    }

    public ProcessForecastRequest setDeptId(Integer deptId) {
        this.deptId = deptId;
        return this;
    }
    public Integer getDeptId() {
        return this.deptId;
    }

    public ProcessForecastRequest setFormComponentValues(java.util.List<ProcessForecastRequestFormComponentValues> formComponentValues) {
        this.formComponentValues = formComponentValues;
        return this;
    }
    public java.util.List<ProcessForecastRequestFormComponentValues> getFormComponentValues() {
        return this.formComponentValues;
    }

    public ProcessForecastRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public ProcessForecastRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class ProcessForecastRequestFormComponentValuesDetailsDetails extends TeaModel {
        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        // 控件扩展值
        @NameInMap("extValue")
        public String extValue;

        // 控件id
        @NameInMap("id")
        public String id;

        // 控件名称
        @NameInMap("name")
        public String name;

        // 控件值
        @NameInMap("value")
        public String value;

        public static ProcessForecastRequestFormComponentValuesDetailsDetails build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValuesDetailsDetails self = new ProcessForecastRequestFormComponentValuesDetailsDetails();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ProcessForecastRequestFormComponentValuesDetails extends TeaModel {
        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("details")
        public java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> details;

        // 控件扩展值
        @NameInMap("extValue")
        public String extValue;

        // 控件id
        @NameInMap("id")
        public String id;

        // 控件名称
        @NameInMap("name")
        public String name;

        // 控件值
        @NameInMap("value")
        public String value;

        public static ProcessForecastRequestFormComponentValuesDetails build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValuesDetails self = new ProcessForecastRequestFormComponentValuesDetails();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValuesDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public ProcessForecastRequestFormComponentValuesDetails setDetails(java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> getDetails() {
            return this.details;
        }

        public ProcessForecastRequestFormComponentValuesDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValuesDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValuesDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ProcessForecastRequestFormComponentValuesDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ProcessForecastRequestFormComponentValues extends TeaModel {
        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 控件类型
        @NameInMap("componentType")
        public String componentType;

        @NameInMap("details")
        public java.util.List<ProcessForecastRequestFormComponentValuesDetails> details;

        // 控件扩展值
        @NameInMap("extValue")
        public String extValue;

        // 控件id
        @NameInMap("id")
        public String id;

        // 控件名称
        @NameInMap("name")
        public String name;

        // 控件值
        @NameInMap("value")
        public String value;

        public static ProcessForecastRequestFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValues self = new ProcessForecastRequestFormComponentValues();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValues setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public ProcessForecastRequestFormComponentValues setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public ProcessForecastRequestFormComponentValues setDetails(java.util.List<ProcessForecastRequestFormComponentValuesDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<ProcessForecastRequestFormComponentValuesDetails> getDetails() {
            return this.details;
        }

        public ProcessForecastRequestFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ProcessForecastRequestFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
