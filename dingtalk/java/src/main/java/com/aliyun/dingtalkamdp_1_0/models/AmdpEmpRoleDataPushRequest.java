// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpEmpRoleDataPushRequest extends TeaModel {
    @NameInMap("param")
    public java.util.List<AmdpEmpRoleDataPushRequestParam> param;

    public static AmdpEmpRoleDataPushRequest build(java.util.Map<String, ?> map) throws Exception {
        AmdpEmpRoleDataPushRequest self = new AmdpEmpRoleDataPushRequest();
        return TeaModel.build(map, self);
    }

    public AmdpEmpRoleDataPushRequest setParam(java.util.List<AmdpEmpRoleDataPushRequestParam> param) {
        this.param = param;
        return this;
    }
    public java.util.List<AmdpEmpRoleDataPushRequestParam> getParam() {
        return this.param;
    }

    public static class AmdpEmpRoleDataPushRequestParam extends TeaModel {
        @NameInMap("deptId")
        public String deptId;

        @NameInMap("isDelete")
        public String isDelete;

        @NameInMap("roleCode")
        public String roleCode;

        @NameInMap("userId")
        public String userId;

        public static AmdpEmpRoleDataPushRequestParam build(java.util.Map<String, ?> map) throws Exception {
            AmdpEmpRoleDataPushRequestParam self = new AmdpEmpRoleDataPushRequestParam();
            return TeaModel.build(map, self);
        }

        public AmdpEmpRoleDataPushRequestParam setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public AmdpEmpRoleDataPushRequestParam setIsDelete(String isDelete) {
            this.isDelete = isDelete;
            return this;
        }
        public String getIsDelete() {
            return this.isDelete;
        }

        public AmdpEmpRoleDataPushRequestParam setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public AmdpEmpRoleDataPushRequestParam setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
