// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptSimpleUsersResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListDeptSimpleUsersResponseBodyList> list;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static ListDeptSimpleUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeptSimpleUsersResponseBody self = new ListDeptSimpleUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeptSimpleUsersResponseBody setList(java.util.List<ListDeptSimpleUsersResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListDeptSimpleUsersResponseBodyList> getList() {
        return this.list;
    }

    public ListDeptSimpleUsersResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public ListDeptSimpleUsersResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListDeptSimpleUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class ListDeptSimpleUsersResponseBodyList extends TeaModel {
        @NameInMap("userId")
        public String userId;

        @NameInMap("name")
        public String name;

        public static ListDeptSimpleUsersResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListDeptSimpleUsersResponseBodyList self = new ListDeptSimpleUsersResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListDeptSimpleUsersResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListDeptSimpleUsersResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
