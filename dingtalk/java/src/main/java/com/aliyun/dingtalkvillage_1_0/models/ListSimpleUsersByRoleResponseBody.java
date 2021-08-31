// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSimpleUsersByRoleResponseBody extends TeaModel {
    // 用户列表
    @NameInMap("userList")
    public java.util.List<ListSimpleUsersByRoleResponseBodyUserList> userList;

    // 下一条记录
    @NameInMap("nextCursor")
    public Long nextCursor;

    // 是否还有记录
    @NameInMap("hasMore")
    public Boolean hasMore;

    public static ListSimpleUsersByRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSimpleUsersByRoleResponseBody self = new ListSimpleUsersByRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSimpleUsersByRoleResponseBody setUserList(java.util.List<ListSimpleUsersByRoleResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<ListSimpleUsersByRoleResponseBodyUserList> getUserList() {
        return this.userList;
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

    public static class ListSimpleUsersByRoleResponseBodyUserList extends TeaModel {
        // 用户ID
        @NameInMap("userId")
        public String userId;

        // unionId
        @NameInMap("unionId")
        public String unionId;

        // 工号
        @NameInMap("jobNumber")
        public String jobNumber;

        // 姓名
        @NameInMap("name")
        public String name;

        public static ListSimpleUsersByRoleResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            ListSimpleUsersByRoleResponseBodyUserList self = new ListSimpleUsersByRoleResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public ListSimpleUsersByRoleResponseBodyUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListSimpleUsersByRoleResponseBodyUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
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

    }

}
