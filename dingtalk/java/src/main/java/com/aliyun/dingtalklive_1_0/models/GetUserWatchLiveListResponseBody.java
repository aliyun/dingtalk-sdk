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
        @NameInMap("hasSubscribed")
        public Boolean hasSubscribed;

        @NameInMap("isForecastExpired")
        public Boolean isForecastExpired;

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
        @NameInMap("coverUrl")
        public String coverUrl;

        @NameInMap("duration")
        public Long duration;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("introduction")
        public String introduction;

        @NameInMap("liveId")
        public String liveId;

        @NameInMap("livePlayUrl")
        public String livePlayUrl;

        @NameInMap("liveStatus")
        public Integer liveStatus;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("subscribeCount")
        public Integer subscribeCount;

        @NameInMap("title")
        public String title;

        @NameInMap("unionId")
        public String unionId;

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
        @NameInMap("extraInfo")
        public GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extraInfo;

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
        @NameInMap("hasFinish")
        public Boolean hasFinish;

        @NameInMap("liveInfoPopModelList")
        public java.util.List<GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList;

        @NameInMap("nextToken")
        public String nextToken;

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
