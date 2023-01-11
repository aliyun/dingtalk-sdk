// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateAclsResponseBody extends TeaModel {
    /**
     * <p>acl资源ID</p>
     */
    @NameInMap("aclId")
    public String aclId;

    /**
     * <p>对日历的访问权限</p>
     */
    @NameInMap("privilege")
    public String privilege;

    /**
     * <p>权限范围</p>
     */
    @NameInMap("scope")
    public CreateAclsResponseBodyScope scope;

    public static CreateAclsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAclsResponseBody self = new CreateAclsResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAclsResponseBody setAclId(String aclId) {
        this.aclId = aclId;
        return this;
    }
    public String getAclId() {
        return this.aclId;
    }

    public CreateAclsResponseBody setPrivilege(String privilege) {
        this.privilege = privilege;
        return this;
    }
    public String getPrivilege() {
        return this.privilege;
    }

    public CreateAclsResponseBody setScope(CreateAclsResponseBodyScope scope) {
        this.scope = scope;
        return this;
    }
    public CreateAclsResponseBodyScope getScope() {
        return this.scope;
    }

    public static class CreateAclsResponseBodyScope extends TeaModel {
        /**
         * <p>权限类型</p>
         */
        @NameInMap("scopeType")
        public String scopeType;

        /**
         * <p>用户id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CreateAclsResponseBodyScope build(java.util.Map<String, ?> map) throws Exception {
            CreateAclsResponseBodyScope self = new CreateAclsResponseBodyScope();
            return TeaModel.build(map, self);
        }

        public CreateAclsResponseBodyScope setScopeType(String scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public String getScopeType() {
            return this.scopeType;
        }

        public CreateAclsResponseBodyScope setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
