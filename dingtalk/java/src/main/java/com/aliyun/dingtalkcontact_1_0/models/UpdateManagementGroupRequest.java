// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateManagementGroupRequest extends TeaModel {
    @NameInMap("groupName")
    public String groupName;

    @NameInMap("members")
    public java.util.List<UpdateManagementGroupRequestMembers> members;

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
        @NameInMap("memberId")
        public String memberId;

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
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

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
