// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserFaceStateResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetUserFaceStateResponseBodyData> data;

    public static GetUserFaceStateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserFaceStateResponseBody self = new GetUserFaceStateResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserFaceStateResponseBody setData(java.util.List<GetUserFaceStateResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetUserFaceStateResponseBodyData> getData() {
        return this.data;
    }

    public static class GetUserFaceStateResponseBodyData extends TeaModel {
        @NameInMap("state")
        public Integer state;

        @NameInMap("userId")
        public String userId;

        public static GetUserFaceStateResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUserFaceStateResponseBodyData self = new GetUserFaceStateResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUserFaceStateResponseBodyData setState(Integer state) {
            this.state = state;
            return this;
        }
        public Integer getState() {
            return this.state;
        }

        public GetUserFaceStateResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
