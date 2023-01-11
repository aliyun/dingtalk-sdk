// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetMicroAppScopeResponseBody extends TeaModel {
    /**
     * <p>可见范围结果</p>
     */
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
        /**
         * <p>部门可见列表</p>
         */
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        /**
         * <p>是否管理员可见。如果为true，优先看这个字段</p>
         */
        @NameInMap("onlyAdminVisible")
        public Boolean onlyAdminVisible;

        /**
         * <p>角色可见列表</p>
         */
        @NameInMap("roleIds")
        public java.util.List<Long> roleIds;

        /**
         * <p>用户可见列表</p>
         */
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
