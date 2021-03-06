// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryResourceManagementMembersResponseBody extends TeaModel {
    // 可管理资源的成员
    @NameInMap("members")
    public java.util.List<QueryResourceManagementMembersResponseBodyMembers> members;

    public static QueryResourceManagementMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryResourceManagementMembersResponseBody self = new QueryResourceManagementMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryResourceManagementMembersResponseBody setMembers(java.util.List<QueryResourceManagementMembersResponseBodyMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<QueryResourceManagementMembersResponseBodyMembers> getMembers() {
        return this.members;
    }

    public static class QueryResourceManagementMembersResponseBodyMembers extends TeaModel {
        // 成员类型
        @NameInMap("memberType")
        public String memberType;

        // 成员id
        @NameInMap("memberId")
        public String memberId;

        public static QueryResourceManagementMembersResponseBodyMembers build(java.util.Map<String, ?> map) throws Exception {
            QueryResourceManagementMembersResponseBodyMembers self = new QueryResourceManagementMembersResponseBodyMembers();
            return TeaModel.build(map, self);
        }

        public QueryResourceManagementMembersResponseBodyMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public QueryResourceManagementMembersResponseBodyMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

    }

}
