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
        // 角色范围最新版本号
        @NameInMap("latestScopeVersion")
        public Long latestScopeVersion;

        // 角色id
        @NameInMap("roleId")
        public Long roleId;

        @NameInMap("subErrorCode")
        public String subErrorCode;

        @NameInMap("subErrorMsg")
        public String subErrorMsg;

        // 角色添加结果，true: 成功，false: 失败
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
