// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppRolesToMemberRequest extends TeaModel {
    @NameInMap("memberId")
    public String memberId;

    @NameInMap("memberType")
    public String memberType;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("roleList")
    public java.util.List<AddAppRolesToMemberRequestRoleList> roleList;

    public static AddAppRolesToMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddAppRolesToMemberRequest self = new AddAppRolesToMemberRequest();
        return TeaModel.build(map, self);
    }

    public AddAppRolesToMemberRequest setMemberId(String memberId) {
        this.memberId = memberId;
        return this;
    }
    public String getMemberId() {
        return this.memberId;
    }

    public AddAppRolesToMemberRequest setMemberType(String memberType) {
        this.memberType = memberType;
        return this;
    }
    public String getMemberType() {
        return this.memberType;
    }

    public AddAppRolesToMemberRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public AddAppRolesToMemberRequest setRoleList(java.util.List<AddAppRolesToMemberRequestRoleList> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<AddAppRolesToMemberRequestRoleList> getRoleList() {
        return this.roleList;
    }

    public static class AddAppRolesToMemberRequestRoleList extends TeaModel {
        @NameInMap("roleId")
        public Long roleId;

        @NameInMap("scopeVersion")
        public Long scopeVersion;

        public static AddAppRolesToMemberRequestRoleList build(java.util.Map<String, ?> map) throws Exception {
            AddAppRolesToMemberRequestRoleList self = new AddAppRolesToMemberRequestRoleList();
            return TeaModel.build(map, self);
        }

        public AddAppRolesToMemberRequestRoleList setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public AddAppRolesToMemberRequestRoleList setScopeVersion(Long scopeVersion) {
            this.scopeVersion = scopeVersion;
            return this;
        }
        public Long getScopeVersion() {
            return this.scopeVersion;
        }

    }

}
