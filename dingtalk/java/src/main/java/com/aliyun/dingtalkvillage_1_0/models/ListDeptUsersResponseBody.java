// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUsersResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextCursor")
    public Long nextCursor;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userList")
    public java.util.List<ListDeptUsersResponseBodyUserList> userList;

    public static ListDeptUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUsersResponseBody self = new ListDeptUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDeptUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListDeptUsersResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListDeptUsersResponseBody setUserList(java.util.List<ListDeptUsersResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<ListDeptUsersResponseBodyUserList> getUserList() {
        return this.userList;
    }

    public static class ListDeptUsersResponseBodyUserList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("active")
        public Boolean active;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("departmentList")
        public java.util.List<Long> departmentList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobNumber")
        public String jobNumber;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ListDeptUsersResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListDeptUsersResponseBodyUserList self = new ListDeptUsersResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListDeptUsersResponseBodyUserList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public ListDeptUsersResponseBodyUserList setDepartmentList(java.util.List<Long> departmentList) {
            this.departmentList = departmentList;
            return this;
        }
        public java.util.List<Long> getDepartmentList() {
            return this.departmentList;
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

        public ListDeptUsersResponseBodyUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ListDeptUsersResponseBodyUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
