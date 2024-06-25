// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUpdateAuthInfoRequest extends TeaModel {
    @NameInMap("updateUserList")
    public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserList> updateUserList;

    public static DigitalStoreUpdateAuthInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUpdateAuthInfoRequest self = new DigitalStoreUpdateAuthInfoRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUpdateAuthInfoRequest setUpdateUserList(java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserList> updateUserList) {
        this.updateUserList = updateUserList;
        return this;
    }
    public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserList> getUpdateUserList() {
        return this.updateUserList;
    }

    public static class DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>区域督导</p>
         */
        @NameInMap("roleName")
        public String roleName;

        /**
         * <strong>example:</strong>
         * <p>255</p>
         */
        @NameInMap("sourceRoleId")
        public String sourceRoleId;

        public static DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList self = new DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList();
            return TeaModel.build(map, self);
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList setSourceRoleId(String sourceRoleId) {
            this.sourceRoleId = sourceRoleId;
            return this;
        }
        public String getSourceRoleId() {
            return this.sourceRoleId;
        }

    }

    public static class DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>8733901123</p>
         */
        @NameInMap("dingDeptId")
        public String dingDeptId;

        /**
         * <strong>example:</strong>
         * <p>998383831</p>
         */
        @NameInMap("sourceDeptId")
        public String sourceDeptId;

        public static DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList self = new DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList();
            return TeaModel.build(map, self);
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList setDingDeptId(String dingDeptId) {
            this.dingDeptId = dingDeptId;
            return this;
        }
        public String getDingDeptId() {
            return this.dingDeptId;
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList setSourceDeptId(String sourceDeptId) {
            this.sourceDeptId = sourceDeptId;
            return this;
        }
        public String getSourceDeptId() {
            return this.sourceDeptId;
        }

    }

    public static class DigitalStoreUpdateAuthInfoRequestUpdateUserList extends TeaModel {
        @NameInMap("roleList")
        public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList> roleList;

        @NameInMap("userAuthList")
        public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList> userAuthList;

        /**
         * <strong>example:</strong>
         * <p>0998182231</p>
         */
        @NameInMap("userId")
        public String userId;

        public static DigitalStoreUpdateAuthInfoRequestUpdateUserList build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreUpdateAuthInfoRequestUpdateUserList self = new DigitalStoreUpdateAuthInfoRequestUpdateUserList();
            return TeaModel.build(map, self);
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserList setRoleList(java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList> roleList) {
            this.roleList = roleList;
            return this;
        }
        public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList> getRoleList() {
            return this.roleList;
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserList setUserAuthList(java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList> userAuthList) {
            this.userAuthList = userAuthList;
            return this;
        }
        public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList> getUserAuthList() {
            return this.userAuthList;
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
