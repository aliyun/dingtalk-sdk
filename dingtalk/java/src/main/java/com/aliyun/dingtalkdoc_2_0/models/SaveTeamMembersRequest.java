// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SaveTeamMembersRequest extends TeaModel {
    /**
     * <p>待添加/修改的成员列表。</p>
     */
    @NameInMap("members")
    public java.util.List<SaveTeamMembersRequestMembers> members;

    /**
     * <p>是否通知被授权成员，默认否。</p>
     */
    @NameInMap("notify")
    public Boolean notify;

    /**
     * <p>操作人unionId。</p>
     */
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
