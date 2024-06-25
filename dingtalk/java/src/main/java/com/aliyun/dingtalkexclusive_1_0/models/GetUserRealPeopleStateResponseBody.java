// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserRealPeopleStateResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetUserRealPeopleStateResponseBodyData> data;

    public static GetUserRealPeopleStateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserRealPeopleStateResponseBody self = new GetUserRealPeopleStateResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserRealPeopleStateResponseBody setData(java.util.List<GetUserRealPeopleStateResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetUserRealPeopleStateResponseBodyData> getData() {
        return this.data;
    }

    public static class GetUserRealPeopleStateResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("state")
        public Integer state;

        /**
         * <strong>example:</strong>
         * <p>userId</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetUserRealPeopleStateResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUserRealPeopleStateResponseBodyData self = new GetUserRealPeopleStateResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUserRealPeopleStateResponseBodyData setState(Integer state) {
            this.state = state;
            return this;
        }
        public Integer getState() {
            return this.state;
        }

        public GetUserRealPeopleStateResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
