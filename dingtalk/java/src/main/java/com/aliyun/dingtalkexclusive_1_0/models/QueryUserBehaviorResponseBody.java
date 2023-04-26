// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBehaviorResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<QueryUserBehaviorResponseBodyData> data;

    @NameInMap("dataCnt")
    public Integer dataCnt;

    @NameInMap("totalCnt")
    public Integer totalCnt;

    public static QueryUserBehaviorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserBehaviorResponseBody self = new QueryUserBehaviorResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserBehaviorResponseBody setData(java.util.List<QueryUserBehaviorResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryUserBehaviorResponseBodyData> getData() {
        return this.data;
    }

    public QueryUserBehaviorResponseBody setDataCnt(Integer dataCnt) {
        this.dataCnt = dataCnt;
        return this;
    }
    public Integer getDataCnt() {
        return this.dataCnt;
    }

    public QueryUserBehaviorResponseBody setTotalCnt(Integer totalCnt) {
        this.totalCnt = totalCnt;
        return this;
    }
    public Integer getTotalCnt() {
        return this.totalCnt;
    }

    public static class QueryUserBehaviorResponseBodyData extends TeaModel {
        @NameInMap("pictureUrl")
        public String pictureUrl;

        @NameInMap("platform")
        public Integer platform;

        @NameInMap("scene")
        public String scene;

        @NameInMap("time")
        public Long time;

        @NameInMap("type")
        public Integer type;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static QueryUserBehaviorResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryUserBehaviorResponseBodyData self = new QueryUserBehaviorResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryUserBehaviorResponseBodyData setPictureUrl(String pictureUrl) {
            this.pictureUrl = pictureUrl;
            return this;
        }
        public String getPictureUrl() {
            return this.pictureUrl;
        }

        public QueryUserBehaviorResponseBodyData setPlatform(Integer platform) {
            this.platform = platform;
            return this;
        }
        public Integer getPlatform() {
            return this.platform;
        }

        public QueryUserBehaviorResponseBodyData setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public QueryUserBehaviorResponseBodyData setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

        public QueryUserBehaviorResponseBodyData setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public QueryUserBehaviorResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryUserBehaviorResponseBodyData setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
