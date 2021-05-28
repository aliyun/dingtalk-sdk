// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAppRoleScopesResponseBody extends TeaModel {
    // 是否还有数据，true: 还有；false: 已经全部拉取完成
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下一次请求的起始点
    @NameInMap("nextToken")
    public Long nextToken;

    // 数据列表
    @NameInMap("dataList")
    public java.util.List<ListAppRoleScopesResponseBodyDataList> dataList;

    public static ListAppRoleScopesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAppRoleScopesResponseBody self = new ListAppRoleScopesResponseBody();
        return TeaModel.build(map, self);
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

    public ListAppRoleScopesResponseBody setDataList(java.util.List<ListAppRoleScopesResponseBodyDataList> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<ListAppRoleScopesResponseBodyDataList> getDataList() {
        return this.dataList;
    }

    public static class ListAppRoleScopesResponseBodyDataList extends TeaModel {
        // 角色名称
        @NameInMap("roleName")
        public String roleName;

        // 角色Id
        @NameInMap("roleId")
        public Long roleId;

        // 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
        @NameInMap("scopeType")
        public String scopeType;

        // 部门id列表
        @NameInMap("deptIdList")
        public java.util.List<Long> deptIdList;

        // 员工userId列表
        @NameInMap("userIdList")
        public java.util.List<String> userIdList;

        // 角色范围最新版本号
        @NameInMap("scopeVersion")
        public Long scopeVersion;

        public static ListAppRoleScopesResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            ListAppRoleScopesResponseBodyDataList self = new ListAppRoleScopesResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public ListAppRoleScopesResponseBodyDataList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public ListAppRoleScopesResponseBodyDataList setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public ListAppRoleScopesResponseBodyDataList setScopeType(String scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public String getScopeType() {
            return this.scopeType;
        }

        public ListAppRoleScopesResponseBodyDataList setDeptIdList(java.util.List<Long> deptIdList) {
            this.deptIdList = deptIdList;
            return this;
        }
        public java.util.List<Long> getDeptIdList() {
            return this.deptIdList;
        }

        public ListAppRoleScopesResponseBodyDataList setUserIdList(java.util.List<String> userIdList) {
            this.userIdList = userIdList;
            return this;
        }
        public java.util.List<String> getUserIdList() {
            return this.userIdList;
        }

        public ListAppRoleScopesResponseBodyDataList setScopeVersion(Long scopeVersion) {
            this.scopeVersion = scopeVersion;
            return this;
        }
        public Long getScopeVersion() {
            return this.scopeVersion;
        }

    }

}
