// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ProcessForecastRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("RequestId")
    public String requestId;

    // 审批流的唯一码
    @NameInMap("processCode")
    public String processCode;

    // 部门ID
    @NameInMap("deptId")
    public Integer deptId;

    // 审批发起人的userId
    @NameInMap("userId")
    public String userId;

    // 表单数据内容，控件列表
    @NameInMap("formComponentValues")
    public java.util.List<ProcessForecastRequestFormComponentValues> formComponentValues;

    public static ProcessForecastRequest build(java.util.Map<String, ?> map) throws Exception {
        ProcessForecastRequest self = new ProcessForecastRequest();
        return TeaModel.build(map, self);
    }

    public ProcessForecastRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public ProcessForecastRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public ProcessForecastRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public ProcessForecastRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public ProcessForecastRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public ProcessForecastRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ProcessForecastRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public ProcessForecastRequest setDeptId(Integer deptId) {
        this.deptId = deptId;
        return this;
    }
    public Integer getDeptId() {
        return this.deptId;
    }

    public ProcessForecastRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public ProcessForecastRequest setFormComponentValues(java.util.List<ProcessForecastRequestFormComponentValues> formComponentValues) {
        this.formComponentValues = formComponentValues;
        return this;
    }
    public java.util.List<ProcessForecastRequestFormComponentValues> getFormComponentValues() {
        return this.formComponentValues;
    }

    public static class ProcessForecastRequestFormComponentValuesDetailsDetails extends TeaModel {
        // 控件id
        @NameInMap("id")
        public String id;

        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 控件名称
        @NameInMap("name")
        public String name;

        // 控件值
        @NameInMap("value")
        public String value;

        // 控件扩展值
        @NameInMap("extValue")
        public String extValue;

        @NameInMap("componentType")
        public String componentType;

        public static ProcessForecastRequestFormComponentValuesDetailsDetails build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValuesDetailsDetails self = new ProcessForecastRequestFormComponentValuesDetailsDetails();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
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

        public ProcessForecastRequestFormComponentValuesDetailsDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValuesDetailsDetails setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

    }

    public static class ProcessForecastRequestFormComponentValuesDetails extends TeaModel {
        // 控件id
        @NameInMap("id")
        public String id;

        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 控件名称
        @NameInMap("name")
        public String name;

        // 控件值
        @NameInMap("value")
        public String value;

        // 控件扩展值
        @NameInMap("extValue")
        public String extValue;

        @NameInMap("details")
        public java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> details;

        public static ProcessForecastRequestFormComponentValuesDetails build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValuesDetails self = new ProcessForecastRequestFormComponentValuesDetails();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValuesDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValuesDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
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

        public ProcessForecastRequestFormComponentValuesDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public ProcessForecastRequestFormComponentValuesDetails setDetails(java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<ProcessForecastRequestFormComponentValuesDetailsDetails> getDetails() {
            return this.details;
        }

    }

    public static class ProcessForecastRequestFormComponentValues extends TeaModel {
        // 控件id
        @NameInMap("id")
        public String id;

        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 控件名称
        @NameInMap("name")
        public String name;

        // 控件值
        @NameInMap("value")
        public String value;

        // 控件扩展值
        @NameInMap("extValue")
        public String extValue;

        // 控件类型
        @NameInMap("componentType")
        public String componentType;

        @NameInMap("details")
        public java.util.List<ProcessForecastRequestFormComponentValuesDetails> details;

        public static ProcessForecastRequestFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastRequestFormComponentValues self = new ProcessForecastRequestFormComponentValues();
            return TeaModel.build(map, self);
        }

        public ProcessForecastRequestFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ProcessForecastRequestFormComponentValues setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
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

        public ProcessForecastRequestFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
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

    }

}
