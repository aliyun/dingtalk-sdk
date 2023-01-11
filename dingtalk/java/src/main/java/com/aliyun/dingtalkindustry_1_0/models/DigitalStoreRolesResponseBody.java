// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreRolesResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<DigitalStoreRolesResponseBodyContent> content;

    public static DigitalStoreRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreRolesResponseBody self = new DigitalStoreRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreRolesResponseBody setContent(java.util.List<DigitalStoreRolesResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<DigitalStoreRolesResponseBodyContent> getContent() {
        return this.content;
    }

    public static class DigitalStoreRolesResponseBodyContent extends TeaModel {
        /**
         * <p>优先级</p>
         */
        @NameInMap("level")
        public Long level;

        /**
         * <p>角色Code</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

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

        public static DigitalStoreRolesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreRolesResponseBodyContent self = new DigitalStoreRolesResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStoreRolesResponseBodyContent setLevel(Long level) {
            this.level = level;
            return this;
        }
        public Long getLevel() {
            return this.level;
        }

        public DigitalStoreRolesResponseBodyContent setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public DigitalStoreRolesResponseBodyContent setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public DigitalStoreRolesResponseBodyContent setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

}
