// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAllLiveListResponseBody extends TeaModel {
    @NameInMap("result")
    public GetUserAllLiveListResponseBodyResult result;

    public static GetUserAllLiveListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserAllLiveListResponseBody self = new GetUserAllLiveListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserAllLiveListResponseBody setResult(GetUserAllLiveListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetUserAllLiveListResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extends TeaModel {
        @NameInMap("hasSubscribed")
        public Boolean hasSubscribed;

        @NameInMap("isForecastExpired")
        public Boolean isForecastExpired;

        @NameInMap("watchProgressMs")
        public Long watchProgressMs;

        public static GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo self = new GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo();
            return TeaModel.build(map, self);
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo setHasSubscribed(Boolean hasSubscribed) {
            this.hasSubscribed = hasSubscribed;
            return this;
        }
        public Boolean getHasSubscribed() {
            return this.hasSubscribed;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo setIsForecastExpired(Boolean isForecastExpired) {
            this.isForecastExpired = isForecastExpired;
            return this;
        }
        public Boolean getIsForecastExpired() {
            return this.isForecastExpired;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo setWatchProgressMs(Long watchProgressMs) {
            this.watchProgressMs = watchProgressMs;
            return this;
        }
        public Long getWatchProgressMs() {
            return this.watchProgressMs;
        }

    }

    public static class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo extends TeaModel {
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

        public static GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo self = new GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo();
            return TeaModel.build(map, self);
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLivePlayUrl(String livePlayUrl) {
            this.livePlayUrl = livePlayUrl;
            return this;
        }
        public String getLivePlayUrl() {
            return this.livePlayUrl;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setLiveStatus(Integer liveStatus) {
            this.liveStatus = liveStatus;
            return this;
        }
        public Integer getLiveStatus() {
            return this.liveStatus;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setSubscribeCount(Integer subscribeCount) {
            this.subscribeCount = subscribeCount;
            return this;
        }
        public Integer getSubscribeCount() {
            return this.subscribeCount;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo setUv(Integer uv) {
            this.uv = uv;
            return this;
        }
        public Integer getUv() {
            return this.uv;
        }

    }

    public static class GetUserAllLiveListResponseBodyResultLiveInfoPopModelList extends TeaModel {
        @NameInMap("extraInfo")
        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extraInfo;

        @NameInMap("liveBasicInfo")
        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo liveBasicInfo;

        public static GetUserAllLiveListResponseBodyResultLiveInfoPopModelList build(java.util.Map<String, ?> map) throws Exception {
            GetUserAllLiveListResponseBodyResultLiveInfoPopModelList self = new GetUserAllLiveListResponseBodyResultLiveInfoPopModelList();
            return TeaModel.build(map, self);
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelList setExtraInfo(GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo getExtraInfo() {
            return this.extraInfo;
        }

        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelList setLiveBasicInfo(GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo liveBasicInfo) {
            this.liveBasicInfo = liveBasicInfo;
            return this;
        }
        public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo getLiveBasicInfo() {
            return this.liveBasicInfo;
        }

    }

    public static class GetUserAllLiveListResponseBodyResult extends TeaModel {
        @NameInMap("hasFinish")
        public Boolean hasFinish;

        @NameInMap("liveInfoPopModelList")
        public java.util.List<GetUserAllLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList;

        public static GetUserAllLiveListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetUserAllLiveListResponseBodyResult self = new GetUserAllLiveListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetUserAllLiveListResponseBodyResult setHasFinish(Boolean hasFinish) {
            this.hasFinish = hasFinish;
            return this;
        }
        public Boolean getHasFinish() {
            return this.hasFinish;
        }

        public GetUserAllLiveListResponseBodyResult setLiveInfoPopModelList(java.util.List<GetUserAllLiveListResponseBodyResultLiveInfoPopModelList> liveInfoPopModelList) {
            this.liveInfoPopModelList = liveInfoPopModelList;
            return this;
        }
        public java.util.List<GetUserAllLiveListResponseBodyResultLiveInfoPopModelList> getLiveInfoPopModelList() {
            return this.liveInfoPopModelList;
        }

    }

}
