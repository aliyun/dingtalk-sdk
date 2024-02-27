// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgConfigRequest extends TeaModel {
    @NameInMap("groupTopic")
    public String groupTopic;

    @NameInMap("groupType")
    public String groupType;

    @NameInMap("listDynamicAttr")
    public java.util.List<GetMsgConfigRequestListDynamicAttr> listDynamicAttr;

    @NameInMap("listEmployeeCode")
    public java.util.List<String> listEmployeeCode;

    @NameInMap("listUnitId")
    public java.util.List<Long> listUnitId;

    @NameInMap("ownerJobNo")
    public String ownerJobNo;

    @NameInMap("ruleBusinessCode")
    public String ruleBusinessCode;

    @NameInMap("ruleCategory")
    public Integer ruleCategory;

    @NameInMap("ruleCode")
    public String ruleCode;

    @NameInMap("secretKey")
    public String secretKey;

    @NameInMap("sysCode")
    public String sysCode;

    public static GetMsgConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMsgConfigRequest self = new GetMsgConfigRequest();
        return TeaModel.build(map, self);
    }

    public GetMsgConfigRequest setGroupTopic(String groupTopic) {
        this.groupTopic = groupTopic;
        return this;
    }
    public String getGroupTopic() {
        return this.groupTopic;
    }

    public GetMsgConfigRequest setGroupType(String groupType) {
        this.groupType = groupType;
        return this;
    }
    public String getGroupType() {
        return this.groupType;
    }

    public GetMsgConfigRequest setListDynamicAttr(java.util.List<GetMsgConfigRequestListDynamicAttr> listDynamicAttr) {
        this.listDynamicAttr = listDynamicAttr;
        return this;
    }
    public java.util.List<GetMsgConfigRequestListDynamicAttr> getListDynamicAttr() {
        return this.listDynamicAttr;
    }

    public GetMsgConfigRequest setListEmployeeCode(java.util.List<String> listEmployeeCode) {
        this.listEmployeeCode = listEmployeeCode;
        return this;
    }
    public java.util.List<String> getListEmployeeCode() {
        return this.listEmployeeCode;
    }

    public GetMsgConfigRequest setListUnitId(java.util.List<Long> listUnitId) {
        this.listUnitId = listUnitId;
        return this;
    }
    public java.util.List<Long> getListUnitId() {
        return this.listUnitId;
    }

    public GetMsgConfigRequest setOwnerJobNo(String ownerJobNo) {
        this.ownerJobNo = ownerJobNo;
        return this;
    }
    public String getOwnerJobNo() {
        return this.ownerJobNo;
    }

    public GetMsgConfigRequest setRuleBusinessCode(String ruleBusinessCode) {
        this.ruleBusinessCode = ruleBusinessCode;
        return this;
    }
    public String getRuleBusinessCode() {
        return this.ruleBusinessCode;
    }

    public GetMsgConfigRequest setRuleCategory(Integer ruleCategory) {
        this.ruleCategory = ruleCategory;
        return this;
    }
    public Integer getRuleCategory() {
        return this.ruleCategory;
    }

    public GetMsgConfigRequest setRuleCode(String ruleCode) {
        this.ruleCode = ruleCode;
        return this;
    }
    public String getRuleCode() {
        return this.ruleCode;
    }

    public GetMsgConfigRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public GetMsgConfigRequest setSysCode(String sysCode) {
        this.sysCode = sysCode;
        return this;
    }
    public String getSysCode() {
        return this.sysCode;
    }

    public static class GetMsgConfigRequestListDynamicAttr extends TeaModel {
        @NameInMap("attrCode")
        public String attrCode;

        @NameInMap("listAttrOptionsCode")
        public java.util.List<String> listAttrOptionsCode;

        public static GetMsgConfigRequestListDynamicAttr build(java.util.Map<String, ?> map) throws Exception {
            GetMsgConfigRequestListDynamicAttr self = new GetMsgConfigRequestListDynamicAttr();
            return TeaModel.build(map, self);
        }

        public GetMsgConfigRequestListDynamicAttr setAttrCode(String attrCode) {
            this.attrCode = attrCode;
            return this;
        }
        public String getAttrCode() {
            return this.attrCode;
        }

        public GetMsgConfigRequestListDynamicAttr setListAttrOptionsCode(java.util.List<String> listAttrOptionsCode) {
            this.listAttrOptionsCode = listAttrOptionsCode;
            return this;
        }
        public java.util.List<String> getListAttrOptionsCode() {
            return this.listAttrOptionsCode;
        }

    }

}
