// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SaveTeamMembersResponseBody extends TeaModel {
    @NameInMap("notInOrgMembers")
    public java.util.List<SaveTeamMembersResponseBodyNotInOrgMembers> notInOrgMembers;

    @NameInMap("saveSuccess")
    public Boolean saveSuccess;

    public static SaveTeamMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveTeamMembersResponseBody self = new SaveTeamMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveTeamMembersResponseBody setNotInOrgMembers(java.util.List<SaveTeamMembersResponseBodyNotInOrgMembers> notInOrgMembers) {
        this.notInOrgMembers = notInOrgMembers;
        return this;
    }
    public java.util.List<SaveTeamMembersResponseBodyNotInOrgMembers> getNotInOrgMembers() {
        return this.notInOrgMembers;
    }

    public SaveTeamMembersResponseBody setSaveSuccess(Boolean saveSuccess) {
        this.saveSuccess = saveSuccess;
        return this;
    }
    public Boolean getSaveSuccess() {
        return this.saveSuccess;
    }

    public static class SaveTeamMembersResponseBodyNotInOrgMembers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>YEp3JcM******UIbhwiE</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

        /**
         * <strong>example:</strong>
         * <p>小钉</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        public static SaveTeamMembersResponseBodyNotInOrgMembers build(java.util.Map<String, ?> map) throws Exception {
            SaveTeamMembersResponseBodyNotInOrgMembers self = new SaveTeamMembersResponseBodyNotInOrgMembers();
            return TeaModel.build(map, self);
        }

        public SaveTeamMembersResponseBodyNotInOrgMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public SaveTeamMembersResponseBodyNotInOrgMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public SaveTeamMembersResponseBodyNotInOrgMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveTeamMembersResponseBodyNotInOrgMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
