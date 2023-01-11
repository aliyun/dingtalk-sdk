// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserFaceStateResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
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
        /**
         * <p>人脸录入状态 1-无人脸 2-有人脸</p>
         */
        @NameInMap("state")
        public Integer state;

        /**
         * <p>userId</p>
         */
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
