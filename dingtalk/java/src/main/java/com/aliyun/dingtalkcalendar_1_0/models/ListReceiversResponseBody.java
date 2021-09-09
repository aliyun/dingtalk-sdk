// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListReceiversResponseBody extends TeaModel {
    // 翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 用户详情
    @NameInMap("users")
    public java.util.List<ListReceiversResponseBodyUsers> users;

    public static ListReceiversResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListReceiversResponseBody self = new ListReceiversResponseBody();
        return TeaModel.build(map, self);
    }

    public ListReceiversResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListReceiversResponseBody setUsers(java.util.List<ListReceiversResponseBodyUsers> users) {
        this.users = users;
        return this;
    }
    public java.util.List<ListReceiversResponseBodyUsers> getUsers() {
        return this.users;
    }

    public static class ListReceiversResponseBodyUsers extends TeaModel {
        // 用户id
        @NameInMap("id")
        public String id;

        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 签到状态
        @NameInMap("checkInStatus")
        public Long checkInStatus;

        // 签到时间
        @NameInMap("checkInTime")
        public Long checkInTime;

        public static ListReceiversResponseBodyUsers build(java.util.Map<String, ?> map) throws Exception {
            ListReceiversResponseBodyUsers self = new ListReceiversResponseBodyUsers();
            return TeaModel.build(map, self);
        }

        public ListReceiversResponseBodyUsers setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListReceiversResponseBodyUsers setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListReceiversResponseBodyUsers setCheckInStatus(Long checkInStatus) {
            this.checkInStatus = checkInStatus;
            return this;
        }
        public Long getCheckInStatus() {
            return this.checkInStatus;
        }

        public ListReceiversResponseBodyUsers setCheckInTime(Long checkInTime) {
            this.checkInTime = checkInTime;
            return this;
        }
        public Long getCheckInTime() {
            return this.checkInTime;
        }

    }

}
