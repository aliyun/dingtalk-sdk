// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserGroupRolesResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryUserGroupRolesResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryUserGroupRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserGroupRolesResponseBody self = new QueryUserGroupRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserGroupRolesResponseBody setResult(QueryUserGroupRolesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryUserGroupRolesResponseBodyResult getResult() {
        return this.result;
    }

    public QueryUserGroupRolesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUserGroupRolesResponseBodyResultGroupRoles extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>rolexxxxxxx</p>
         */
        @NameInMap("openRoleId")
        public String openRoleId;

        /**
         * <strong>example:</strong>
         * <p>负责人</p>
         */
        @NameInMap("roleName")
        public String roleName;

        public static QueryUserGroupRolesResponseBodyResultGroupRoles build(java.util.Map<String, ?> map) throws Exception {
            QueryUserGroupRolesResponseBodyResultGroupRoles self = new QueryUserGroupRolesResponseBodyResultGroupRoles();
            return TeaModel.build(map, self);
        }

        public QueryUserGroupRolesResponseBodyResultGroupRoles setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

        public QueryUserGroupRolesResponseBodyResultGroupRoles setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

    public static class QueryUserGroupRolesResponseBodyResult extends TeaModel {
        @NameInMap("groupRoles")
        public java.util.List<QueryUserGroupRolesResponseBodyResultGroupRoles> groupRoles;

        public static QueryUserGroupRolesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserGroupRolesResponseBodyResult self = new QueryUserGroupRolesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserGroupRolesResponseBodyResult setGroupRoles(java.util.List<QueryUserGroupRolesResponseBodyResultGroupRoles> groupRoles) {
            this.groupRoles = groupRoles;
            return this;
        }
        public java.util.List<QueryUserGroupRolesResponseBodyResultGroupRoles> getGroupRoles() {
            return this.groupRoles;
        }

    }

}
