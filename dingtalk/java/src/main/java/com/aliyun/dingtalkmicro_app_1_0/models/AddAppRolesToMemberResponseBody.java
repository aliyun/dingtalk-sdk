// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppRolesToMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<AddAppRolesToMemberResponseBodyResult> result;

    public static AddAppRolesToMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddAppRolesToMemberResponseBody self = new AddAppRolesToMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public AddAppRolesToMemberResponseBody setResult(java.util.List<AddAppRolesToMemberResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<AddAppRolesToMemberResponseBodyResult> getResult() {
        return this.result;
    }

    public static class AddAppRolesToMemberResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("latestScopeVersion")
        public Long latestScopeVersion;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("roleId")
        public Long roleId;

        /**
         * <strong>example:</strong>
         * <p>userNoPrivilegeToManageApp</p>
         */
        @NameInMap("subErrorCode")
        public String subErrorCode;

        /**
         * <strong>example:</strong>
         * <p>传入的角色范围数据版本号不合法</p>
         */
        @NameInMap("subErrorMsg")
        public String subErrorMsg;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static AddAppRolesToMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddAppRolesToMemberResponseBodyResult self = new AddAppRolesToMemberResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddAppRolesToMemberResponseBodyResult setLatestScopeVersion(Long latestScopeVersion) {
            this.latestScopeVersion = latestScopeVersion;
            return this;
        }
        public Long getLatestScopeVersion() {
            return this.latestScopeVersion;
        }

        public AddAppRolesToMemberResponseBodyResult setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public AddAppRolesToMemberResponseBodyResult setSubErrorCode(String subErrorCode) {
            this.subErrorCode = subErrorCode;
            return this;
        }
        public String getSubErrorCode() {
            return this.subErrorCode;
        }

        public AddAppRolesToMemberResponseBodyResult setSubErrorMsg(String subErrorMsg) {
            this.subErrorMsg = subErrorMsg;
            return this;
        }
        public String getSubErrorMsg() {
            return this.subErrorMsg;
        }

        public AddAppRolesToMemberResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
