// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListManagementGroupsResponseBody extends TeaModel {
    @NameInMap("groups")
    public java.util.List<ListManagementGroupsResponseBodyGroups> groups;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    public static ListManagementGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListManagementGroupsResponseBody self = new ListManagementGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListManagementGroupsResponseBody setGroups(java.util.List<ListManagementGroupsResponseBodyGroups> groups) {
        this.groups = groups;
        return this;
    }
    public java.util.List<ListManagementGroupsResponseBodyGroups> getGroups() {
        return this.groups;
    }

    public ListManagementGroupsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListManagementGroupsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class ListManagementGroupsResponseBodyGroupsMembers extends TeaModel {
        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberType")
        public String memberType;

        public static ListManagementGroupsResponseBodyGroupsMembers build(java.util.Map<String, ?> map) throws Exception {
            ListManagementGroupsResponseBodyGroupsMembers self = new ListManagementGroupsResponseBodyGroupsMembers();
            return TeaModel.build(map, self);
        }

        public ListManagementGroupsResponseBodyGroupsMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public ListManagementGroupsResponseBodyGroupsMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class ListManagementGroupsResponseBodyGroupsScope extends TeaModel {
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        @NameInMap("scopeType")
        public Integer scopeType;

        public static ListManagementGroupsResponseBodyGroupsScope build(java.util.Map<String, ?> map) throws Exception {
            ListManagementGroupsResponseBodyGroupsScope self = new ListManagementGroupsResponseBodyGroupsScope();
            return TeaModel.build(map, self);
        }

        public ListManagementGroupsResponseBodyGroupsScope setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public ListManagementGroupsResponseBodyGroupsScope setScopeType(Integer scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public Integer getScopeType() {
            return this.scopeType;
        }

    }

    public static class ListManagementGroupsResponseBodyGroups extends TeaModel {
        @NameInMap("groupId")
        public String groupId;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("members")
        public java.util.List<ListManagementGroupsResponseBodyGroupsMembers> members;

        @NameInMap("resourceIds")
        public java.util.List<String> resourceIds;

        @NameInMap("scope")
        public ListManagementGroupsResponseBodyGroupsScope scope;

        public static ListManagementGroupsResponseBodyGroups build(java.util.Map<String, ?> map) throws Exception {
            ListManagementGroupsResponseBodyGroups self = new ListManagementGroupsResponseBodyGroups();
            return TeaModel.build(map, self);
        }

        public ListManagementGroupsResponseBodyGroups setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public ListManagementGroupsResponseBodyGroups setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public ListManagementGroupsResponseBodyGroups setMembers(java.util.List<ListManagementGroupsResponseBodyGroupsMembers> members) {
            this.members = members;
            return this;
        }
        public java.util.List<ListManagementGroupsResponseBodyGroupsMembers> getMembers() {
            return this.members;
        }

        public ListManagementGroupsResponseBodyGroups setResourceIds(java.util.List<String> resourceIds) {
            this.resourceIds = resourceIds;
            return this;
        }
        public java.util.List<String> getResourceIds() {
            return this.resourceIds;
        }

        public ListManagementGroupsResponseBodyGroups setScope(ListManagementGroupsResponseBodyGroupsScope scope) {
            this.scope = scope;
            return this;
        }
        public ListManagementGroupsResponseBodyGroupsScope getScope() {
            return this.scope;
        }

    }

}
