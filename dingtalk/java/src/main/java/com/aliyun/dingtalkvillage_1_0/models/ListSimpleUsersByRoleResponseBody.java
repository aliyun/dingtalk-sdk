// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSimpleUsersByRoleResponseBody extends TeaModel {
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
    public java.util.List<ListSimpleUsersByRoleResponseBodyUserList> userList;

    public static ListSimpleUsersByRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSimpleUsersByRoleResponseBody self = new ListSimpleUsersByRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSimpleUsersByRoleResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListSimpleUsersByRoleResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListSimpleUsersByRoleResponseBody setUserList(java.util.List<ListSimpleUsersByRoleResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<ListSimpleUsersByRoleResponseBodyUserList> getUserList() {
        return this.userList;
    }

    public static class ListSimpleUsersByRoleResponseBodyUserList extends TeaModel {
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

        public static ListSimpleUsersByRoleResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListSimpleUsersByRoleResponseBodyUserList self = new ListSimpleUsersByRoleResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListSimpleUsersByRoleResponseBodyUserList setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public ListSimpleUsersByRoleResponseBodyUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListSimpleUsersByRoleResponseBodyUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ListSimpleUsersByRoleResponseBodyUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
