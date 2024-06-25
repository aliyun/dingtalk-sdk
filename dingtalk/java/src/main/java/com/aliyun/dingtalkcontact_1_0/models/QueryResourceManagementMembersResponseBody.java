// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryResourceManagementMembersResponseBody extends TeaModel {
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
        /**
         * <strong>example:</strong>
         * <p>WB001</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <strong>example:</strong>
         * <p>user</p>
         */
        @NameInMap("memberType")
        public String memberType;

        public static QueryResourceManagementMembersResponseBodyMembers build(java.util.Map<String, ?> map) throws Exception {
            QueryResourceManagementMembersResponseBodyMembers self = new QueryResourceManagementMembersResponseBodyMembers();
            return TeaModel.build(map, self);
        }

        public QueryResourceManagementMembersResponseBodyMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public QueryResourceManagementMembersResponseBodyMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

}
