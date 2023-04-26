// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptSimpleUsersResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("userList")
    public java.util.List<ListDeptSimpleUsersResponseBodyUserList> userList;

    public static ListDeptSimpleUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeptSimpleUsersResponseBody self = new ListDeptSimpleUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeptSimpleUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListDeptSimpleUsersResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListDeptSimpleUsersResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public ListDeptSimpleUsersResponseBody setUserList(java.util.List<ListDeptSimpleUsersResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<ListDeptSimpleUsersResponseBodyUserList> getUserList() {
        return this.userList;
    }

    public static class ListDeptSimpleUsersResponseBodyUserList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListDeptSimpleUsersResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListDeptSimpleUsersResponseBodyUserList self = new ListDeptSimpleUsersResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListDeptSimpleUsersResponseBodyUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListDeptSimpleUsersResponseBodyUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
