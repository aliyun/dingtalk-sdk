// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryLiveInfoResponseBodyResult result;

    public static QueryLiveInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveInfoResponseBody self = new QueryLiveInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryLiveInfoResponseBody setResult(QueryLiveInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryLiveInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryLiveInfoResponseBodyResultLiveInfo extends TeaModel {
        // 直播封面
        @NameInMap("coverUrl")
        public String coverUrl;

        // 直播时长
        @NameInMap("duration")
        public Long duration;

        // 直播真实结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 直播简介
        @NameInMap("introduction")
        public String introduction;

        // 直播id
        @NameInMap("liveId")
        public String liveId;

        // 直播观看地址
        @NameInMap("livePlayUrl")
        public String livePlayUrl;

        // 直播状态
        @NameInMap("liveStatus")
        public Integer liveStatus;

        // 直播真实开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 预约人数
        @NameInMap("subscribeCount")
        public Integer subscribeCount;

        // 直播标题
        @NameInMap("title")
        public String title;

        // 主播id
        @NameInMap("unionId")
        public String unionId;

        // 观看人数
        @NameInMap("uv")
        public Integer uv;

        public static QueryLiveInfoResponseBodyResultLiveInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveInfoResponseBodyResultLiveInfo self = new QueryLiveInfoResponseBodyResultLiveInfo();
            return TeaModel.build(map, self);
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setLivePlayUrl(String livePlayUrl) {
            this.livePlayUrl = livePlayUrl;
            return this;
        }
        public String getLivePlayUrl() {
            return this.livePlayUrl;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setLiveStatus(Integer liveStatus) {
            this.liveStatus = liveStatus;
            return this;
        }
        public Integer getLiveStatus() {
            return this.liveStatus;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setSubscribeCount(Integer subscribeCount) {
            this.subscribeCount = subscribeCount;
            return this;
        }
        public Integer getSubscribeCount() {
            return this.subscribeCount;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryLiveInfoResponseBodyResultLiveInfo setUv(Integer uv) {
            this.uv = uv;
            return this;
        }
        public Integer getUv() {
            return this.uv;
        }

    }

    public static class QueryLiveInfoResponseBodyResult extends TeaModel {
        @NameInMap("liveInfo")
        public QueryLiveInfoResponseBodyResultLiveInfo liveInfo;

        public static QueryLiveInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveInfoResponseBodyResult self = new QueryLiveInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryLiveInfoResponseBodyResult setLiveInfo(QueryLiveInfoResponseBodyResultLiveInfo liveInfo) {
            this.liveInfo = liveInfo;
            return this;
        }
        public QueryLiveInfoResponseBodyResultLiveInfo getLiveInfo() {
            return this.liveInfo;
        }

    }

}
