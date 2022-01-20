// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListAttendeesResponseBody extends TeaModel {
    // 参与人
    @NameInMap("attendees")
    public java.util.List<ListAttendeesResponseBodyAttendees> attendees;

    // 翻页token
    @NameInMap("nextToken")
    public String nextToken;

    public static ListAttendeesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAttendeesResponseBody self = new ListAttendeesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAttendeesResponseBody setAttendees(java.util.List<ListAttendeesResponseBodyAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<ListAttendeesResponseBodyAttendees> getAttendees() {
        return this.attendees;
    }

    public ListAttendeesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListAttendeesResponseBodyAttendees extends TeaModel {
        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 用户id
        @NameInMap("id")
        public String id;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        // 是否当前用户
        @NameInMap("self")
        public Boolean self;

        public static ListAttendeesResponseBodyAttendees build(java.util.Map<String, ?> map) throws Exception {
            ListAttendeesResponseBodyAttendees self = new ListAttendeesResponseBodyAttendees();
            return TeaModel.build(map, self);
        }

        public ListAttendeesResponseBodyAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListAttendeesResponseBodyAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListAttendeesResponseBodyAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListAttendeesResponseBodyAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

}
