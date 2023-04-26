// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignInListResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("users")
    public java.util.List<GetSignInListResponseBodyUsers> users;

    public static GetSignInListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignInListResponseBody self = new GetSignInListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignInListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetSignInListResponseBody setUsers(java.util.List<GetSignInListResponseBodyUsers> users) {
        this.users = users;
        return this;
    }
    public java.util.List<GetSignInListResponseBodyUsers> getUsers() {
        return this.users;
    }

    public static class GetSignInListResponseBodyUsers extends TeaModel {
        @NameInMap("checkInTime")
        public Long checkInTime;

        @NameInMap("displayName")
        public String displayName;

        @NameInMap("userId")
        public String userId;

        public static GetSignInListResponseBodyUsers build(java.util.Map<String, ?> map) throws Exception {
            GetSignInListResponseBodyUsers self = new GetSignInListResponseBodyUsers();
            return TeaModel.build(map, self);
        }

        public GetSignInListResponseBodyUsers setCheckInTime(Long checkInTime) {
            this.checkInTime = checkInTime;
            return this;
        }
        public Long getCheckInTime() {
            return this.checkInTime;
        }

        public GetSignInListResponseBodyUsers setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetSignInListResponseBodyUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
