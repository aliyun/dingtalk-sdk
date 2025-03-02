// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class StartProcessInstanceRequest extends TeaModel {
    @NameInMap("approvers")
    public java.util.List<StartProcessInstanceRequestApprovers> approvers;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></p>
     */
    @NameInMap("bizDetailPageUrl")
    public String bizDetailPageUrl;

    @NameInMap("ccList")
    public java.util.List<String> ccList;

    /**
     * <strong>example:</strong>
     * <p>START、FINISH、START_FINISH</p>
     */
    @NameInMap("ccPosition")
    public String ccPosition;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formComponentValues")
    public java.util.List<StartProcessInstanceRequestFormComponentValues> formComponentValues;

    /**
     * <strong>example:</strong>
     * <p>41605932</p>
     */
    @NameInMap("microappAgentId")
    public Long microappAgentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager432</p>
     */
    @NameInMap("originatorUserId")
    public String originatorUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1</p>
     */
    @NameInMap("processCode")
    public String processCode;

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

    public StartProcessInstanceRequest setBizDetailPageUrl(String bizDetailPageUrl) {
        this.bizDetailPageUrl = bizDetailPageUrl;
        return this;
    }
    public String getBizDetailPageUrl() {
        return this.bizDetailPageUrl;
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
         * <strong>example:</strong>
         * <p>会签：AND；或签：OR；单人：NONE</p>
         */
        @NameInMap("actionType")
        public String actionType;

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
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        /**
         * <strong>example:</strong>
         * <p>总个数:1</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>PhoneField_IZI2LP8QF6O0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>PhoneField</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>123xxxxxxxx</p>
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
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("details")
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> details;

        /**
         * <strong>example:</strong>
         * <p>总个数:1</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>PhoneField_IZI2LP8QF6O0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>PhoneField</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>123xxxxxxxx</p>
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
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("details")
        public java.util.List<StartProcessInstanceRequestFormComponentValuesDetails> details;

        /**
         * <strong>example:</strong>
         * <p>总个数:1</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>PhoneField_IZI2LP8QF6O0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PhoneField</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123xxxxxxxx</p>
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
         * <strong>example:</strong>
         * <p>manual_1918_5cd3_5e19_6a98</p>
         */
        @NameInMap("actionerKey")
        public String actionerKey;

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
