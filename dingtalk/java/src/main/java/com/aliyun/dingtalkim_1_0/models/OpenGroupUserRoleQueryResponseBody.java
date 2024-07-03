// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupUserRoleQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public OpenGroupUserRoleQueryResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static OpenGroupUserRoleQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupUserRoleQueryResponseBody self = new OpenGroupUserRoleQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenGroupUserRoleQueryResponseBody setResult(OpenGroupUserRoleQueryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public OpenGroupUserRoleQueryResponseBodyResult getResult() {
        return this.result;
    }

    public OpenGroupUserRoleQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OpenGroupUserRoleQueryResponseBodyResultGroupRoles extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>rolexxxxxxx</p>
         */
        @NameInMap("openRoleId")
        public String openRoleId;

        /**
         * <strong>example:</strong>
         * <p>小美</p>
         */
        @NameInMap("roleName")
        public String roleName;

        public static OpenGroupUserRoleQueryResponseBodyResultGroupRoles build(java.util.Map<String, ?> map) throws Exception {
            OpenGroupUserRoleQueryResponseBodyResultGroupRoles self = new OpenGroupUserRoleQueryResponseBodyResultGroupRoles();
            return TeaModel.build(map, self);
        }

        public OpenGroupUserRoleQueryResponseBodyResultGroupRoles setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

        public OpenGroupUserRoleQueryResponseBodyResultGroupRoles setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

    public static class OpenGroupUserRoleQueryResponseBodyResult extends TeaModel {
        @NameInMap("groupRoles")
        public java.util.List<OpenGroupUserRoleQueryResponseBodyResultGroupRoles> groupRoles;

        public static OpenGroupUserRoleQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OpenGroupUserRoleQueryResponseBodyResult self = new OpenGroupUserRoleQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OpenGroupUserRoleQueryResponseBodyResult setGroupRoles(java.util.List<OpenGroupUserRoleQueryResponseBodyResultGroupRoles> groupRoles) {
            this.groupRoles = groupRoles;
            return this;
        }
        public java.util.List<OpenGroupUserRoleQueryResponseBodyResultGroupRoles> getGroupRoles() {
            return this.groupRoles;
        }

    }

}
