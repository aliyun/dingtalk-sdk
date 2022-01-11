// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListAclsResponseBody extends TeaModel {
    // 访问控制列表
    @NameInMap("acls")
    public java.util.List<ListAclsResponseBodyAcls> acls;

    public static ListAclsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAclsResponseBody self = new ListAclsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAclsResponseBody setAcls(java.util.List<ListAclsResponseBodyAcls> acls) {
        this.acls = acls;
        return this;
    }
    public java.util.List<ListAclsResponseBodyAcls> getAcls() {
        return this.acls;
    }

    public static class ListAclsResponseBodyAclsScope extends TeaModel {
        // 权限类型
        @NameInMap("scopeType")
        public String scopeType;

        // 用户id
        @NameInMap("userId")
        public String userId;

        public static ListAclsResponseBodyAclsScope build(java.util.Map<String, ?> map) throws Exception {
            ListAclsResponseBodyAclsScope self = new ListAclsResponseBodyAclsScope();
            return TeaModel.build(map, self);
        }

        public ListAclsResponseBodyAclsScope setScopeType(String scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public String getScopeType() {
            return this.scopeType;
        }

        public ListAclsResponseBodyAclsScope setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListAclsResponseBodyAcls extends TeaModel {
        // acl资源ID
        @NameInMap("aclId")
        public String aclId;

        // 权限信息
        @NameInMap("privilege")
        public String privilege;

        // 权限范围
        @NameInMap("scope")
        public ListAclsResponseBodyAclsScope scope;

        public static ListAclsResponseBodyAcls build(java.util.Map<String, ?> map) throws Exception {
            ListAclsResponseBodyAcls self = new ListAclsResponseBodyAcls();
            return TeaModel.build(map, self);
        }

        public ListAclsResponseBodyAcls setAclId(String aclId) {
            this.aclId = aclId;
            return this;
        }
        public String getAclId() {
            return this.aclId;
        }

        public ListAclsResponseBodyAcls setPrivilege(String privilege) {
            this.privilege = privilege;
            return this;
        }
        public String getPrivilege() {
            return this.privilege;
        }

        public ListAclsResponseBodyAcls setScope(ListAclsResponseBodyAclsScope scope) {
            this.scope = scope;
            return this;
        }
        public ListAclsResponseBodyAclsScope getScope() {
            return this.scope;
        }

    }

}
