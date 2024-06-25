// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class RemovePermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public Integer bizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<RemovePermissionRequestMembers> members;

    @NameInMap("taskCreator")
    public Long taskCreator;

    @NameInMap("taskId")
    public Long taskId;

    public static RemovePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        RemovePermissionRequest self = new RemovePermissionRequest();
        return TeaModel.build(map, self);
    }

    public RemovePermissionRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public RemovePermissionRequest setMembers(java.util.List<RemovePermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<RemovePermissionRequestMembers> getMembers() {
        return this.members;
    }

    public RemovePermissionRequest setTaskCreator(Long taskCreator) {
        this.taskCreator = taskCreator;
        return this;
    }
    public Long getTaskCreator() {
        return this.taskCreator;
    }

    public RemovePermissionRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public static class RemovePermissionRequestMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>533xxxxxx</p>
         */
        @NameInMap("memberId")
        public Long memberId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>EDITOR</p>
         */
        @NameInMap("memberType")
        public String memberType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("policyType")
        public String policyType;

        public static RemovePermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            RemovePermissionRequestMembers self = new RemovePermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public RemovePermissionRequestMembers setMemberId(Long memberId) {
            this.memberId = memberId;
            return this;
        }
        public Long getMemberId() {
            return this.memberId;
        }

        public RemovePermissionRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public RemovePermissionRequestMembers setPolicyType(String policyType) {
            this.policyType = policyType;
            return this;
        }
        public String getPolicyType() {
            return this.policyType;
        }

    }

}
