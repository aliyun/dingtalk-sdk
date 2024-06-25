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
        /**
         * <strong>example:</strong>
         * <p><a href="https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png">https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png</a></p>
         */
        @NameInMap("coverUrl")
        public String coverUrl;

        /**
         * <strong>example:</strong>
         * <p>18450</p>
         */
        @NameInMap("duration")
        public Long duration;

        /**
         * <strong>example:</strong>
         * <p>1659653648000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>测试直播简介</p>
         */
        @NameInMap("introduction")
        public String introduction;

        /**
         * <strong>example:</strong>
         * <p>1a353547-040d-4095-bb93-404bc5d47920</p>
         */
        @NameInMap("liveId")
        public String liveId;

        /**
         * <strong>example:</strong>
         * <p><a href="https://h5.dingtalk.com/group-live-share/index.htm?type=2&liveFromType=6&liveUuid=1a353547-040d-4095-bb93-404bc5d47920&dd_nav_bgcolor=FF2C2D2F#/union">https://h5.dingtalk.com/group-live-share/index.htm?type=2&amp;liveFromType=6&amp;liveUuid=1a353547-040d-4095-bb93-404bc5d47920&amp;dd_nav_bgcolor=FF2C2D2F#/union</a></p>
         */
        @NameInMap("livePlayUrl")
        public String livePlayUrl;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("liveStatus")
        public Integer liveStatus;

        /**
         * <strong>example:</strong>
         * <p>18430</p>
         */
        @NameInMap("playbackDuration")
        public Long playbackDuration;

        /**
         * <strong>example:</strong>
         * <p>1659613648000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("subscribeCount")
        public Integer subscribeCount;

        /**
         * <strong>example:</strong>
         * <p>测试直播</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>DC7wZGOSueEEIGOf3WKwWgiEiE</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
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

        public QueryLiveInfoResponseBodyResultLiveInfo setPlaybackDuration(Long playbackDuration) {
            this.playbackDuration = playbackDuration;
            return this;
        }
        public Long getPlaybackDuration() {
            return this.playbackDuration;
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
