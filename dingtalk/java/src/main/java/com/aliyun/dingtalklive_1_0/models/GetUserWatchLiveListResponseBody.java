// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserWatchLiveListResponseBody extends TeaModel {
    @NameInMap("result")
    public GetUserWatchLiveListResponseBodyResult result;

    public static GetUserWatchLiveListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserWatchLiveListResponseBody self = new GetUserWatchLiveListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserWatchLiveListResponseBody setResult(GetUserWatchLiveListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetUserWatchLiveListResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList extends TeaModel {
        // 直播封面
        @NameInMap("coverUrl")
        public String coverUrl;

        // 直播时长
        @NameInMap("duration")
        public Long duration;

        // 直播真实结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 是否订阅
        @NameInMap("hasSubscribed")
        public Boolean hasSubscribed;

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

        // 回放观看进度
        @NameInMap("watchProgressMs")
        public Long watchProgressMs;

        public static GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList build(java.util.Map<String, ?> map) throws Exception {
            GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList self = new GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList();
            return TeaModel.build(map, self);
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setHasSubscribed(Boolean hasSubscribed) {
            this.hasSubscribed = hasSubscribed;
            return this;
        }
        public Boolean getHasSubscribed() {
            return this.hasSubscribed;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setLivePlayUrl(String livePlayUrl) {
            this.livePlayUrl = livePlayUrl;
            return this;
        }
        public String getLivePlayUrl() {
            return this.livePlayUrl;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setLiveStatus(Integer liveStatus) {
            this.liveStatus = liveStatus;
            return this;
        }
        public Integer getLiveStatus() {
            return this.liveStatus;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setSubscribeCount(Integer subscribeCount) {
            this.subscribeCount = subscribeCount;
            return this;
        }
        public Integer getSubscribeCount() {
            return this.subscribeCount;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setUv(Integer uv) {
            this.uv = uv;
            return this;
        }
        public Integer getUv() {
            return this.uv;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setWatchProgressMs(Long watchProgressMs) {
            this.watchProgressMs = watchProgressMs;
            return this;
        }
        public Long getWatchProgressMs() {
            return this.watchProgressMs;
        }

    }

    public static class GetUserWatchLiveListResponseBodyResult extends TeaModel {
        // 是否拉取完成
        @NameInMap("hasFinish")
        public Boolean hasFinish;

        // 直播详情
        @NameInMap("liveInfoPopModelList")
        public java.util.List<GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList;

        // 分页游标 分页时填到请求中
        @NameInMap("nextToken")
        public String nextToken;

        // 总数
        @NameInMap("total")
        public Integer total;

        public static GetUserWatchLiveListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetUserWatchLiveListResponseBodyResult self = new GetUserWatchLiveListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetUserWatchLiveListResponseBodyResult setHasFinish(Boolean hasFinish) {
            this.hasFinish = hasFinish;
            return this;
        }
        public Boolean getHasFinish() {
            return this.hasFinish;
        }

        public GetUserWatchLiveListResponseBodyResult setLiveInfoPopModelList(java.util.List<GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList) {
            this.liveInfoPopModelList = liveInfoPopModelList;
            return this;
        }
        public java.util.List<GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList> getLiveInfoPopModelList() {
            return this.liveInfoPopModelList;
        }

        public GetUserWatchLiveListResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public GetUserWatchLiveListResponseBodyResult setTotal(Integer total) {
            this.total = total;
            return this;
        }
        public Integer getTotal() {
            return this.total;
        }

    }

}
