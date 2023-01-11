// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateManagementGroupRequest extends TeaModel {
    /**
     * <p>管理组名称</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>管理组成员</p>
     */
    @NameInMap("members")
    public java.util.List<UpdateManagementGroupRequestMembers> members;

    /**
     * <p>资源列表</p>
     */
    @NameInMap("resourceIds")
    public java.util.List<String> resourceIds;

    @NameInMap("scope")
    public UpdateManagementGroupRequestScope scope;

    public static UpdateManagementGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateManagementGroupRequest self = new UpdateManagementGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateManagementGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public UpdateManagementGroupRequest setMembers(java.util.List<UpdateManagementGroupRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<UpdateManagementGroupRequestMembers> getMembers() {
        return this.members;
    }

    public UpdateManagementGroupRequest setResourceIds(java.util.List<String> resourceIds) {
        this.resourceIds = resourceIds;
        return this;
    }
    public java.util.List<String> getResourceIds() {
        return this.resourceIds;
    }

    public UpdateManagementGroupRequest setScope(UpdateManagementGroupRequestScope scope) {
        this.scope = scope;
        return this;
    }
    public UpdateManagementGroupRequestScope getScope() {
        return this.scope;
    }

    public static class UpdateManagementGroupRequestMembers extends TeaModel {
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

        public static UpdateManagementGroupRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            UpdateManagementGroupRequestMembers self = new UpdateManagementGroupRequestMembers();
            return TeaModel.build(map, self);
        }

        public UpdateManagementGroupRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public UpdateManagementGroupRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

    public static class UpdateManagementGroupRequestScope extends TeaModel {
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

        public static UpdateManagementGroupRequestScope build(java.util.Map<String, ?> map) throws Exception {
            UpdateManagementGroupRequestScope self = new UpdateManagementGroupRequestScope();
            return TeaModel.build(map, self);
        }

        public UpdateManagementGroupRequestScope setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public UpdateManagementGroupRequestScope setScopeType(Integer scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public Integer getScopeType() {
            return this.scopeType;
        }

    }

}
