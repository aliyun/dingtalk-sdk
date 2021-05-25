// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateManagementGroupRequest extends TeaModel {
    @NameInMap("groupName")
    public String groupName;

    // 管理组成员
    @NameInMap("members")
    public java.util.List<CreateManagementGroupRequestMembers> members;

    // 管理范围
    @NameInMap("scope")
    public CreateManagementGroupRequestScope scope;

    // 资源列表
    @NameInMap("resourceIds")
    public java.util.List<String> resourceIds;

    public static CreateManagementGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateManagementGroupRequest self = new CreateManagementGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateManagementGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateManagementGroupRequest setMembers(java.util.List<CreateManagementGroupRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<CreateManagementGroupRequestMembers> getMembers() {
        return this.members;
    }

    public CreateManagementGroupRequest setScope(CreateManagementGroupRequestScope scope) {
        this.scope = scope;
        return this;
    }
    public CreateManagementGroupRequestScope getScope() {
        return this.scope;
    }

    public CreateManagementGroupRequest setResourceIds(java.util.List<String> resourceIds) {
        this.resourceIds = resourceIds;
        return this;
    }
    public java.util.List<String> getResourceIds() {
        return this.resourceIds;
    }

    public static class CreateManagementGroupRequestMembers extends TeaModel {
        // 成员类型
        @NameInMap("memberType")
        public String memberType;

        // 成员id
        @NameInMap("memberId")
        public String memberId;

        public static CreateManagementGroupRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            CreateManagementGroupRequestMembers self = new CreateManagementGroupRequestMembers();
            return TeaModel.build(map, self);
        }

        public CreateManagementGroupRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public CreateManagementGroupRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

    }

    public static class CreateManagementGroupRequestScope extends TeaModel {
        // 范围类型
        @NameInMap("scopeType")
        public Integer scopeType;

        // 部门列表，只在scopeType=3 生效
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        public static CreateManagementGroupRequestScope build(java.util.Map<String, ?> map) throws Exception {
            CreateManagementGroupRequestScope self = new CreateManagementGroupRequestScope();
            return TeaModel.build(map, self);
        }

        public CreateManagementGroupRequestScope setScopeType(Integer scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public Integer getScopeType() {
            return this.scopeType;
        }

        public CreateManagementGroupRequestScope setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

    }

}
