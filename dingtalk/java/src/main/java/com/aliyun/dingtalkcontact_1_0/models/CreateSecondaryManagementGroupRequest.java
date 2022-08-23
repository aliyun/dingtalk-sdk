// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateSecondaryManagementGroupRequest extends TeaModel {
    // 管理组名称
    @NameInMap("groupName")
    public String groupName;

    // 管理组成员列表
    @NameInMap("members")
    public java.util.List<CreateSecondaryManagementGroupRequestMembers> members;

    // 资源id列表
    @NameInMap("resourceIds")
    public java.util.List<String> resourceIds;

    // 管理组权限范围信息
    @NameInMap("scope")
    public CreateSecondaryManagementGroupRequestScope scope;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static CreateSecondaryManagementGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSecondaryManagementGroupRequest self = new CreateSecondaryManagementGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateSecondaryManagementGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateSecondaryManagementGroupRequest setMembers(java.util.List<CreateSecondaryManagementGroupRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<CreateSecondaryManagementGroupRequestMembers> getMembers() {
        return this.members;
    }

    public CreateSecondaryManagementGroupRequest setResourceIds(java.util.List<String> resourceIds) {
        this.resourceIds = resourceIds;
        return this;
    }
    public java.util.List<String> getResourceIds() {
        return this.resourceIds;
    }

    public CreateSecondaryManagementGroupRequest setScope(CreateSecondaryManagementGroupRequestScope scope) {
        this.scope = scope;
        return this;
    }
    public CreateSecondaryManagementGroupRequestScope getScope() {
        return this.scope;
    }

    public CreateSecondaryManagementGroupRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CreateSecondaryManagementGroupRequestMembers extends TeaModel {
        // 员工id
        @NameInMap("memberId")
        public String memberId;

        // 员工类型
        @NameInMap("memberType")
        public String memberType;

        public static CreateSecondaryManagementGroupRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            CreateSecondaryManagementGroupRequestMembers self = new CreateSecondaryManagementGroupRequestMembers();
            return TeaModel.build(map, self);
        }

        public CreateSecondaryManagementGroupRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public CreateSecondaryManagementGroupRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class CreateSecondaryManagementGroupRequestScope extends TeaModel {
        // 部门id列表
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        // 权限范围
        @NameInMap("scopeType")
        public Integer scopeType;

        public static CreateSecondaryManagementGroupRequestScope build(java.util.Map<String, ?> map) throws Exception {
            CreateSecondaryManagementGroupRequestScope self = new CreateSecondaryManagementGroupRequestScope();
            return TeaModel.build(map, self);
        }

        public CreateSecondaryManagementGroupRequestScope setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public CreateSecondaryManagementGroupRequestScope setScopeType(Integer scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public Integer getScopeType() {
            return this.scopeType;
        }

    }

}
