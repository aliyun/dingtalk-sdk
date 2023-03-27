// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectMemebersResponseBody extends TeaModel {
    /**
     * <p>项目成员列表。</p>
     */
    @NameInMap("result")
    public java.util.List<GetProjectMemebersResponseBodyResult> result;

    public static GetProjectMemebersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProjectMemebersResponseBody self = new GetProjectMemebersResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProjectMemebersResponseBody setResult(java.util.List<GetProjectMemebersResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetProjectMemebersResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetProjectMemebersResponseBodyResult extends TeaModel {
        /**
         * <p>项目成员ID。</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>项目角色，0=成员；1=管理员；2=拥有者。</p>
         */
        @NameInMap("role")
        public Integer role;

        /**
         * <p>项目角色ID列表。</p>
         */
        @NameInMap("roleIds")
        public java.util.List<String> roleIds;

        /**
         * <p>用户ID。</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetProjectMemebersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProjectMemebersResponseBodyResult self = new GetProjectMemebersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProjectMemebersResponseBodyResult setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public GetProjectMemebersResponseBodyResult setRole(Integer role) {
            this.role = role;
            return this;
        }
        public Integer getRole() {
            return this.role;
        }

        public GetProjectMemebersResponseBodyResult setRoleIds(java.util.List<String> roleIds) {
            this.roleIds = roleIds;
            return this;
        }
        public java.util.List<String> getRoleIds() {
            return this.roleIds;
        }

        public GetProjectMemebersResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
