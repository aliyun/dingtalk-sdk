// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class DeductionPointBatchRequest extends TeaModel {
    // 扣减数量 范围：1—100000
    @NameInMap("deductionAmount")
    public Long deductionAmount;

    // 扣减积分原因
    @NameInMap("remark")
    public String remark;

    // 是否发送组织文化通知
    @NameInMap("sendOrgCultureInform")
    public Boolean sendOrgCultureInform;

    // 批量扣减积分用户
    @NameInMap("targetUserList")
    public java.util.List<DeductionPointBatchRequestTargetUserList> targetUserList;

    // 操作人userId
    @NameInMap("userId")
    public String userId;

    public static DeductionPointBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        DeductionPointBatchRequest self = new DeductionPointBatchRequest();
        return TeaModel.build(map, self);
    }

    public DeductionPointBatchRequest setDeductionAmount(Long deductionAmount) {
        this.deductionAmount = deductionAmount;
        return this;
    }
    public Long getDeductionAmount() {
        return this.deductionAmount;
    }

    public DeductionPointBatchRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public DeductionPointBatchRequest setSendOrgCultureInform(Boolean sendOrgCultureInform) {
        this.sendOrgCultureInform = sendOrgCultureInform;
        return this;
    }
    public Boolean getSendOrgCultureInform() {
        return this.sendOrgCultureInform;
    }

    public DeductionPointBatchRequest setTargetUserList(java.util.List<DeductionPointBatchRequestTargetUserList> targetUserList) {
        this.targetUserList = targetUserList;
        return this;
    }
    public java.util.List<DeductionPointBatchRequestTargetUserList> getTargetUserList() {
        return this.targetUserList;
    }

    public DeductionPointBatchRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class DeductionPointBatchRequestTargetUserList extends TeaModel {
        // 积分交易单号
        @NameInMap("outId")
        public String outId;

        // 扣减目标用户userId
        @NameInMap("targetUserId")
        public String targetUserId;

        public static DeductionPointBatchRequestTargetUserList build(java.util.Map<String, ?> map) throws Exception {
            DeductionPointBatchRequestTargetUserList self = new DeductionPointBatchRequestTargetUserList();
            return TeaModel.build(map, self);
        }

        public DeductionPointBatchRequestTargetUserList setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

        public DeductionPointBatchRequestTargetUserList setTargetUserId(String targetUserId) {
            this.targetUserId = targetUserId;
            return this;
        }
        public String getTargetUserId() {
            return this.targetUserId;
        }

    }

}
