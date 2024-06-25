// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateManagementGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<CreateManagementGroupRequestMembers> members;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("resourceIds")
    public java.util.List<String> resourceIds;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>WB001</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user</p>
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
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1:全公司 2:所在部门 3:指定部门</p>
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
