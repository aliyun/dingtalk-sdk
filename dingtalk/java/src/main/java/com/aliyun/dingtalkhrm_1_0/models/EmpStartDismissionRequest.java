// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EmpStartDismissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("lastWorkDate")
    public Long lastWorkDate;

    @NameInMap("partner")
    public Boolean partner;

    @NameInMap("remark")
    public String remark;

    @NameInMap("terminationReasonPassive")
    public java.util.List<String> terminationReasonPassive;

    @NameInMap("terminationReasonVoluntary")
    public java.util.List<String> terminationReasonVoluntary;

    @NameInMap("toHireBlackList")
    public Boolean toHireBlackList;

    @NameInMap("toHireDismissionTalent")
    public Boolean toHireDismissionTalent;

    @NameInMap("toHrmBlackList")
    public Boolean toHrmBlackList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2163515669935611</p>
     */
    @NameInMap("userId")
    public String userId;

    public static EmpStartDismissionRequest build(java.util.Map<String, ?> map) throws Exception {
        EmpStartDismissionRequest self = new EmpStartDismissionRequest();
        return TeaModel.build(map, self);
    }

    public EmpStartDismissionRequest setLastWorkDate(Long lastWorkDate) {
        this.lastWorkDate = lastWorkDate;
        return this;
    }
    public Long getLastWorkDate() {
        return this.lastWorkDate;
    }

    public EmpStartDismissionRequest setPartner(Boolean partner) {
        this.partner = partner;
        return this;
    }
    public Boolean getPartner() {
        return this.partner;
    }

    public EmpStartDismissionRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public EmpStartDismissionRequest setTerminationReasonPassive(java.util.List<String> terminationReasonPassive) {
        this.terminationReasonPassive = terminationReasonPassive;
        return this;
    }
    public java.util.List<String> getTerminationReasonPassive() {
        return this.terminationReasonPassive;
    }

    public EmpStartDismissionRequest setTerminationReasonVoluntary(java.util.List<String> terminationReasonVoluntary) {
        this.terminationReasonVoluntary = terminationReasonVoluntary;
        return this;
    }
    public java.util.List<String> getTerminationReasonVoluntary() {
        return this.terminationReasonVoluntary;
    }

    public EmpStartDismissionRequest setToHireBlackList(Boolean toHireBlackList) {
        this.toHireBlackList = toHireBlackList;
        return this;
    }
    public Boolean getToHireBlackList() {
        return this.toHireBlackList;
    }

    public EmpStartDismissionRequest setToHireDismissionTalent(Boolean toHireDismissionTalent) {
        this.toHireDismissionTalent = toHireDismissionTalent;
        return this;
    }
    public Boolean getToHireDismissionTalent() {
        return this.toHireDismissionTalent;
    }

    public EmpStartDismissionRequest setToHrmBlackList(Boolean toHrmBlackList) {
        this.toHrmBlackList = toHrmBlackList;
        return this;
    }
    public Boolean getToHrmBlackList() {
        return this.toHrmBlackList;
    }

    public EmpStartDismissionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
