// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class AssignOrgHoldingToEmpHoldingBatchRequest extends TeaModel {
    // 备注信息 长度小于40
    @NameInMap("remark")
    public String remark;

    // 是否发送组织文化通知
    @NameInMap("sendOrgCultureInform")
    public Boolean sendOrgCultureInform;

    // 发放积分或额度数量 1～100000
    @NameInMap("singleAmount")
    public Long singleAmount;

    // 发放人sourceUsage  发放人与接受人usage应一一对应
    // 发放积分sourceUsage：OPEN_ORG_POINT_PERSONAL_ASSIGN 对应的targetUsage为OPEN_EMP_POINT_PERSONAL_RECEIVE；
    // 发额度sourceUsage：OPEN_ORG_POINT_HOLDING_ASSIGN 对应的 targetUsage为OPEN_EMP_POINT_HOLDING_RECEIVE；
    // 行为规则发积分 sourceUsage：OPEN_ACTION_RULE_PERSONAL_ASSIGN 对应的 targetUsage为OPEN_ACTION_RULE_PERSONAL_RECEIVE
    @NameInMap("sourceUsage")
    public String sourceUsage;

    // 接受人targetUsage  发放人与接受人usage应一一对应
    @NameInMap("targetUsage")
    public String targetUsage;

    // 发放目标用户
    @NameInMap("targetUserList")
    public java.util.List<AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList> targetUserList;

    public static AssignOrgHoldingToEmpHoldingBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        AssignOrgHoldingToEmpHoldingBatchRequest self = new AssignOrgHoldingToEmpHoldingBatchRequest();
        return TeaModel.build(map, self);
    }

    public AssignOrgHoldingToEmpHoldingBatchRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public AssignOrgHoldingToEmpHoldingBatchRequest setSendOrgCultureInform(Boolean sendOrgCultureInform) {
        this.sendOrgCultureInform = sendOrgCultureInform;
        return this;
    }
    public Boolean getSendOrgCultureInform() {
        return this.sendOrgCultureInform;
    }

    public AssignOrgHoldingToEmpHoldingBatchRequest setSingleAmount(Long singleAmount) {
        this.singleAmount = singleAmount;
        return this;
    }
    public Long getSingleAmount() {
        return this.singleAmount;
    }

    public AssignOrgHoldingToEmpHoldingBatchRequest setSourceUsage(String sourceUsage) {
        this.sourceUsage = sourceUsage;
        return this;
    }
    public String getSourceUsage() {
        return this.sourceUsage;
    }

    public AssignOrgHoldingToEmpHoldingBatchRequest setTargetUsage(String targetUsage) {
        this.targetUsage = targetUsage;
        return this;
    }
    public String getTargetUsage() {
        return this.targetUsage;
    }

    public AssignOrgHoldingToEmpHoldingBatchRequest setTargetUserList(java.util.List<AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList> targetUserList) {
        this.targetUserList = targetUserList;
        return this;
    }
    public java.util.List<AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList> getTargetUserList() {
        return this.targetUserList;
    }

    public static class AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList extends TeaModel {
        // 积分交易单号，长度1-32。
        // 
        @NameInMap("outId")
        public String outId;

        // 操作目标对象userId
        @NameInMap("targetUserId")
        public String targetUserId;

        public static AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList build(java.util.Map<String, ?> map) throws Exception {
            AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList self = new AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList();
            return TeaModel.build(map, self);
        }

        public AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

        public AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList setTargetUserId(String targetUserId) {
            this.targetUserId = targetUserId;
            return this;
        }
        public String getTargetUserId() {
            return this.targetUserId;
        }

    }

}
