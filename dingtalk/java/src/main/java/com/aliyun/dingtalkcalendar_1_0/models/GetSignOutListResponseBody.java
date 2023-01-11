// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignOutListResponseBody extends TeaModel {
    /**
     * <p>翻页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>签退信息</p>
     */
    @NameInMap("users")
    public java.util.List<GetSignOutListResponseBodyUsers> users;

    public static GetSignOutListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignOutListResponseBody self = new GetSignOutListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignOutListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetSignOutListResponseBody setUsers(java.util.List<GetSignOutListResponseBodyUsers> users) {
        this.users = users;
        return this;
    }
    public java.util.List<GetSignOutListResponseBodyUsers> getUsers() {
        return this.users;
    }

    public static class GetSignOutListResponseBodyUsers extends TeaModel {
        /**
         * <p>签退时间</p>
         */
        @NameInMap("checkOutTime")
        public Long checkOutTime;

        /**
         * <p>用户名</p>
         */
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("userId")
        public String userId;

        public static GetSignOutListResponseBodyUsers build(java.util.Map<String, ?> map) throws Exception {
            GetSignOutListResponseBodyUsers self = new GetSignOutListResponseBodyUsers();
            return TeaModel.build(map, self);
        }

        public GetSignOutListResponseBodyUsers setCheckOutTime(Long checkOutTime) {
            this.checkOutTime = checkOutTime;
            return this;
        }
        public Long getCheckOutTime() {
            return this.checkOutTime;
        }

        public GetSignOutListResponseBodyUsers setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetSignOutListResponseBodyUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
