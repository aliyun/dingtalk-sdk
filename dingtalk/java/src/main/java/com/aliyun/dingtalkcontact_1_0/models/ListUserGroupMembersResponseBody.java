// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListUserGroupMembersResponseBody extends TeaModel {
    @NameInMap("result")
    public ListUserGroupMembersResponseBodyResult result;

    public static ListUserGroupMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListUserGroupMembersResponseBody self = new ListUserGroupMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListUserGroupMembersResponseBody setResult(ListUserGroupMembersResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListUserGroupMembersResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListUserGroupMembersResponseBodyResultMembers extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListUserGroupMembersResponseBodyResultMembers build(java.util.Map<String, ?> map) throws Exception {
            ListUserGroupMembersResponseBodyResultMembers self = new ListUserGroupMembersResponseBodyResultMembers();
            return TeaModel.build(map, self);
        }

        public ListUserGroupMembersResponseBodyResultMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListUserGroupMembersResponseBodyResultMembers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListUserGroupMembersResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("members")
        public java.util.List<ListUserGroupMembersResponseBodyResultMembers> members;

        @NameInMap("nextOffset")
        public Long nextOffset;

        public static ListUserGroupMembersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListUserGroupMembersResponseBodyResult self = new ListUserGroupMembersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListUserGroupMembersResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public ListUserGroupMembersResponseBodyResult setMembers(java.util.List<ListUserGroupMembersResponseBodyResultMembers> members) {
            this.members = members;
            return this;
        }
        public java.util.List<ListUserGroupMembersResponseBodyResultMembers> getMembers() {
            return this.members;
        }

        public ListUserGroupMembersResponseBodyResult setNextOffset(Long nextOffset) {
            this.nextOffset = nextOffset;
            return this;
        }
        public Long getNextOffset() {
            return this.nextOffset;
        }

    }

}
