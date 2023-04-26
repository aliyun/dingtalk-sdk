// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListRoleInfoByUserResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListRoleInfoByUserResponseBodyResult> result;

    public static ListRoleInfoByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRoleInfoByUserResponseBody self = new ListRoleInfoByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRoleInfoByUserResponseBody setResult(java.util.List<ListRoleInfoByUserResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListRoleInfoByUserResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListRoleInfoByUserResponseBodyResult extends TeaModel {
        @NameInMap("canManageRole")
        public Boolean canManageRole;

        @NameInMap("roleId")
        public Long roleId;

        @NameInMap("roleName")
        public String roleName;

        public static ListRoleInfoByUserResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListRoleInfoByUserResponseBodyResult self = new ListRoleInfoByUserResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListRoleInfoByUserResponseBodyResult setCanManageRole(Boolean canManageRole) {
            this.canManageRole = canManageRole;
            return this;
        }
        public Boolean getCanManageRole() {
            return this.canManageRole;
        }

        public ListRoleInfoByUserResponseBodyResult setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public ListRoleInfoByUserResponseBodyResult setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

}
