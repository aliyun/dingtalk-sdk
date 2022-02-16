// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetMicroAppScopeResponseBody extends TeaModel {
    // 可见范围结果
    @NameInMap("result")
    public GetMicroAppScopeResponseBodyResult result;

    public static GetMicroAppScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMicroAppScopeResponseBody self = new GetMicroAppScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMicroAppScopeResponseBody setResult(GetMicroAppScopeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetMicroAppScopeResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetMicroAppScopeResponseBodyResult extends TeaModel {
        // 部门可见列表
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        // 是否管理员可见。如果为true，优先看这个字段
        @NameInMap("onlyAdminVisible")
        public Boolean onlyAdminVisible;

        // 角色可见列表
        @NameInMap("roleIds")
        public java.util.List<Long> roleIds;

        // 用户可见列表
        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static GetMicroAppScopeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetMicroAppScopeResponseBodyResult self = new GetMicroAppScopeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetMicroAppScopeResponseBodyResult setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public GetMicroAppScopeResponseBodyResult setOnlyAdminVisible(Boolean onlyAdminVisible) {
            this.onlyAdminVisible = onlyAdminVisible;
            return this;
        }
        public Boolean getOnlyAdminVisible() {
            return this.onlyAdminVisible;
        }

        public GetMicroAppScopeResponseBodyResult setRoleIds(java.util.List<Long> roleIds) {
            this.roleIds = roleIds;
            return this;
        }
        public java.util.List<Long> getRoleIds() {
            return this.roleIds;
        }

        public GetMicroAppScopeResponseBodyResult setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
