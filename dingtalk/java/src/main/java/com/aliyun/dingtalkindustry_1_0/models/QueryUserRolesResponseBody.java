// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserRolesResponseBody extends TeaModel {
    // 扩展属性
    @NameInMap("content")
    public java.util.List<QueryUserRolesResponseBodyContent> content;

    public static QueryUserRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserRolesResponseBody self = new QueryUserRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserRolesResponseBody setContent(java.util.List<QueryUserRolesResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryUserRolesResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryUserRolesResponseBodyContent extends TeaModel {
        // 角色编码
        @NameInMap("roleCode")
        public String roleCode;

        // 角色名称
        @NameInMap("roleName")
        public String roleName;

        public static QueryUserRolesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserRolesResponseBodyContent self = new QueryUserRolesResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryUserRolesResponseBodyContent setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public QueryUserRolesResponseBodyContent setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

}
