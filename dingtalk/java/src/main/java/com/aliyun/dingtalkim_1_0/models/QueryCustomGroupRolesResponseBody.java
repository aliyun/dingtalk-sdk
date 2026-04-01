// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomGroupRolesResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryCustomGroupRolesResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static QueryCustomGroupRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomGroupRolesResponseBody self = new QueryCustomGroupRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCustomGroupRolesResponseBody setResult(QueryCustomGroupRolesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryCustomGroupRolesResponseBodyResult getResult() {
        return this.result;
    }

    public QueryCustomGroupRolesResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class QueryCustomGroupRolesResponseBodyResultGroupRoles extends TeaModel {
        @NameInMap("openRoleId")
        public String openRoleId;

        @NameInMap("roleName")
        public String roleName;

        public static QueryCustomGroupRolesResponseBodyResultGroupRoles build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomGroupRolesResponseBodyResultGroupRoles self = new QueryCustomGroupRolesResponseBodyResultGroupRoles();
            return TeaModel.build(map, self);
        }

        public QueryCustomGroupRolesResponseBodyResultGroupRoles setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

        public QueryCustomGroupRolesResponseBodyResultGroupRoles setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

    public static class QueryCustomGroupRolesResponseBodyResult extends TeaModel {
        @NameInMap("groupRoles")
        public java.util.List<QueryCustomGroupRolesResponseBodyResultGroupRoles> groupRoles;

        public static QueryCustomGroupRolesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomGroupRolesResponseBodyResult self = new QueryCustomGroupRolesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryCustomGroupRolesResponseBodyResult setGroupRoles(java.util.List<QueryCustomGroupRolesResponseBodyResultGroupRoles> groupRoles) {
            this.groupRoles = groupRoles;
            return this;
        }
        public java.util.List<QueryCustomGroupRolesResponseBodyResultGroupRoles> getGroupRoles() {
            return this.groupRoles;
        }

    }

}
