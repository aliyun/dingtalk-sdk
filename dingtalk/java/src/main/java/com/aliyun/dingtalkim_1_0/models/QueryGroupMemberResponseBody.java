// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberResponseBody extends TeaModel {
    // 群成员列表。
    @NameInMap("groupMembers")
    public java.util.List<QueryGroupMemberResponseBodyGroupMembers> groupMembers;

    // 群会话Id。
    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberResponseBody self = new QueryGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberResponseBody setGroupMembers(java.util.List<QueryGroupMemberResponseBodyGroupMembers> groupMembers) {
        this.groupMembers = groupMembers;
        return this;
    }
    public java.util.List<QueryGroupMemberResponseBodyGroupMembers> getGroupMembers() {
        return this.groupMembers;
    }

    public QueryGroupMemberResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public static class QueryGroupMemberResponseBodyGroupMembers extends TeaModel {
        // 群成员头像。
        @NameInMap("groupMemberAvatar")
        public String groupMemberAvatar;

        // 群成员动态信息。
        @NameInMap("groupMemberDynamics")
        public String groupMemberDynamics;

        // 群成员Id。
        @NameInMap("groupMemberId")
        public String groupMemberId;

        // 群成员名称。
        @NameInMap("groupMemberName")
        public String groupMemberName;

        // 群成员类型。
        @NameInMap("groupMemberType")
        public Integer groupMemberType;

        public static QueryGroupMemberResponseBodyGroupMembers build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupMemberResponseBodyGroupMembers self = new QueryGroupMemberResponseBodyGroupMembers();
            return TeaModel.build(map, self);
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberAvatar(String groupMemberAvatar) {
            this.groupMemberAvatar = groupMemberAvatar;
            return this;
        }
        public String getGroupMemberAvatar() {
            return this.groupMemberAvatar;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberDynamics(String groupMemberDynamics) {
            this.groupMemberDynamics = groupMemberDynamics;
            return this;
        }
        public String getGroupMemberDynamics() {
            return this.groupMemberDynamics;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberId(String groupMemberId) {
            this.groupMemberId = groupMemberId;
            return this;
        }
        public String getGroupMemberId() {
            return this.groupMemberId;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberName(String groupMemberName) {
            this.groupMemberName = groupMemberName;
            return this;
        }
        public String getGroupMemberName() {
            return this.groupMemberName;
        }

        public QueryGroupMemberResponseBodyGroupMembers setGroupMemberType(Integer groupMemberType) {
            this.groupMemberType = groupMemberType;
            return this;
        }
        public Integer getGroupMemberType() {
            return this.groupMemberType;
        }

    }

}
