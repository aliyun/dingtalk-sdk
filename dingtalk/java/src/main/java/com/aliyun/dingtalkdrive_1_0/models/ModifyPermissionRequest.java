// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ModifyPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("members")
    public java.util.List<ModifyPermissionRequestMembers> members;

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

    public static ModifyPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        ModifyPermissionRequest self = new ModifyPermissionRequest();
        return TeaModel.build(map, self);
    }

    public ModifyPermissionRequest setMembers(java.util.List<ModifyPermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<ModifyPermissionRequestMembers> getMembers() {
        return this.members;
    }

    public ModifyPermissionRequest setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public ModifyPermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class ModifyPermissionRequestMembers extends TeaModel {
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

        public static ModifyPermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            ModifyPermissionRequestMembers self = new ModifyPermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public ModifyPermissionRequestMembers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ModifyPermissionRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public ModifyPermissionRequestMembers setMemberType(String memberType) {
            this.memberType = memberType;
            return this;
        }
        public String getMemberType() {
            return this.memberType;
        }

    }

}
