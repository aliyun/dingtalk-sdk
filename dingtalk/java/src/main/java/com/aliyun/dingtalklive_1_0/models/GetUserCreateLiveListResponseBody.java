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
        @NameInMap("hasSubscribed")
        public Boolean hasSubscribed;

        @NameInMap("isForecastExpired")
        public Boolean isForecastExpired;

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
        @NameInMap("hasSubscribed")
        public GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed hasSubscribed;

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
        @NameInMap("hasFinish")
        public Boolean hasFinish;

        @NameInMap("liveInfoPopModelList")
        public java.util.List<GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList;

        @NameInMap("nextToken")
        public String nextToken;

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
