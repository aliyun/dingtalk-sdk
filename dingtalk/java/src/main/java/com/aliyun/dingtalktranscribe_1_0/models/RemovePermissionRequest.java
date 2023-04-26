// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class RemovePermissionRequest extends TeaModel {
    @NameInMap("bizType")
    public Integer bizType;

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
        @NameInMap("memberId")
        public Long memberId;

        @NameInMap("memberType")
        public String memberType;

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
