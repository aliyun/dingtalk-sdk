// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSimpleUsersByRoleResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListSimpleUsersByRoleResponseBodyList> list;

    @NameInMap("nextCursorString")
    public String nextCursorString;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static ListSimpleUsersByRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSimpleUsersByRoleResponseBody self = new ListSimpleUsersByRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSimpleUsersByRoleResponseBody setList(java.util.List<ListSimpleUsersByRoleResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListSimpleUsersByRoleResponseBodyList> getList() {
        return this.list;
    }

    public ListSimpleUsersByRoleResponseBody setNextCursorString(String nextCursorString) {
        this.nextCursorString = nextCursorString;
        return this;
    }
    public String getNextCursorString() {
        return this.nextCursorString;
    }

    public ListSimpleUsersByRoleResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListSimpleUsersByRoleResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class ListSimpleUsersByRoleResponseBodyList extends TeaModel {
        @NameInMap("userId")
        public String userId;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("jobNumber")
        public String jobNumber;

        @NameInMap("name")
        public String name;

        public static ListSimpleUsersByRoleResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListSimpleUsersByRoleResponseBodyList self = new ListSimpleUsersByRoleResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListSimpleUsersByRoleResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListSimpleUsersByRoleResponseBodyList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ListSimpleUsersByRoleResponseBodyList setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public ListSimpleUsersByRoleResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
