// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAppRoleScopesResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<ListAppRoleScopesResponseBodyDataList> dataList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    public static ListAppRoleScopesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAppRoleScopesResponseBody self = new ListAppRoleScopesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAppRoleScopesResponseBody setDataList(java.util.List<ListAppRoleScopesResponseBodyDataList> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<ListAppRoleScopesResponseBodyDataList> getDataList() {
        return this.dataList;
    }

    public ListAppRoleScopesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListAppRoleScopesResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class ListAppRoleScopesResponseBodyDataList extends TeaModel {
        @NameInMap("canManageRole")
        public Boolean canManageRole;

        @NameInMap("deptIdList")
        public java.util.List<Long> deptIdList;

        @NameInMap("roleId")
        public Long roleId;

        @NameInMap("roleName")
        public String roleName;

        @NameInMap("scopeType")
        public String scopeType;

        @NameInMap("scopeVersion")
        public Long scopeVersion;

        @NameInMap("userIdList")
        public java.util.List<String> userIdList;

        public static ListAppRoleScopesResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            ListAppRoleScopesResponseBodyDataList self = new ListAppRoleScopesResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public ListAppRoleScopesResponseBodyDataList setCanManageRole(Boolean canManageRole) {
            this.canManageRole = canManageRole;
            return this;
        }
        public Boolean getCanManageRole() {
            return this.canManageRole;
        }

        public ListAppRoleScopesResponseBodyDataList setDeptIdList(java.util.List<Long> deptIdList) {
            this.deptIdList = deptIdList;
            return this;
        }
        public java.util.List<Long> getDeptIdList() {
            return this.deptIdList;
        }

        public ListAppRoleScopesResponseBodyDataList setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public ListAppRoleScopesResponseBodyDataList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public ListAppRoleScopesResponseBodyDataList setScopeType(String scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public String getScopeType() {
            return this.scopeType;
        }

        public ListAppRoleScopesResponseBodyDataList setScopeVersion(Long scopeVersion) {
            this.scopeVersion = scopeVersion;
            return this;
        }
        public Long getScopeVersion() {
            return this.scopeVersion;
        }

        public ListAppRoleScopesResponseBodyDataList setUserIdList(java.util.List<String> userIdList) {
            this.userIdList = userIdList;
            return this;
        }
        public java.util.List<String> getUserIdList() {
            return this.userIdList;
        }

    }

}
