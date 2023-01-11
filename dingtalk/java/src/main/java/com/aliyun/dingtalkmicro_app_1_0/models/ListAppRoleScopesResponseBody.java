// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAppRoleScopesResponseBody extends TeaModel {
    /**
     * <p>数据列表</p>
     */
    @NameInMap("dataList")
    public java.util.List<ListAppRoleScopesResponseBodyDataList> dataList;

    /**
     * <p>是否还有数据，true: 还有；false: 已经全部拉取完成</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下一次请求的起始点</p>
     */
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
        /**
         * <p>是否拥有角色管理权限，默认false</p>
         */
        @NameInMap("canManageRole")
        public Boolean canManageRole;

        /**
         * <p>部门id列表</p>
         */
        @NameInMap("deptIdList")
        public java.util.List<Long> deptIdList;

        /**
         * <p>角色Id</p>
         */
        @NameInMap("roleId")
        public Long roleId;

        /**
         * <p>角色名称</p>
         */
        @NameInMap("roleName")
        public String roleName;

        /**
         * <p>角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分</p>
         */
        @NameInMap("scopeType")
        public String scopeType;

        /**
         * <p>角色范围最新版本号</p>
         */
        @NameInMap("scopeVersion")
        public Long scopeVersion;

        /**
         * <p>员工userId列表</p>
         */
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
