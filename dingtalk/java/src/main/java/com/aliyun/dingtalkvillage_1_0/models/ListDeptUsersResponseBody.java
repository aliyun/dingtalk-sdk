// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUsersResponseBody extends TeaModel {
    // 用户列表
    @NameInMap("userList")
    public java.util.List<ListDeptUsersResponseBodyUserList> userList;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static ListDeptUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUsersResponseBody self = new ListDeptUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeptUsersResponseBody setUserList(java.util.List<ListDeptUsersResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<ListDeptUsersResponseBodyUserList> getUserList() {
        return this.userList;
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

    public static class ListDeptUsersResponseBodyUserList extends TeaModel {
        // 用户ID
        @NameInMap("userId")
        public String userId;

        // unionId
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("jobNumber")
        public String jobNumber;

        @NameInMap("name")
        public String name;

        // 部门ID列表
        @NameInMap("departmentList")
        public java.util.List<Long> departmentList;

        @NameInMap("active")
        public Boolean active;

        public static ListDeptUsersResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListDeptUsersResponseBodyUserList self = new ListDeptUsersResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListDeptUsersResponseBodyUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListDeptUsersResponseBodyUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ListDeptUsersResponseBodyUserList setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public ListDeptUsersResponseBodyUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListDeptUsersResponseBodyUserList setDepartmentList(java.util.List<Long> departmentList) {
            this.departmentList = departmentList;
            return this;
        }
        public java.util.List<Long> getDepartmentList() {
            return this.departmentList;
        }

        public ListDeptUsersResponseBodyUserList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

}
