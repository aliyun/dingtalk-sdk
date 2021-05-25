// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListManagementGroupsResponseBody extends TeaModel {
    // 下一次读取的位置
    @NameInMap("nextToken")
    public Long nextToken;

    // 是否有下一页
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 管理组列表
    @NameInMap("groups")
    public java.util.List<ListManagementGroupsResponseBodyGroups> groups;

    public static ListManagementGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListManagementGroupsResponseBody self = new ListManagementGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListManagementGroupsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListManagementGroupsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListManagementGroupsResponseBody setGroups(java.util.List<ListManagementGroupsResponseBodyGroups> groups) {
        this.groups = groups;
        return this;
    }
    public java.util.List<ListManagementGroupsResponseBodyGroups> getGroups() {
        return this.groups;
    }

    public static class ListManagementGroupsResponseBodyGroupsMembers extends TeaModel {
        // 成员类型
        @NameInMap("memberType")
        public String memberType;

        // 成员id
        @NameInMap("memberId")
        public String memberId;

        public static ListManagementGroupsResponseBodyGroupsMembers build(java.util.Map<String, ?> map) throws Exception {
            ListManagementGroupsResponseBodyGroupsMembers self = new ListManagementGroupsResponseBodyGroupsMembers();
            return TeaModel.build(map, self);
        }

        public ListManagementGroupsResponseBodyGroupsMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public ListManagementGroupsResponseBodyGroupsMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

    }

    public static class ListManagementGroupsResponseBodyGroupsScope extends TeaModel {
        // 1
        @NameInMap("scopeType")
        public Integer scopeType;

        // 部门列表，只在scopeType=3 生效
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        public static ListManagementGroupsResponseBodyGroupsScope build(java.util.Map<String, ?> map) throws Exception {
            ListManagementGroupsResponseBodyGroupsScope self = new ListManagementGroupsResponseBodyGroupsScope();
            return TeaModel.build(map, self);
        }

        public ListManagementGroupsResponseBodyGroupsScope setScopeType(Integer scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public Integer getScopeType() {
            return this.scopeType;
        }

        public ListManagementGroupsResponseBodyGroupsScope setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

    }

    public static class ListManagementGroupsResponseBodyGroups extends TeaModel {
        // 管理组id
        @NameInMap("groupId")
        public String groupId;

        // 管理组名
        @NameInMap("groupName")
        public String groupName;

        // 成员
        @NameInMap("members")
        public java.util.List<ListManagementGroupsResponseBodyGroupsMembers> members;

        // 管理范围
        @NameInMap("scope")
        public ListManagementGroupsResponseBodyGroupsScope scope;

        // 资源列表
        @NameInMap("resourceIds")
        public java.util.List<String> resourceIds;

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

        public ListManagementGroupsResponseBodyGroups setScope(ListManagementGroupsResponseBodyGroupsScope scope) {
            this.scope = scope;
            return this;
        }
        public ListManagementGroupsResponseBodyGroupsScope getScope() {
            return this.scope;
        }

        public ListManagementGroupsResponseBodyGroups setResourceIds(java.util.List<String> resourceIds) {
            this.resourceIds = resourceIds;
            return this;
        }
        public java.util.List<String> getResourceIds() {
            return this.resourceIds;
        }

    }

}
