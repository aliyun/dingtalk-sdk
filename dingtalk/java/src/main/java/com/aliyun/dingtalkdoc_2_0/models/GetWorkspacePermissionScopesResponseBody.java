// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetWorkspacePermissionScopesResponseBody extends TeaModel {
    @NameInMap("members")
    public java.util.List<GetWorkspacePermissionScopesResponseBodyMembers> members;

    public static GetWorkspacePermissionScopesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspacePermissionScopesResponseBody self = new GetWorkspacePermissionScopesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkspacePermissionScopesResponseBody setMembers(java.util.List<GetWorkspacePermissionScopesResponseBodyMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<GetWorkspacePermissionScopesResponseBodyMembers> getMembers() {
        return this.members;
    }

    public static class GetWorkspacePermissionScopesResponseBodyMembers extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberRole")
        public String memberRole;

        @NameInMap("memberType")
        public String memberType;

        public static GetWorkspacePermissionScopesResponseBodyMembers build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspacePermissionScopesResponseBodyMembers self = new GetWorkspacePermissionScopesResponseBodyMembers();
            return TeaModel.build(map, self);
        }

        public GetWorkspacePermissionScopesResponseBodyMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public GetWorkspacePermissionScopesResponseBodyMembers setMemberRole(String memberRole) {
            this.memberRole = memberRole;
            return this;
        }
        public String getMemberRole() {
            return this.memberRole;
        }

        public GetWorkspacePermissionScopesResponseBodyMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

}
