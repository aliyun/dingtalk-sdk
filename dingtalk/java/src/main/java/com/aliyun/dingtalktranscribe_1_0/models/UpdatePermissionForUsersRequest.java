// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionForUsersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public Integer bizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<UpdatePermissionForUsersRequestMembers> members;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskCreator")
    public Long taskCreator;

    @NameInMap("operatorUid")
    public Long operatorUid;

    public static UpdatePermissionForUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionForUsersRequest self = new UpdatePermissionForUsersRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionForUsersRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public UpdatePermissionForUsersRequest setMembers(java.util.List<UpdatePermissionForUsersRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<UpdatePermissionForUsersRequestMembers> getMembers() {
        return this.members;
    }

    public UpdatePermissionForUsersRequest setTaskCreator(Long taskCreator) {
        this.taskCreator = taskCreator;
        return this;
    }
    public Long getTaskCreator() {
        return this.taskCreator;
    }

    public UpdatePermissionForUsersRequest setOperatorUid(Long operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public Long getOperatorUid() {
        return this.operatorUid;
    }

    public static class UpdatePermissionForUsersRequestMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberId")
        public Long memberId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberType")
        public String memberType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("policyType")
        public String policyType;

        public static UpdatePermissionForUsersRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            UpdatePermissionForUsersRequestMembers self = new UpdatePermissionForUsersRequestMembers();
            return TeaModel.build(map, self);
        }

        public UpdatePermissionForUsersRequestMembers setMemberId(Long memberId) {
            this.memberId = memberId;
            return this;
        }
        public Long getMemberId() {
            return this.memberId;
        }

        public UpdatePermissionForUsersRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public UpdatePermissionForUsersRequestMembers setPolicyType(String policyType) {
            this.policyType = policyType;
            return this;
        }
        public String getPolicyType() {
            return this.policyType;
        }

    }

}
