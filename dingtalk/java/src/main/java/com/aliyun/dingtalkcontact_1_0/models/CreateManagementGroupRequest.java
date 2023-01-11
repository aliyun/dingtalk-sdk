// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateManagementGroupRequest extends TeaModel {
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>管理组成员</p>
     */
    @NameInMap("members")
    public java.util.List<CreateManagementGroupRequestMembers> members;

    /**
     * <p>资源列表</p>
     */
    @NameInMap("resourceIds")
    public java.util.List<String> resourceIds;

    /**
     * <p>管理范围</p>
     */
    @NameInMap("scope")
    public CreateManagementGroupRequestScope scope;

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

    public CreateManagementGroupRequest setResourceIds(java.util.List<String> resourceIds) {
        this.resourceIds = resourceIds;
        return this;
    }
    public java.util.List<String> getResourceIds() {
        return this.resourceIds;
    }

    public CreateManagementGroupRequest setScope(CreateManagementGroupRequestScope scope) {
        this.scope = scope;
        return this;
    }
    public CreateManagementGroupRequestScope getScope() {
        return this.scope;
    }

    public static class CreateManagementGroupRequestMembers extends TeaModel {
        /**
         * <p>成员id</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>成员类型</p>
         */
        @NameInMap("memberType")
        public String memberType;

        public static CreateManagementGroupRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            CreateManagementGroupRequestMembers self = new CreateManagementGroupRequestMembers();
            return TeaModel.build(map, self);
        }

        public CreateManagementGroupRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public CreateManagementGroupRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class CreateManagementGroupRequestScope extends TeaModel {
        /**
         * <p>部门列表，只在scopeType=3 生效</p>
         */
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        /**
         * <p>范围类型</p>
         */
        @NameInMap("scopeType")
        public Integer scopeType;

        public static CreateManagementGroupRequestScope build(java.util.Map<String, ?> map) throws Exception {
            CreateManagementGroupRequestScope self = new CreateManagementGroupRequestScope();
            return TeaModel.build(map, self);
        }

        public CreateManagementGroupRequestScope setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public CreateManagementGroupRequestScope setScopeType(Integer scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public Integer getScopeType() {
            return this.scopeType;
        }

    }

}
