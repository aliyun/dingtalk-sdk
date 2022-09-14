// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RemoveTeamMembersResponseBody extends TeaModel {
    // 企业外的成员列表。
    // 保存失败的时候会返回此列表。
    @NameInMap("notInOrgMembers")
    public java.util.List<RemoveTeamMembersResponseBodyNotInOrgMembers> notInOrgMembers;

    // 是否保存成功。
    @NameInMap("saveSuccess")
    public Boolean saveSuccess;

    public static RemoveTeamMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveTeamMembersResponseBody self = new RemoveTeamMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveTeamMembersResponseBody setNotInOrgMembers(java.util.List<RemoveTeamMembersResponseBodyNotInOrgMembers> notInOrgMembers) {
        this.notInOrgMembers = notInOrgMembers;
        return this;
    }
    public java.util.List<RemoveTeamMembersResponseBodyNotInOrgMembers> getNotInOrgMembers() {
        return this.notInOrgMembers;
    }

    public RemoveTeamMembersResponseBody setSaveSuccess(Boolean saveSuccess) {
        this.saveSuccess = saveSuccess;
        return this;
    }
    public Boolean getSaveSuccess() {
        return this.saveSuccess;
    }

    public static class RemoveTeamMembersResponseBodyNotInOrgMembers extends TeaModel {
        // 成员id。
        @NameInMap("memberId")
        public String memberId;

        // 成员类型。
        // 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        @NameInMap("memberType")
        public Integer memberType;

        // 成员名称。
        @NameInMap("name")
        public String name;

        // 成员角色。
        // 0-无权限；1-只读；2-只读/下载；3-编辑、4-管理员；5-所有者。
        @NameInMap("roleCode")
        public String roleCode;

        public static RemoveTeamMembersResponseBodyNotInOrgMembers build(java.util.Map<String, ?> map) throws Exception {
            RemoveTeamMembersResponseBodyNotInOrgMembers self = new RemoveTeamMembersResponseBodyNotInOrgMembers();
            return TeaModel.build(map, self);
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public RemoveTeamMembersResponseBodyNotInOrgMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
