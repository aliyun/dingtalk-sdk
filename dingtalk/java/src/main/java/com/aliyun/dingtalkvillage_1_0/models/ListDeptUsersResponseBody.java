// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUsersResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListDeptUsersResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static ListDeptUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUsersResponseBody self = new ListDeptUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeptUsersResponseBody setList(java.util.List<ListDeptUsersResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListDeptUsersResponseBodyList> getList() {
        return this.list;
    }

    public ListDeptUsersResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListDeptUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class ListDeptUsersResponseBodyList extends TeaModel {
        @NameInMap("userId")
        public String userId;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("jobNumber")
        public String jobNumber;

        @NameInMap("name")
        public String name;

        @NameInMap("deptIdList")
        public java.util.List<Long> deptIdList;

        @NameInMap("active")
        public Boolean active;

        public static ListDeptUsersResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListDeptUsersResponseBodyList self = new ListDeptUsersResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListDeptUsersResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListDeptUsersResponseBodyList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ListDeptUsersResponseBodyList setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public ListDeptUsersResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListDeptUsersResponseBodyList setDeptIdList(java.util.List<Long> deptIdList) {
            this.deptIdList = deptIdList;
            return this;
        }
        public java.util.List<Long> getDeptIdList() {
            return this.deptIdList;
        }

        public ListDeptUsersResponseBodyList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

}
