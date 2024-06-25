// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class AssignOrgHoldingToEmpHoldingBatchRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>表现优秀，特此奖励</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("sendOrgCultureInform")
    public Boolean sendOrgCultureInform;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("singleAmount")
    public Long singleAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OPEN_ORG_POINT_PERSONAL_ASSIGN</p>
     */
    @NameInMap("sourceUsage")
    public String sourceUsage;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OPEN_EMP_POINT_PERSONAL_RECEIVE</p>
     */
    @NameInMap("targetUsage")
    public String targetUsage;

    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>4353453454241</p>
         */
        @NameInMap("outId")
        public String outId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>551341216920908910</p>
         */
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
