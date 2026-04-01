// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomGroupRolesByUserResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryCustomGroupRolesByUserResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static QueryCustomGroupRolesByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomGroupRolesByUserResponseBody self = new QueryCustomGroupRolesByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCustomGroupRolesByUserResponseBody setResult(QueryCustomGroupRolesByUserResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryCustomGroupRolesByUserResponseBodyResult getResult() {
        return this.result;
    }

    public QueryCustomGroupRolesByUserResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class QueryCustomGroupRolesByUserResponseBodyResultGroupRoles extends TeaModel {
        @NameInMap("openRoleId")
        public String openRoleId;

        @NameInMap("roleName")
        public String roleName;

        public static QueryCustomGroupRolesByUserResponseBodyResultGroupRoles build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomGroupRolesByUserResponseBodyResultGroupRoles self = new QueryCustomGroupRolesByUserResponseBodyResultGroupRoles();
            return TeaModel.build(map, self);
        }

        public QueryCustomGroupRolesByUserResponseBodyResultGroupRoles setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

        public QueryCustomGroupRolesByUserResponseBodyResultGroupRoles setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

    public static class QueryCustomGroupRolesByUserResponseBodyResult extends TeaModel {
        @NameInMap("groupRoles")
        public java.util.List<QueryCustomGroupRolesByUserResponseBodyResultGroupRoles> groupRoles;

        public static QueryCustomGroupRolesByUserResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomGroupRolesByUserResponseBodyResult self = new QueryCustomGroupRolesByUserResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryCustomGroupRolesByUserResponseBodyResult setGroupRoles(java.util.List<QueryCustomGroupRolesByUserResponseBodyResultGroupRoles> groupRoles) {
            this.groupRoles = groupRoles;
            return this;
        }
        public java.util.List<QueryCustomGroupRolesByUserResponseBodyResultGroupRoles> getGroupRoles() {
            return this.groupRoles;
        }

    }

}
