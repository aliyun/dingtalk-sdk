// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserCreateLiveListResponseBody extends TeaModel {
    @NameInMap("result")
    public GetUserCreateLiveListResponseBodyResult result;

    public static GetUserCreateLiveListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserCreateLiveListResponseBody self = new GetUserCreateLiveListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserCreateLiveListResponseBody setResult(GetUserCreateLiveListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetUserCreateLiveListResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList extends TeaModel {
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

        // 预告是否过期
        @NameInMap("isForecastExpired")
        public Boolean isForecastExpired;

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

        // 回放观看进度
        @NameInMap("watchProgressMs")
        public Long watchProgressMs;

        public static GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList build(java.util.Map<String, ?> map) throws Exception {
            GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList self = new GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList();
            return TeaModel.build(map, self);
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setIsForecastExpired(Boolean isForecastExpired) {
            this.isForecastExpired = isForecastExpired;
            return this;
        }
        public Boolean getIsForecastExpired() {
            return this.isForecastExpired;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setLivePlayUrl(String livePlayUrl) {
            this.livePlayUrl = livePlayUrl;
            return this;
        }
        public String getLivePlayUrl() {
            return this.livePlayUrl;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setLiveStatus(Integer liveStatus) {
            this.liveStatus = liveStatus;
            return this;
        }
        public Integer getLiveStatus() {
            return this.liveStatus;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setSubscribeCount(Integer subscribeCount) {
            this.subscribeCount = subscribeCount;
            return this;
        }
        public Integer getSubscribeCount() {
            return this.subscribeCount;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setUv(Integer uv) {
            this.uv = uv;
            return this;
        }
        public Integer getUv() {
            return this.uv;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setWatchProgressMs(Long watchProgressMs) {
            this.watchProgressMs = watchProgressMs;
            return this;
        }
        public Long getWatchProgressMs() {
            return this.watchProgressMs;
        }

    }

    public static class GetUserCreateLiveListResponseBodyResult extends TeaModel {
        // 是否拉取完成
        @NameInMap("hasFinish")
        public Boolean hasFinish;

        // 直播详情
        @NameInMap("liveInfoPopModelList")
        public java.util.List<GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList;

        // 分页游标 第一次可不填， 后面填回包的值
        @NameInMap("nextToken")
        public String nextToken;

        // 总数
        @NameInMap("total")
        public Integer total;

        public static GetUserCreateLiveListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetUserCreateLiveListResponseBodyResult self = new GetUserCreateLiveListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetUserCreateLiveListResponseBodyResult setHasFinish(Boolean hasFinish) {
            this.hasFinish = hasFinish;
            return this;
        }
        public Boolean getHasFinish() {
            return this.hasFinish;
        }

        public GetUserCreateLiveListResponseBodyResult setLiveInfoPopModelList(java.util.List<GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList) {
            this.liveInfoPopModelList = liveInfoPopModelList;
            return this;
        }
        public java.util.List<GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList> getLiveInfoPopModelList() {
            return this.liveInfoPopModelList;
        }

        public GetUserCreateLiveListResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public GetUserCreateLiveListResponseBodyResult setTotal(Integer total) {
            this.total = total;
            return this;
        }
        public Integer getTotal() {
            return this.total;
        }

    }

}
