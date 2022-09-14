// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SaveTeamMembersRequest extends TeaModel {
    // 待添加/修改的成员列表。
    @NameInMap("members")
    public java.util.List<SaveTeamMembersRequestMembers> members;

    // 是否通知被授权成员，默认否。
    @NameInMap("notify")
    public Boolean notify;

    // 操作人unionId。
    @NameInMap("operatorId")
    public String operatorId;

    public static SaveTeamMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveTeamMembersRequest self = new SaveTeamMembersRequest();
        return TeaModel.build(map, self);
    }

    public SaveTeamMembersRequest setMembers(java.util.List<SaveTeamMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<SaveTeamMembersRequestMembers> getMembers() {
        return this.members;
    }

    public SaveTeamMembersRequest setNotify(Boolean notify) {
        this.notify = notify;
        return this;
    }
    public Boolean getNotify() {
        return this.notify;
    }

    public SaveTeamMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SaveTeamMembersRequestMembers extends TeaModel {
        // 成员id。
        @NameInMap("memberId")
        public String memberId;

        // 成员类型。
        // 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        @NameInMap("memberType")
        public Integer memberType;

        // 成员角色。
        // 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
        @NameInMap("roleCode")
        public String roleCode;

        public static SaveTeamMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            SaveTeamMembersRequestMembers self = new SaveTeamMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public SaveTeamMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public SaveTeamMembersRequestMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public SaveTeamMembersRequestMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
