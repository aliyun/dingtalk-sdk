// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionForUsersRequest extends TeaModel {
    /**
     * <p>闪记任务的类型。枚举值，从任务详情中获取。</p>
     */
    @NameInMap("bizType")
    public Integer bizType;

    /**
     * <p>被授权的用户信息列表</p>
     */
    @NameInMap("members")
    public java.util.List<UpdatePermissionForUsersRequestMembers> members;

    /**
     * <p>要操作的闪记任务的创建者userId。</p>
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
