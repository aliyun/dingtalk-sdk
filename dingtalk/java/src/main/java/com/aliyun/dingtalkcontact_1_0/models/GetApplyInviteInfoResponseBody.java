// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetApplyInviteInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("auditType")
    public Long auditType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("empApplyJoinDept")
    public Boolean empApplyJoinDept;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("inviteSwitch")
    public Boolean inviteSwitch;

    @NameInMap("inviteUrl")
    public String inviteUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("linkInvite")
    public Boolean linkInvite;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orgApplyCodeInvite")
    public Boolean orgApplyCodeInvite;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("searchNameInvite")
    public Boolean searchNameInvite;

    public static GetApplyInviteInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetApplyInviteInfoResponseBody self = new GetApplyInviteInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetApplyInviteInfoResponseBody setAuditType(Long auditType) {
        this.auditType = auditType;
        return this;
    }
    public Long getAuditType() {
        return this.auditType;
    }

    public GetApplyInviteInfoResponseBody setEmpApplyJoinDept(Boolean empApplyJoinDept) {
        this.empApplyJoinDept = empApplyJoinDept;
        return this;
    }
    public Boolean getEmpApplyJoinDept() {
        return this.empApplyJoinDept;
    }

    public GetApplyInviteInfoResponseBody setInviteSwitch(Boolean inviteSwitch) {
        this.inviteSwitch = inviteSwitch;
        return this;
    }
    public Boolean getInviteSwitch() {
        return this.inviteSwitch;
    }

    public GetApplyInviteInfoResponseBody setInviteUrl(String inviteUrl) {
        this.inviteUrl = inviteUrl;
        return this;
    }
    public String getInviteUrl() {
        return this.inviteUrl;
    }

    public GetApplyInviteInfoResponseBody setLinkInvite(Boolean linkInvite) {
        this.linkInvite = linkInvite;
        return this;
    }
    public Boolean getLinkInvite() {
        return this.linkInvite;
    }

    public GetApplyInviteInfoResponseBody setOrgApplyCodeInvite(Boolean orgApplyCodeInvite) {
        this.orgApplyCodeInvite = orgApplyCodeInvite;
        return this;
    }
    public Boolean getOrgApplyCodeInvite() {
        return this.orgApplyCodeInvite;
    }

    public GetApplyInviteInfoResponseBody setSearchNameInvite(Boolean searchNameInvite) {
        this.searchNameInvite = searchNameInvite;
        return this;
    }
    public Boolean getSearchNameInvite() {
        return this.searchNameInvite;
    }

}
