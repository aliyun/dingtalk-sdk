// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListRoleResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SupplyListRoleResponseBodyResult> result;

    public static SupplyListRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyListRoleResponseBody self = new SupplyListRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyListRoleResponseBody setResult(java.util.List<SupplyListRoleResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SupplyListRoleResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SupplyListRoleResponseBodyResult extends TeaModel {
        @NameInMap("isRoleGroup")
        public Boolean isRoleGroup;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("roleId")
        public String roleId;

        /**
         * <strong>example:</strong>
         * <p>老板</p>
         */
        @NameInMap("roleName")
        public String roleName;

        public static SupplyListRoleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyListRoleResponseBodyResult self = new SupplyListRoleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyListRoleResponseBodyResult setIsRoleGroup(Boolean isRoleGroup) {
            this.isRoleGroup = isRoleGroup;
            return this;
        }
        public Boolean getIsRoleGroup() {
            return this.isRoleGroup;
        }

        public SupplyListRoleResponseBodyResult setRoleId(String roleId) {
            this.roleId = roleId;
            return this;
        }
        public String getRoleId() {
            return this.roleId;
        }

        public SupplyListRoleResponseBodyResult setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

}
