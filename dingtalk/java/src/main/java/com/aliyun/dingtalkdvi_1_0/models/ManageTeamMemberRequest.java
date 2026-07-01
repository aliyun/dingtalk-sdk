// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ManageTeamMemberRequest extends TeaModel {
    @NameInMap("addMembers")
    public ManageTeamMemberRequestAddMembers addMembers;

    @NameInMap("removeMembers")
    public ManageTeamMemberRequestRemoveMembers removeMembers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teamCode")
    public String teamCode;

    public static ManageTeamMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        ManageTeamMemberRequest self = new ManageTeamMemberRequest();
        return TeaModel.build(map, self);
    }

    public ManageTeamMemberRequest setAddMembers(ManageTeamMemberRequestAddMembers addMembers) {
        this.addMembers = addMembers;
        return this;
    }
    public ManageTeamMemberRequestAddMembers getAddMembers() {
        return this.addMembers;
    }

    public ManageTeamMemberRequest setRemoveMembers(ManageTeamMemberRequestRemoveMembers removeMembers) {
        this.removeMembers = removeMembers;
        return this;
    }
    public ManageTeamMemberRequestRemoveMembers getRemoveMembers() {
        return this.removeMembers;
    }

    public ManageTeamMemberRequest setTeamCode(String teamCode) {
        this.teamCode = teamCode;
        return this;
    }
    public String getTeamCode() {
        return this.teamCode;
    }

    public static class ManageTeamMemberRequestAddMembers extends TeaModel {
        @NameInMap("adminUserIds")
        public java.util.List<String> adminUserIds;

        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static ManageTeamMemberRequestAddMembers build(java.util.Map<String, ?> map) throws Exception {
            ManageTeamMemberRequestAddMembers self = new ManageTeamMemberRequestAddMembers();
            return TeaModel.build(map, self);
        }

        public ManageTeamMemberRequestAddMembers setAdminUserIds(java.util.List<String> adminUserIds) {
            this.adminUserIds = adminUserIds;
            return this;
        }
        public java.util.List<String> getAdminUserIds() {
            return this.adminUserIds;
        }

        public ManageTeamMemberRequestAddMembers setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public ManageTeamMemberRequestAddMembers setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

    public static class ManageTeamMemberRequestRemoveMembers extends TeaModel {
        @NameInMap("adminUserIds")
        public java.util.List<String> adminUserIds;

        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static ManageTeamMemberRequestRemoveMembers build(java.util.Map<String, ?> map) throws Exception {
            ManageTeamMemberRequestRemoveMembers self = new ManageTeamMemberRequestRemoveMembers();
            return TeaModel.build(map, self);
        }

        public ManageTeamMemberRequestRemoveMembers setAdminUserIds(java.util.List<String> adminUserIds) {
            this.adminUserIds = adminUserIds;
            return this;
        }
        public java.util.List<String> getAdminUserIds() {
            return this.adminUserIds;
        }

        public ManageTeamMemberRequestRemoveMembers setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public ManageTeamMemberRequestRemoveMembers setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
