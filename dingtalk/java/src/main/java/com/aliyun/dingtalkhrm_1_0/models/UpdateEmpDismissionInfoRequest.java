// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpDismissionInfoRequest extends TeaModel {
    @NameInMap("dismissionMemo")
    public String dismissionMemo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("lastWorkDate")
    public Long lastWorkDate;

    @NameInMap("partner")
    public Boolean partner;

    @NameInMap("terminationReasonPassive")
    public java.util.List<String> terminationReasonPassive;

    @NameInMap("terminationReasonVoluntary")
    public java.util.List<String> terminationReasonVoluntary;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2163515669935611</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateEmpDismissionInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpDismissionInfoRequest self = new UpdateEmpDismissionInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateEmpDismissionInfoRequest setDismissionMemo(String dismissionMemo) {
        this.dismissionMemo = dismissionMemo;
        return this;
    }
    public String getDismissionMemo() {
        return this.dismissionMemo;
    }

    public UpdateEmpDismissionInfoRequest setLastWorkDate(Long lastWorkDate) {
        this.lastWorkDate = lastWorkDate;
        return this;
    }
    public Long getLastWorkDate() {
        return this.lastWorkDate;
    }

    public UpdateEmpDismissionInfoRequest setPartner(Boolean partner) {
        this.partner = partner;
        return this;
    }
    public Boolean getPartner() {
        return this.partner;
    }

    public UpdateEmpDismissionInfoRequest setTerminationReasonPassive(java.util.List<String> terminationReasonPassive) {
        this.terminationReasonPassive = terminationReasonPassive;
        return this;
    }
    public java.util.List<String> getTerminationReasonPassive() {
        return this.terminationReasonPassive;
    }

    public UpdateEmpDismissionInfoRequest setTerminationReasonVoluntary(java.util.List<String> terminationReasonVoluntary) {
        this.terminationReasonVoluntary = terminationReasonVoluntary;
        return this;
    }
    public java.util.List<String> getTerminationReasonVoluntary() {
        return this.terminationReasonVoluntary;
    }

    public UpdateEmpDismissionInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
