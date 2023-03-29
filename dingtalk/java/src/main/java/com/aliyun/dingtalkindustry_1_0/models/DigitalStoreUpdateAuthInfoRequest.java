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
        @NameInMap("roleName")
        public String roleName;

        @NameInMap("sourceRoleId")
        public Long sourceRoleId;

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

        public DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList setSourceRoleId(Long sourceRoleId) {
            this.sourceRoleId = sourceRoleId;
            return this;
        }
        public Long getSourceRoleId() {
            return this.sourceRoleId;
        }

    }

    public static class DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList extends TeaModel {
        @NameInMap("dingDeptId")
        public Long dingDeptId;

        @NameInMap("sourceDeptId")
        public Long sourceDeptId;

        public static DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList self = new DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList();
            return TeaModel.build(map, self);
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList setDingDeptId(Long dingDeptId) {
            this.dingDeptId = dingDeptId;
            return this;
        }
        public Long getDingDeptId() {
            return this.dingDeptId;
        }

        public DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList setSourceDeptId(Long sourceDeptId) {
            this.sourceDeptId = sourceDeptId;
            return this;
        }
        public Long getSourceDeptId() {
            return this.sourceDeptId;
        }

    }

    public static class DigitalStoreUpdateAuthInfoRequestUpdateUserList extends TeaModel {
        @NameInMap("roleList")
        public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList> roleList;

        @NameInMap("userAuthList")
        public java.util.List<DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList> userAuthList;

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
