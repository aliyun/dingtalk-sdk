// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RemoveTeamMembersRequest extends TeaModel {
    /**
     * <p>待移除的成员列表。</p>
     */
    @NameInMap("members")
    public java.util.List<RemoveTeamMembersRequestMembers> members;

    /**
     * <p>是否通知被移除的成员，默认否。</p>
     */
    @NameInMap("notify")
    public Boolean notify;

    /**
     * <p>操作人unionId。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static RemoveTeamMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveTeamMembersRequest self = new RemoveTeamMembersRequest();
        return TeaModel.build(map, self);
    }

    public RemoveTeamMembersRequest setMembers(java.util.List<RemoveTeamMembersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<RemoveTeamMembersRequestMembers> getMembers() {
        return this.members;
    }

    public RemoveTeamMembersRequest setNotify(Boolean notify) {
        this.notify = notify;
        return this;
    }
    public Boolean getNotify() {
        return this.notify;
    }

    public RemoveTeamMembersRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class RemoveTeamMembersRequestMembers extends TeaModel {
        /**
         * <p>成员id。</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>成员类型。</p>
         * <p>1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

        /**
         * <p>成员角色。</p>
         * <p>0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        public static RemoveTeamMembersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            RemoveTeamMembersRequestMembers self = new RemoveTeamMembersRequestMembers();
            return TeaModel.build(map, self);
        }

        public RemoveTeamMembersRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public RemoveTeamMembersRequestMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public RemoveTeamMembersRequestMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
