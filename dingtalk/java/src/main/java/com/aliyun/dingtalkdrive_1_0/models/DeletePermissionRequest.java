// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeletePermissionRequest extends TeaModel {
    // 权限角色
    @NameInMap("role")
    public String role;

    @NameInMap("members")
    public java.util.List<DeletePermissionRequestMembers> members;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static DeletePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeletePermissionRequest self = new DeletePermissionRequest();
        return TeaModel.build(map, self);
    }

    public DeletePermissionRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public DeletePermissionRequest setMembers(java.util.List<DeletePermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<DeletePermissionRequestMembers> getMembers() {
        return this.members;
    }

    public DeletePermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class DeletePermissionRequestMembers extends TeaModel {
        // 企业corpId
        @NameInMap("corpId")
        public String corpId;

        // 成员类型
        @NameInMap("memberType")
        public String memberType;

        // 成员id
        @NameInMap("memberId")
        public String memberId;

        public static DeletePermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            DeletePermissionRequestMembers self = new DeletePermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public DeletePermissionRequestMembers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public DeletePermissionRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

        public DeletePermissionRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

    }

}
