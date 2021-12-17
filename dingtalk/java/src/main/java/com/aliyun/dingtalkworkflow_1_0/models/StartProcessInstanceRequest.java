// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class StartProcessInstanceRequest extends TeaModel {
    // 审批发起人的userId
    @NameInMap("originatorUserId")
    public String originatorUserId;

    // 审批流的唯一码
    @NameInMap("processCode")
    public String processCode;

    // 部门ID
    @NameInMap("deptId")
    public Long deptId;

    // 企业微应用标识
    @NameInMap("microappAgentId")
    public Long microappAgentId;

    // 不使用审批流模板时，直接指定审批人列表
    @NameInMap("approvers")
    public java.util.List<StartProcessInstanceRequestApprovers> approvers;

    // 抄送人userId列表
    @NameInMap("ccList")
    public java.util.List<String> ccList;

    // 抄送时间
    @NameInMap("ccPosition")
    public String ccPosition;

    // 使用审批流模板时，模板上的自选操作人列表
    @NameInMap("targetSelectActioners")
    public java.util.List<StartProcessInstanceRequestTargetSelectActioners> targetSelectActioners;

    // 表单数据内容，控件列表
    @NameInMap("formComponentValues")
    public java.util.List<StartProcessInstanceRequestFormComponentValues> formComponentValues;

    @NameInMap("RequestId")
    public String requestId;

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

    public static StartProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        StartProcessInstanceRequest self = new StartProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public StartProcessInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public StartProcessInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public StartProcessInstanceRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public StartProcessInstanceRequest setMicroappAgentId(Long microappAgentId) {
        this.microappAgentId = microappAgentId;
        return this;
    }
    public Long getMicroappAgentId() {
        return this.microappAgentId;
    }

    public StartProcessInstanceRequest setApprovers(java.util.List<StartProcessInstanceRequestApprovers> approvers) {
        this.approvers = approvers;
        return this;
    }
    public java.util.List<StartProcessInstanceRequestApprovers> getApprovers() {
        return this.approvers;
    }

    public StartProcessInstanceRequest setCcList(java.util.List<String> ccList) {
        this.ccList = ccList;
        return this;
    }
    public java.util.List<String> getCcList() {
        return this.ccList;
    }

    public StartProcessInstanceRequest setCcPosition(String ccPosition) {
        this.ccPosition = ccPosition;
        return this;
    }
    public String getCcPosition() {
        return this.ccPosition;
    }

    public StartProcessInstanceRequest setTargetSelectActioners(java.util.List<StartProcessInstanceRequestTargetSelectActioners> targetSelectActioners) {
        this.targetSelectActioners = targetSelectActioners;
        return this;
    }
    public java.util.List<StartProcessInstanceRequestTargetSelectActioners> getTargetSelectActioners() {
        return this.targetSelectActioners;
    }

    public StartProcessInstanceRequest setFormComponentValues(java.util.List<StartProcessInstanceRequestFormComponentValues> formComponentValues) {
        this.formComponentValues = formComponentValues;
        return this;
    }
    public java.util.List<StartProcessInstanceRequestFormComponentValues> getFormComponentValues() {
        return this.formComponentValues;
    }

    public StartProcessInstanceRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public StartProcessInstanceRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public StartProcessInstanceRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public StartProcessInstanceRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public StartProcessInstanceRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public StartProcessInstanceRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public static class StartProcessInstanceRequestApprovers extends TeaModel {
        // 审批类型
        @NameInMap("actionType")
        public String actionType;

        // 审批人列表
        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static StartProcessInstanceRequestApprovers build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestApprovers self = new StartProcessInstanceRequestApprovers();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestApprovers setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public StartProcessInstanceRequestApprovers setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

    public static class StartProcessInstanceRequestTargetSelectActioners extends TeaModel {
        // 自选节点的规则key
        @NameInMap("actionerKey")
        public String actionerKey;

        // 操作人userId列表
        @NameInMap("actionerUserIds")
        public java.util.List<String> actionerUserIds;

        public static StartProcessInstanceRequestTargetSelectActioners build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestTargetSelectActioners self = new StartProcessInstanceRequestTargetSelectActioners();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestTargetSelectActioners setActionerKey(String actionerKey) {
            this.actionerKey = actionerKey;
            return this;
        }
        public String getActionerKey() {
            return this.actionerKey;
        }

        public StartProcessInstanceRequestTargetSelectActioners setActionerUserIds(java.util.List<String> actionerUserIds) {
            this.actionerUserIds = actionerUserIds;
            return this;
        }
        public java.util.List<String> getActionerUserIds() {
            return this.actionerUserIds;
        }

    }

    public static class StartProcessInstanceRequestFormComponentValuesDetailsDetails extends TeaModel {
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

        public static StartProcessInstanceRequestFormComponentValuesDetailsDetails build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestFormComponentValuesDetailsDetails self = new StartProcessInstanceRequestFormComponentValuesDetailsDetails();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

    }

    public static class StartProcessInstanceRequestFormComponentValuesDetails extends TeaModel {
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
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> details;

        public static StartProcessInstanceRequestFormComponentValuesDetails build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestFormComponentValuesDetails self = new StartProcessInstanceRequestFormComponentValuesDetails();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setDetails(java.util.List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> getDetails() {
            return this.details;
        }

    }

    public static class StartProcessInstanceRequestFormComponentValues extends TeaModel {
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
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetails> details;

        public static StartProcessInstanceRequestFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestFormComponentValues self = new StartProcessInstanceRequestFormComponentValues();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public StartProcessInstanceRequestFormComponentValues setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public StartProcessInstanceRequestFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public StartProcessInstanceRequestFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public StartProcessInstanceRequestFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public StartProcessInstanceRequestFormComponentValues setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public StartProcessInstanceRequestFormComponentValues setDetails(java.util.List<StartProcessInstanceRequestFormComponentValuesDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetails> getDetails() {
            return this.details;
        }

    }

}
