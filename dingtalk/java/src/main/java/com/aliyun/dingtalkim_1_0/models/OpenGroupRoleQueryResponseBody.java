// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public OpenGroupRoleQueryResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static OpenGroupRoleQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleQueryResponseBody self = new OpenGroupRoleQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleQueryResponseBody setResult(OpenGroupRoleQueryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public OpenGroupRoleQueryResponseBodyResult getResult() {
        return this.result;
    }

    public OpenGroupRoleQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OpenGroupRoleQueryResponseBodyResultGroupRoles extends TeaModel {
        @NameInMap("openRoleId")
        public String openRoleId;

        @NameInMap("roleName")
        public String roleName;

        public static OpenGroupRoleQueryResponseBodyResultGroupRoles build(java.util.Map<String, ?> map) throws Exception {
            OpenGroupRoleQueryResponseBodyResultGroupRoles self = new OpenGroupRoleQueryResponseBodyResultGroupRoles();
            return TeaModel.build(map, self);
        }

        public OpenGroupRoleQueryResponseBodyResultGroupRoles setOpenRoleId(String openRoleId) {
            this.openRoleId = openRoleId;
            return this;
        }
        public String getOpenRoleId() {
            return this.openRoleId;
        }

        public OpenGroupRoleQueryResponseBodyResultGroupRoles setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

    public static class OpenGroupRoleQueryResponseBodyResult extends TeaModel {
        @NameInMap("groupRoles")
        public java.util.List<OpenGroupRoleQueryResponseBodyResultGroupRoles> groupRoles;

        public static OpenGroupRoleQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OpenGroupRoleQueryResponseBodyResult self = new OpenGroupRoleQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OpenGroupRoleQueryResponseBodyResult setGroupRoles(java.util.List<OpenGroupRoleQueryResponseBodyResultGroupRoles> groupRoles) {
            this.groupRoles = groupRoles;
            return this;
        }
        public java.util.List<OpenGroupRoleQueryResponseBodyResultGroupRoles> getGroupRoles() {
            return this.groupRoles;
        }

    }

}
