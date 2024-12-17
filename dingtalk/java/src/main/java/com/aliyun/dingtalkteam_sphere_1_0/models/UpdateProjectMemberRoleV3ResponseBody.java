// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectMemberRoleV3ResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<UpdateProjectMemberRoleV3ResponseBodyResult> result;

    public static UpdateProjectMemberRoleV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectMemberRoleV3ResponseBody self = new UpdateProjectMemberRoleV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateProjectMemberRoleV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public UpdateProjectMemberRoleV3ResponseBody setResult(java.util.List<UpdateProjectMemberRoleV3ResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<UpdateProjectMemberRoleV3ResponseBodyResult> getResult() {
        return this.result;
    }

    public static class UpdateProjectMemberRoleV3ResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("role")
        public Integer role;

        @NameInMap("roleIds")
        public java.util.List<String> roleIds;

        @NameInMap("userId")
        public String userId;

        public static UpdateProjectMemberRoleV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateProjectMemberRoleV3ResponseBodyResult self = new UpdateProjectMemberRoleV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateProjectMemberRoleV3ResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateProjectMemberRoleV3ResponseBodyResult setRole(Integer role) {
            this.role = role;
            return this;
        }
        public Integer getRole() {
            return this.role;
        }

        public UpdateProjectMemberRoleV3ResponseBodyResult setRoleIds(java.util.List<String> roleIds) {
            this.roleIds = roleIds;
            return this;
        }
        public java.util.List<String> getRoleIds() {
            return this.roleIds;
        }

        public UpdateProjectMemberRoleV3ResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
