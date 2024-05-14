// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SaveTeamMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<SaveTeamMembersRequestMembers> members;

    @NameInMap("notify")
    public Boolean notify;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

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
