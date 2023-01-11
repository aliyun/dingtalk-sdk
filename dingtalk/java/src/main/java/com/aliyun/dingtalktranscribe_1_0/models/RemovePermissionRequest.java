// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class RemovePermissionRequest extends TeaModel {
    @NameInMap("bizType")
    public Integer bizType;

    @NameInMap("members")
    public java.util.List<RemovePermissionRequestMembers> members;

    /**
     * <p>任务的创建者uid</p>
     */
    @NameInMap("taskCreator")
    public Long taskCreator;

    /**
     * <p>闪记任务的闪记ID</p>
     */
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
         * <p>执行授权操作的闪记任务的任务Id</p>
         */
        @NameInMap("memberId")
        public Long memberId;

        /**
         * <p>要赋予用户的权限名称。该字段表示要授予特定用户的权限名称，由开发者填写。</p>
         * <br>
         * <p>EDITOR：可编辑权限</p>
         * <br>
         * <p>READ_DOWNLOAD：仅可查看、下载</p>
         * <br>
         * <p>READ：只读权限</p>
         */
        @NameInMap("memberType")
        public String memberType;

        /**
         * <p>要被移除的权限，枚举值类型。</p>
         * <p>"EDITOR", //可编辑权限</p>
         * <p>    "READ_DOWNLOAD", //仅可查看、下载的权限</p>
         * <p>    "READ"//只读权限</p>
         * <br>
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
