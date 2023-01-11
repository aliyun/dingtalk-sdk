// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetApplyInviteInfoResponseBody extends TeaModel {
    /**
     * <p>仅部门邀请有效： 0-无需审核 1-有权限的子管理员</p>
     */
    @NameInMap("auditType")
    public Long auditType;

    /**
     * <p>是否允许员工扫码加入部门，仅在无需审核的时候有效（已经在组织内的成员通过扫描部门二维码加入某个部门）</p>
     */
    @NameInMap("empApplyJoinDept")
    public Boolean empApplyJoinDept;

    /**
     * <p>是否开启邀请</p>
     */
    @NameInMap("inviteSwitch")
    public Boolean inviteSwitch;

    /**
     * <p>邀请链接</p>
     */
    @NameInMap("inviteUrl")
    public String inviteUrl;

    /**
     * <p>是否开启通过链接邀请加入</p>
     */
    @NameInMap("linkInvite")
    public Boolean linkInvite;

    /**
     * <p>是否开启通过团队号申请加入</p>
     */
    @NameInMap("orgApplyCodeInvite")
    public Boolean orgApplyCodeInvite;

    /**
     * <p>是否开启通过企业名称搜索申请</p>
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
