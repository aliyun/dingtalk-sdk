// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class RoleMemberMapValue extends TeaModel {
    @NameInMap("roleCode")
    public String roleCode;

    @NameInMap("memberList")
    public java.util.List<RoleMemberMapValueMemberList> memberList;

    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    public static RoleMemberMapValue build(java.util.Map<String, ?> map) throws Exception {
        RoleMemberMapValue self = new RoleMemberMapValue();
        return TeaModel.build(map, self);
    }

    public RoleMemberMapValue setRoleCode(String roleCode) {
        this.roleCode = roleCode;
        return this;
    }
    public String getRoleCode() {
        return this.roleCode;
    }

    public RoleMemberMapValue setMemberList(java.util.List<RoleMemberMapValueMemberList> memberList) {
        this.memberList = memberList;
        return this;
    }
    public java.util.List<RoleMemberMapValueMemberList> getMemberList() {
        return this.memberList;
    }

    public RoleMemberMapValue setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public static class RoleMemberMapValueMemberList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>小明</p>
         */
        @NameInMap("nick")
        public String nick;

        /**
         * <strong>example:</strong>
         * <p><a href="https://xxxxxxx">https://xxxxxxx</a></p>
         */
        @NameInMap("avatarUrl")
        public String avatarUrl;

        public static RoleMemberMapValueMemberList build(java.util.Map<String, ?> map) throws Exception {
            RoleMemberMapValueMemberList self = new RoleMemberMapValueMemberList();
            return TeaModel.build(map, self);
        }

        public RoleMemberMapValueMemberList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public RoleMemberMapValueMemberList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public RoleMemberMapValueMemberList setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

    }

}
