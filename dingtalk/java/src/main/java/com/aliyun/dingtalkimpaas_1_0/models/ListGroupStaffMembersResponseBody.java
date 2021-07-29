// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class ListGroupStaffMembersResponseBody extends TeaModel {
    @NameInMap("members")
    public java.util.List<ListGroupStaffMembersResponseBodyMembers> members;

    public static ListGroupStaffMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListGroupStaffMembersResponseBody self = new ListGroupStaffMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListGroupStaffMembersResponseBody setMembers(java.util.List<ListGroupStaffMembersResponseBodyMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<ListGroupStaffMembersResponseBodyMembers> getMembers() {
        return this.members;
    }

    public static class ListGroupStaffMembersResponseBodyMembers extends TeaModel {
        @NameInMap("uid")
        public String uid;

        @NameInMap("nick")
        public String nick;

        public static ListGroupStaffMembersResponseBodyMembers build(java.util.Map<String, ?> map) throws Exception {
            ListGroupStaffMembersResponseBodyMembers self = new ListGroupStaffMembersResponseBodyMembers();
            return TeaModel.build(map, self);
        }

        public ListGroupStaffMembersResponseBodyMembers setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public ListGroupStaffMembersResponseBodyMembers setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

    }

}
