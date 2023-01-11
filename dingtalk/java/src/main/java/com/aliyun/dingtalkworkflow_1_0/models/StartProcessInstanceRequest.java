// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class StartProcessInstanceRequest extends TeaModel {
    /**
     * <p>不使用审批流模板时，直接指定审批人列表</p>
     */
    @NameInMap("approvers")
    public java.util.List<StartProcessInstanceRequestApprovers> approvers;

    /**
     * <p>抄送人userId列表</p>
     */
    @NameInMap("ccList")
    public java.util.List<String> ccList;

    /**
     * <p>抄送时间</p>
     */
    @NameInMap("ccPosition")
    public String ccPosition;

    /**
     * <p>部门ID</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>表单数据内容，控件列表</p>
     */
    @NameInMap("formComponentValues")
    public java.util.List<StartProcessInstanceRequestFormComponentValues> formComponentValues;

    /**
     * <p>企业微应用标识</p>
     */
    @NameInMap("microappAgentId")
    public Long microappAgentId;

    /**
     * <p>审批发起人的userId</p>
     */
    @NameInMap("originatorUserId")
    public String originatorUserId;

    /**
     * <p>审批流的唯一码</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>使用审批流模板时，模板上的自选操作人列表</p>
     */
    @NameInMap("targetSelectActioners")
    public java.util.List<StartProcessInstanceRequestTargetSelectActioners> targetSelectActioners;

    public static StartProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        StartProcessInstanceRequest self = new StartProcessInstanceRequest();
        return TeaModel.build(map, self);
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

    public StartProcessInstanceRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public StartProcessInstanceRequest setFormComponentValues(java.util.List<StartProcessInstanceRequestFormComponentValues> formComponentValues) {
        this.formComponentValues = formComponentValues;
        return this;
    }
    public java.util.List<StartProcessInstanceRequestFormComponentValues> getFormComponentValues() {
        return this.formComponentValues;
    }

    public StartProcessInstanceRequest setMicroappAgentId(Long microappAgentId) {
        this.microappAgentId = microappAgentId;
        return this;
    }
    public Long getMicroappAgentId() {
        return this.microappAgentId;
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

    public StartProcessInstanceRequest setTargetSelectActioners(java.util.List<StartProcessInstanceRequestTargetSelectActioners> targetSelectActioners) {
        this.targetSelectActioners = targetSelectActioners;
        return this;
    }
    public java.util.List<StartProcessInstanceRequestTargetSelectActioners> getTargetSelectActioners() {
        return this.targetSelectActioners;
    }

    public static class StartProcessInstanceRequestApprovers extends TeaModel {
        /**
         * <p>审批类型</p>
         */
        @NameInMap("actionType")
        public String actionType;

        /**
         * <p>审批人列表</p>
         */
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

    public static class StartProcessInstanceRequestFormComponentValuesDetailsDetails extends TeaModel {
        /**
         * <p>控件别名</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>控件类型</p>
         */
        @NameInMap("componentType")
        public String componentType;

        /**
         * <p>控件扩展值</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <p>控件id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>控件名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>控件值</p>
         */
        @NameInMap("value")
        public String value;

        public static StartProcessInstanceRequestFormComponentValuesDetailsDetails build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestFormComponentValuesDetailsDetails self = new StartProcessInstanceRequestFormComponentValuesDetailsDetails();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public StartProcessInstanceRequestFormComponentValuesDetailsDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
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

    }

    public static class StartProcessInstanceRequestFormComponentValuesDetails extends TeaModel {
        /**
         * <p>控件别名</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("details")
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> details;

        /**
         * <p>控件扩展值</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <p>控件id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>控件名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>控件值</p>
         */
        @NameInMap("value")
        public String value;

        public static StartProcessInstanceRequestFormComponentValuesDetails build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestFormComponentValuesDetails self = new StartProcessInstanceRequestFormComponentValuesDetails();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setDetails(java.util.List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> getDetails() {
            return this.details;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public StartProcessInstanceRequestFormComponentValuesDetails setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
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

    }

    public static class StartProcessInstanceRequestFormComponentValues extends TeaModel {
        /**
         * <p>控件别名</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>控件类型</p>
         */
        @NameInMap("componentType")
        public String componentType;

        @NameInMap("details")
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetails> details;

        /**
         * <p>控件扩展值</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <p>控件id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>控件名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>控件值</p>
         */
        @NameInMap("value")
        public String value;

        public static StartProcessInstanceRequestFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            StartProcessInstanceRequestFormComponentValues self = new StartProcessInstanceRequestFormComponentValues();
            return TeaModel.build(map, self);
        }

        public StartProcessInstanceRequestFormComponentValues setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
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

        public StartProcessInstanceRequestFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public StartProcessInstanceRequestFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
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

    }

    public static class StartProcessInstanceRequestTargetSelectActioners extends TeaModel {
        /**
         * <p>自选节点的规则key</p>
         */
        @NameInMap("actionerKey")
        public String actionerKey;

        /**
         * <p>操作人userId列表</p>
         */
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

}
