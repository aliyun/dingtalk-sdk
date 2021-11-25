// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SendInvitationRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public String deptId;

    // 伙伴编码
    @NameInMap("partnerNum")
    public String partnerNum;

    // 伙伴标签id
    @NameInMap("partnerLabelId")
    public Long partnerLabelId;

    // 手机号
    @NameInMap("phone")
    public String phone;

    // 组织别名
    @NameInMap("orgAlias")
    public String orgAlias;

    public static SendInvitationRequest build(java.util.Map<String, ?> map) throws Exception {
        SendInvitationRequest self = new SendInvitationRequest();
        return TeaModel.build(map, self);
    }

    public SendInvitationRequest setDeptId(String deptId) {
        this.deptId = deptId;
        return this;
    }
    public String getDeptId() {
        return this.deptId;
    }

    public SendInvitationRequest setPartnerNum(String partnerNum) {
        this.partnerNum = partnerNum;
        return this;
    }
    public String getPartnerNum() {
        return this.partnerNum;
    }

    public SendInvitationRequest setPartnerLabelId(Long partnerLabelId) {
        this.partnerLabelId = partnerLabelId;
        return this;
    }
    public Long getPartnerLabelId() {
        return this.partnerLabelId;
    }

    public SendInvitationRequest setPhone(String phone) {
        this.phone = phone;
        return this;
    }
    public String getPhone() {
        return this.phone;
    }

    public SendInvitationRequest setOrgAlias(String orgAlias) {
        this.orgAlias = orgAlias;
        return this;
    }
    public String getOrgAlias() {
        return this.orgAlias;
    }

}
