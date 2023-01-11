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

    public static class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extends TeaModel {
        /**
         * <p>是否关注</p>
         */
        @NameInMap("hasSubscribed")
        public Boolean hasSubscribed;

        /**
         * <p>预告是否过期</p>
         */
        @NameInMap("isForecastExpired")
        public Boolean isForecastExpired;

        /**
         * <p>回放观看进度</p>
         */
        @NameInMap("watchProgressMs")
        public Long watchProgressMs;

        public static GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo self = new GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo();
            return TeaModel.build(map, self);
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo setHasSubscribed(Boolean hasSubscribed) {
            this.hasSubscribed = hasSubscribed;
            return this;
        }
        public Boolean getHasSubscribed() {
            return this.hasSubscribed;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo setIsForecastExpired(Boolean isForecastExpired) {
            this.isForecastExpired = isForecastExpired;
            return this;
        }
        public Boolean getIsForecastExpired() {
            return this.isForecastExpired;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo setWatchProgressMs(Long watchProgressMs) {
            this.watchProgressMs = watchProgressMs;
            return this;
        }
        public Long getWatchProgressMs() {
            return this.watchProgressMs;
        }

    }

    public static class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo extends TeaModel {
        /**
         * <p>直播封面</p>
         */
        @NameInMap("coverUrl")
        public String coverUrl;

        /**
         * <p>直播时长</p>
         */
        @NameInMap("duration")
        public Long duration;

        /**
         * <p>直播真实结束时间</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>直播简介</p>
         */
        @NameInMap("introduction")
        public String introduction;

        /**
         * <p>直播id</p>
         */
        @NameInMap("liveId")
        public String liveId;

        /**
         * <p>直播观看地址</p>
         */
        @NameInMap("livePlayUrl")
        public String livePlayUrl;

        /**
         * <p>直播状态</p>
         */
        @NameInMap("liveStatus")
        public Integer liveStatus;

        /**
         * <p>直播真实开始时间</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>预约人数</p>
         */
        @NameInMap("subscribeCount")
        public Integer subscribeCount;

        /**
         * <p>直播标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>主播id</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>观看人数</p>
         */
        @NameInMap("uv")
        public Integer uv;

        public static GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo self = new GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo();
            return TeaModel.build(map, self);
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLivePlayUrl(String livePlayUrl) {
            this.livePlayUrl = livePlayUrl;
            return this;
        }
        public String getLivePlayUrl() {
            return this.livePlayUrl;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLiveStatus(Integer liveStatus) {
            this.liveStatus = liveStatus;
            return this;
        }
        public Integer getLiveStatus() {
            return this.liveStatus;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setSubscribeCount(Integer subscribeCount) {
            this.subscribeCount = subscribeCount;
            return this;
        }
        public Integer getSubscribeCount() {
            return this.subscribeCount;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setUv(Integer uv) {
            this.uv = uv;
            return this;
        }
        public Integer getUv() {
            return this.uv;
        }

    }

    public static class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList extends TeaModel {
        /**
         * <p>直播额外信息</p>
         */
        @NameInMap("extraInfo")
        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extraInfo;

        /**
         * <p>直播基础信息</p>
         */
        @NameInMap("liveBasicInfo")
        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo liveBasicInfo;

        public static GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList build(java.util.Map<String, ?> map) throws Exception {
            GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList self = new GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList();
            return TeaModel.build(map, self);
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setExtraInfo(GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo getExtraInfo() {
            return this.extraInfo;
        }

        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList setLiveBasicInfo(GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo liveBasicInfo) {
            this.liveBasicInfo = liveBasicInfo;
            return this;
        }
        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo getLiveBasicInfo() {
            return this.liveBasicInfo;
        }

    }

    public static class GetUserWatchLiveListResponseBodyResult extends TeaModel {
        /**
         * <p>是否拉取完成</p>
         */
        @NameInMap("hasFinish")
        public Boolean hasFinish;

        /**
         * <p>直播详情</p>
         */
        @NameInMap("liveInfoPopModelList")
        public java.util.List<GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList;

        /**
         * <p>分页游标 分页时填到请求中</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <p>总数</p>
         */
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
