// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class AddPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<AddPermissionRequestMembers> members;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("role")
    public String role;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        AddPermissionRequest self = new AddPermissionRequest();
        return TeaModel.build(map, self);
    }

    public AddPermissionRequest setMembers(java.util.List<AddPermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<AddPermissionRequestMembers> getMembers() {
        return this.members;
    }

    public AddPermissionRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public AddPermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class AddPermissionRequestMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberType")
        public String memberType;

        public static AddPermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            AddPermissionRequestMembers self = new AddPermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public AddPermissionRequestMembers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddPermissionRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public AddPermissionRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

}
