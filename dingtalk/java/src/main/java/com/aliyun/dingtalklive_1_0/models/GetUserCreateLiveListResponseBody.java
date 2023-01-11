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

    public static class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed extends TeaModel {
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

        public static GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed build(java.util.Map<String, ?> map) throws Exception {
            GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed self = new GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed();
            return TeaModel.build(map, self);
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed setHasSubscribed(Boolean hasSubscribed) {
            this.hasSubscribed = hasSubscribed;
            return this;
        }
        public Boolean getHasSubscribed() {
            return this.hasSubscribed;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed setIsForecastExpired(Boolean isForecastExpired) {
            this.isForecastExpired = isForecastExpired;
            return this;
        }
        public Boolean getIsForecastExpired() {
            return this.isForecastExpired;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed setWatchProgressMs(Long watchProgressMs) {
            this.watchProgressMs = watchProgressMs;
            return this;
        }
        public Long getWatchProgressMs() {
            return this.watchProgressMs;
        }

    }

    public static class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo extends TeaModel {
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

        public static GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo self = new GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo();
            return TeaModel.build(map, self);
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLivePlayUrl(String livePlayUrl) {
            this.livePlayUrl = livePlayUrl;
            return this;
        }
        public String getLivePlayUrl() {
            return this.livePlayUrl;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLiveStatus(Integer liveStatus) {
            this.liveStatus = liveStatus;
            return this;
        }
        public Integer getLiveStatus() {
            return this.liveStatus;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setSubscribeCount(Integer subscribeCount) {
            this.subscribeCount = subscribeCount;
            return this;
        }
        public Integer getSubscribeCount() {
            return this.subscribeCount;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setUv(Integer uv) {
            this.uv = uv;
            return this;
        }
        public Integer getUv() {
            return this.uv;
        }

    }

    public static class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList extends TeaModel {
        /**
         * <p>直播额外信息</p>
         */
        @NameInMap("hasSubscribed")
        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed hasSubscribed;

        /**
         * <p>直播基础信息</p>
         */
        @NameInMap("liveBasicInfo")
        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo liveBasicInfo;

        public static GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList build(java.util.Map<String, ?> map) throws Exception {
            GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList self = new GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList();
            return TeaModel.build(map, self);
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setHasSubscribed(GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed hasSubscribed) {
            this.hasSubscribed = hasSubscribed;
            return this;
        }
        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed getHasSubscribed() {
            return this.hasSubscribed;
        }

        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList setLiveBasicInfo(GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo liveBasicInfo) {
            this.liveBasicInfo = liveBasicInfo;
            return this;
        }
        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo getLiveBasicInfo() {
            return this.liveBasicInfo;
        }

    }

    public static class GetUserCreateLiveListResponseBodyResult extends TeaModel {
        /**
         * <p>是否拉取完成</p>
         */
        @NameInMap("hasFinish")
        public Boolean hasFinish;

        /**
         * <p>直播详情</p>
         */
        @NameInMap("liveInfoPopModelList")
        public java.util.List<GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList;

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
