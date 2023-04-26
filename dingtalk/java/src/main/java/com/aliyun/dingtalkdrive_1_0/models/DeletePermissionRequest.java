// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeletePermissionRequest extends TeaModel {
    @NameInMap("members")
    public java.util.List<DeletePermissionRequestMembers> members;

    @NameInMap("role")
    public String role;

    @NameInMap("unionId")
    public String unionId;

    public static DeletePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeletePermissionRequest self = new DeletePermissionRequest();
        return TeaModel.build(map, self);
    }

    public DeletePermissionRequest setMembers(java.util.List<DeletePermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<DeletePermissionRequestMembers> getMembers() {
        return this.members;
    }

    public DeletePermissionRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public DeletePermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class DeletePermissionRequestMembers extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("memberId")
        public String memberId;

        @NameInMap("memberType")
        public String memberType;

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

        public DeletePermissionRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public DeletePermissionRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

}
