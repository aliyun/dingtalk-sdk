// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserRoleListResponseBody extends TeaModel {
    @NameInMap("financeEmpDeptOpenList")
    public java.util.List<QueryUserRoleListResponseBodyFinanceEmpDeptOpenList> financeEmpDeptOpenList;

    @NameInMap("roleVOList")
    public java.util.List<QueryUserRoleListResponseBodyRoleVOList> roleVOList;

    public static QueryUserRoleListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserRoleListResponseBody self = new QueryUserRoleListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserRoleListResponseBody setFinanceEmpDeptOpenList(java.util.List<QueryUserRoleListResponseBodyFinanceEmpDeptOpenList> financeEmpDeptOpenList) {
        this.financeEmpDeptOpenList = financeEmpDeptOpenList;
        return this;
    }
    public java.util.List<QueryUserRoleListResponseBodyFinanceEmpDeptOpenList> getFinanceEmpDeptOpenList() {
        return this.financeEmpDeptOpenList;
    }

    public QueryUserRoleListResponseBody setRoleVOList(java.util.List<QueryUserRoleListResponseBodyRoleVOList> roleVOList) {
        this.roleVOList = roleVOList;
        return this;
    }
    public java.util.List<QueryUserRoleListResponseBodyRoleVOList> getRoleVOList() {
        return this.roleVOList;
    }

    public static class QueryUserRoleListResponseBodyFinanceEmpDeptOpenList extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("name")
        public String name;

        @NameInMap("superDeptId")
        public Long superDeptId;

        public static QueryUserRoleListResponseBodyFinanceEmpDeptOpenList build(java.util.Map<String, ?> map) throws Exception {
            QueryUserRoleListResponseBodyFinanceEmpDeptOpenList self = new QueryUserRoleListResponseBodyFinanceEmpDeptOpenList();
            return TeaModel.build(map, self);
        }

        public QueryUserRoleListResponseBodyFinanceEmpDeptOpenList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryUserRoleListResponseBodyFinanceEmpDeptOpenList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryUserRoleListResponseBodyFinanceEmpDeptOpenList setSuperDeptId(Long superDeptId) {
            this.superDeptId = superDeptId;
            return this;
        }
        public Long getSuperDeptId() {
            return this.superDeptId;
        }

    }

    public static class QueryUserRoleListResponseBodyRoleVOList extends TeaModel {
        @NameInMap("roleCode")
        public String roleCode;

        @NameInMap("roleName")
        public String roleName;

        public static QueryUserRoleListResponseBodyRoleVOList build(java.util.Map<String, ?> map) throws Exception {
            QueryUserRoleListResponseBodyRoleVOList self = new QueryUserRoleListResponseBodyRoleVOList();
            return TeaModel.build(map, self);
        }

        public QueryUserRoleListResponseBodyRoleVOList setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public QueryUserRoleListResponseBodyRoleVOList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

}
