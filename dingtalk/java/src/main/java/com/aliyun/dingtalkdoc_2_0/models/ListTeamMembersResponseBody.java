// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListTeamMembersResponseBody extends TeaModel {
    /**
     * <p>小组成员列表。</p>
     */
    @NameInMap("members")
    public java.util.List<ListTeamMembersResponseBodyMembers> members;

    /**
     * <p>小组名称。</p>
     */
    @NameInMap("teamName")
    public String teamName;

    public static ListTeamMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTeamMembersResponseBody self = new ListTeamMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTeamMembersResponseBody setMembers(java.util.List<ListTeamMembersResponseBodyMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<ListTeamMembersResponseBodyMembers> getMembers() {
        return this.members;
    }

    public ListTeamMembersResponseBody setTeamName(String teamName) {
        this.teamName = teamName;
        return this;
    }
    public String getTeamName() {
        return this.teamName;
    }

    public static class ListTeamMembersResponseBodyMembers extends TeaModel {
        /**
         * <p>成员id。</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>成员类型。</p>
         * <p>1-群；2-用户；3-组织；4-部门；5-虚拟组。</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

        /**
         * <p>成员名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>成员角色。</p>
         * <p>0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        public static ListTeamMembersResponseBodyMembers build(java.util.Map<String, ?> map) throws Exception {
            ListTeamMembersResponseBodyMembers self = new ListTeamMembersResponseBodyMembers();
            return TeaModel.build(map, self);
        }

        public ListTeamMembersResponseBodyMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public ListTeamMembersResponseBodyMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public ListTeamMembersResponseBodyMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListTeamMembersResponseBodyMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
