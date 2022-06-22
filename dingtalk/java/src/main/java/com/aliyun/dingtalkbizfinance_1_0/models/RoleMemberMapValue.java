// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class RoleMemberMapValue extends TeaModel {
    // 角色唯一标识
    @NameInMap("roleCode")
    public String roleCode;

    // 成员信息列表
    @NameInMap("memberList")
    public java.util.List<RoleMemberMapValueMemberList> memberList;

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

    public static class RoleMemberMapValueMemberList extends TeaModel {
        // 用户ID
        @NameInMap("userId")
        public String userId;

        // 昵称
        @NameInMap("nick")
        public String nick;

        // 头像URL
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
