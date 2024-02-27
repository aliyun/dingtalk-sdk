// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgConfigResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetMsgConfigResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetMsgConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMsgConfigResponseBody self = new GetMsgConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMsgConfigResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetMsgConfigResponseBody setData(GetMsgConfigResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetMsgConfigResponseBodyData getData() {
        return this.data;
    }

    public GetMsgConfigResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr extends TeaModel {
        @NameInMap("attrCode")
        public String attrCode;

        @NameInMap("listAttrOptionsCode")
        public java.util.List<String> listAttrOptionsCode;

        public static GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr self = new GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr setAttrCode(String attrCode) {
            this.attrCode = attrCode;
            return this;
        }
        public String getAttrCode() {
            return this.attrCode;
        }

        public GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr setListAttrOptionsCode(java.util.List<String> listAttrOptionsCode) {
            this.listAttrOptionsCode = listAttrOptionsCode;
            return this;
        }
        public java.util.List<String> getListAttrOptionsCode() {
            return this.listAttrOptionsCode;
        }

    }

    public static class GetMsgConfigResponseBodyDataGroupAttributesListReceiver extends TeaModel {
        @NameInMap("employeeCode")
        public String employeeCode;

        @NameInMap("employeeName")
        public String employeeName;

        public static GetMsgConfigResponseBodyDataGroupAttributesListReceiver build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigResponseBodyDataGroupAttributesListReceiver self = new GetMsgConfigResponseBodyDataGroupAttributesListReceiver();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigResponseBodyDataGroupAttributesListReceiver setEmployeeCode(String employeeCode) {
            this.employeeCode = employeeCode;
            return this;
        }
        public String getEmployeeCode() {
            return this.employeeCode;
        }

        public GetMsgConfigResponseBodyDataGroupAttributesListReceiver setEmployeeName(String employeeName) {
            this.employeeName = employeeName;
            return this;
        }
        public String getEmployeeName() {
            return this.employeeName;
        }

    }

    public static class GetMsgConfigResponseBodyDataGroupAttributes extends TeaModel {
        @NameInMap("configGroupId")
        public Long configGroupId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("groupTopic")
        public String groupTopic;

        @NameInMap("groupType")
        public String groupType;

        @NameInMap("listDynamicAttr")
        public java.util.List<GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr> listDynamicAttr;

        @NameInMap("listReceiver")
        public java.util.List<GetMsgConfigResponseBodyDataGroupAttributesListReceiver> listReceiver;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("ownerJobNo")
        public String ownerJobNo;

        @NameInMap("subRuleCode")
        public String subRuleCode;

        public static GetMsgConfigResponseBodyDataGroupAttributes build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigResponseBodyDataGroupAttributes self = new GetMsgConfigResponseBodyDataGroupAttributes();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setConfigGroupId(Long configGroupId) {
            this.configGroupId = configGroupId;
            return this;
        }
        public Long getConfigGroupId() {
            return this.configGroupId;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setGroupTopic(String groupTopic) {
            this.groupTopic = groupTopic;
            return this;
        }
        public String getGroupTopic() {
            return this.groupTopic;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setGroupType(String groupType) {
            this.groupType = groupType;
            return this;
        }
        public String getGroupType() {
            return this.groupType;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setListDynamicAttr(java.util.List<GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr> listDynamicAttr) {
            this.listDynamicAttr = listDynamicAttr;
            return this;
        }
        public java.util.List<GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr> getListDynamicAttr() {
            return this.listDynamicAttr;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setListReceiver(java.util.List<GetMsgConfigResponseBodyDataGroupAttributesListReceiver> listReceiver) {
            this.listReceiver = listReceiver;
            return this;
        }
        public java.util.List<GetMsgConfigResponseBodyDataGroupAttributesListReceiver> getListReceiver() {
            return this.listReceiver;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setOwnerJobNo(String ownerJobNo) {
            this.ownerJobNo = ownerJobNo;
            return this;
        }
        public String getOwnerJobNo() {
            return this.ownerJobNo;
        }

        public GetMsgConfigResponseBodyDataGroupAttributes setSubRuleCode(String subRuleCode) {
            this.subRuleCode = subRuleCode;
            return this;
        }
        public String getSubRuleCode() {
            return this.subRuleCode;
        }

    }

    public static class GetMsgConfigResponseBodyDataMsgConfigs extends TeaModel {
        @NameInMap("cardId")
        public String cardId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("customParameters")
        public String customParameters;

        @NameInMap("msgContentConsisFlag")
        public Integer msgContentConsisFlag;

        @NameInMap("msgId")
        public String msgId;

        @NameInMap("robotCode")
        public String robotCode;

        @NameInMap("ruleBusinessCode")
        public String ruleBusinessCode;

        @NameInMap("ruleCategory")
        public Integer ruleCategory;

        @NameInMap("ruleCode")
        public String ruleCode;

        @NameInMap("ruleName")
        public String ruleName;

        @NameInMap("subRuleCode")
        public String subRuleCode;

        @NameInMap("systemCode")
        public String systemCode;

        @NameInMap("taskBatchNo")
        public String taskBatchNo;

        public static GetMsgConfigResponseBodyDataMsgConfigs build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigResponseBodyDataMsgConfigs self = new GetMsgConfigResponseBodyDataMsgConfigs();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setCardId(String cardId) {
            this.cardId = cardId;
            return this;
        }
        public String getCardId() {
            return this.cardId;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setCustomParameters(String customParameters) {
            this.customParameters = customParameters;
            return this;
        }
        public String getCustomParameters() {
            return this.customParameters;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setMsgContentConsisFlag(Integer msgContentConsisFlag) {
            this.msgContentConsisFlag = msgContentConsisFlag;
            return this;
        }
        public Integer getMsgContentConsisFlag() {
            return this.msgContentConsisFlag;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setMsgId(String msgId) {
            this.msgId = msgId;
            return this;
        }
        public String getMsgId() {
            return this.msgId;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setRuleBusinessCode(String ruleBusinessCode) {
            this.ruleBusinessCode = ruleBusinessCode;
            return this;
        }
        public String getRuleBusinessCode() {
            return this.ruleBusinessCode;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setRuleCategory(Integer ruleCategory) {
            this.ruleCategory = ruleCategory;
            return this;
        }
        public Integer getRuleCategory() {
            return this.ruleCategory;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setRuleCode(String ruleCode) {
            this.ruleCode = ruleCode;
            return this;
        }
        public String getRuleCode() {
            return this.ruleCode;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setRuleName(String ruleName) {
            this.ruleName = ruleName;
            return this;
        }
        public String getRuleName() {
            return this.ruleName;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setSubRuleCode(String subRuleCode) {
            this.subRuleCode = subRuleCode;
            return this;
        }
        public String getSubRuleCode() {
            return this.subRuleCode;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setSystemCode(String systemCode) {
            this.systemCode = systemCode;
            return this;
        }
        public String getSystemCode() {
            return this.systemCode;
        }

        public GetMsgConfigResponseBodyDataMsgConfigs setTaskBatchNo(String taskBatchNo) {
            this.taskBatchNo = taskBatchNo;
            return this;
        }
        public String getTaskBatchNo() {
            return this.taskBatchNo;
        }

    }

    public static class GetMsgConfigResponseBodyDataReceiverAttributes extends TeaModel {
        @NameInMap("employeeCode")
        public String employeeCode;

        public static GetMsgConfigResponseBodyDataReceiverAttributes build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigResponseBodyDataReceiverAttributes self = new GetMsgConfigResponseBodyDataReceiverAttributes();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigResponseBodyDataReceiverAttributes setEmployeeCode(String employeeCode) {
            this.employeeCode = employeeCode;
            return this;
        }
        public String getEmployeeCode() {
            return this.employeeCode;
        }

    }

    public static class GetMsgConfigResponseBodyDataUnitAttributes extends TeaModel {
        @NameInMap("unitId")
        public Long unitId;

        public static GetMsgConfigResponseBodyDataUnitAttributes build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigResponseBodyDataUnitAttributes self = new GetMsgConfigResponseBodyDataUnitAttributes();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigResponseBodyDataUnitAttributes setUnitId(Long unitId) {
            this.unitId = unitId;
            return this;
        }
        public Long getUnitId() {
            return this.unitId;
        }

    }

    public static class GetMsgConfigResponseBodyData extends TeaModel {
        @NameInMap("groupAttributes")
        public java.util.List<GetMsgConfigResponseBodyDataGroupAttributes> groupAttributes;

        @NameInMap("msgConfigs")
        public GetMsgConfigResponseBodyDataMsgConfigs msgConfigs;

        @NameInMap("receiverAttributes")
        public java.util.List<GetMsgConfigResponseBodyDataReceiverAttributes> receiverAttributes;

        @NameInMap("unitAttributes")
        public java.util.List<GetMsgConfigResponseBodyDataUnitAttributes> unitAttributes;

        public static GetMsgConfigResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigResponseBodyData self = new GetMsgConfigResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigResponseBodyData setGroupAttributes(java.util.List<GetMsgConfigResponseBodyDataGroupAttributes> groupAttributes) {
            this.groupAttributes = groupAttributes;
            return this;
        }
        public java.util.List<GetMsgConfigResponseBodyDataGroupAttributes> getGroupAttributes() {
            return this.groupAttributes;
        }

        public GetMsgConfigResponseBodyData setMsgConfigs(GetMsgConfigResponseBodyDataMsgConfigs msgConfigs) {
            this.msgConfigs = msgConfigs;
            return this;
        }
        public GetMsgConfigResponseBodyDataMsgConfigs getMsgConfigs() {
            return this.msgConfigs;
        }

        public GetMsgConfigResponseBodyData setReceiverAttributes(java.util.List<GetMsgConfigResponseBodyDataReceiverAttributes> receiverAttributes) {
            this.receiverAttributes = receiverAttributes;
            return this;
        }
        public java.util.List<GetMsgConfigResponseBodyDataReceiverAttributes> getReceiverAttributes() {
            return this.receiverAttributes;
        }

        public GetMsgConfigResponseBodyData setUnitAttributes(java.util.List<GetMsgConfigResponseBodyDataUnitAttributes> unitAttributes) {
            this.unitAttributes = unitAttributes;
            return this;
        }
        public java.util.List<GetMsgConfigResponseBodyDataUnitAttributes> getUnitAttributes() {
            return this.unitAttributes;
        }

    }

}
