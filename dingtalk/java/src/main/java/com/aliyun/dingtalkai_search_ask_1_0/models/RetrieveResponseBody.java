// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class RetrieveResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public java.util.List<RetrieveResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static RetrieveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RetrieveResponseBody self = new RetrieveResponseBody();
        return TeaModel.build(map, self);
    }

    public RetrieveResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public RetrieveResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public RetrieveResponseBody setResult(java.util.List<RetrieveResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<RetrieveResponseBodyResult> getResult() {
        return this.result;
    }

    public RetrieveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RetrieveResponseBodyResultCalendarsScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultCalendarsScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultCalendarsScoreItem self = new RetrieveResponseBodyResultCalendarsScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultCalendarsScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultCalendarsScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultCalendarsScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultCalendarsScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultCalendarsScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultCalendars extends TeaModel {
        @NameInMap("creatorStaffId")
        public Long creatorStaffId;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("meetingRoom")
        public String meetingRoom;

        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        @NameInMap("rawComment")
        public String rawComment;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultCalendarsScoreItem scoreItem;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultCalendars build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultCalendars self = new RetrieveResponseBodyResultCalendars();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultCalendars setCreatorStaffId(Long creatorStaffId) {
            this.creatorStaffId = creatorStaffId;
            return this;
        }
        public Long getCreatorStaffId() {
            return this.creatorStaffId;
        }

        public RetrieveResponseBodyResultCalendars setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public RetrieveResponseBodyResultCalendars setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public RetrieveResponseBodyResultCalendars setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public RetrieveResponseBodyResultCalendars setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultCalendars setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultCalendars setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultCalendars setMeetingRoom(String meetingRoom) {
            this.meetingRoom = meetingRoom;
            return this;
        }
        public String getMeetingRoom() {
            return this.meetingRoom;
        }

        public RetrieveResponseBodyResultCalendars setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

        public RetrieveResponseBodyResultCalendars setRawComment(String rawComment) {
            this.rawComment = rawComment;
            return this;
        }
        public String getRawComment() {
            return this.rawComment;
        }

        public RetrieveResponseBodyResultCalendars setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultCalendars setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultCalendars setScoreItem(RetrieveResponseBodyResultCalendarsScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultCalendarsScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultCalendars setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public RetrieveResponseBodyResultCalendars setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultCalendars setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultCalendars setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultCalendars setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel extends TeaModel {
        @NameInMap("chartName")
        public String chartName;

        @NameInMap("chartType")
        public String chartType;

        @NameInMap("dashboardName")
        public String dashboardName;

        @NameInMap("data")
        public String data;

        @NameInMap("sheetName")
        public String sheetName;

        @NameInMap("type")
        public String type;

        public static RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel self = new RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel setChartName(String chartName) {
            this.chartName = chartName;
            return this;
        }
        public String getChartName() {
            return this.chartName;
        }

        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel setChartType(String chartType) {
            this.chartType = chartType;
            return this;
        }
        public String getChartType() {
            return this.chartType;
        }

        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel setDashboardName(String dashboardName) {
            this.dashboardName = dashboardName;
            return this;
        }
        public String getDashboardName() {
            return this.dashboardName;
        }

        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel setData(String data) {
            this.data = data;
            return this;
        }
        public String getData() {
            return this.data;
        }

        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel setSheetName(String sheetName) {
            this.sheetName = sheetName;
            return this;
        }
        public String getSheetName() {
            return this.sheetName;
        }

        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class RetrieveResponseBodyResultDingHelperDocsScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultDingHelperDocsScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultDingHelperDocsScoreItem self = new RetrieveResponseBodyResultDingHelperDocsScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultDingHelperDocsScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultDingHelperDocsScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultDingHelperDocsScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultDingHelperDocsScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultDingHelperDocsScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultDingHelperDocs extends TeaModel {
        @NameInMap("ableDashboardModel")
        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel ableDashboardModel;

        @NameInMap("chunkId")
        public Integer chunkId;

        @NameInMap("chunkIds")
        public java.util.List<Integer> chunkIds;

        @NameInMap("chunkModel")
        public String chunkModel;

        @NameInMap("creator")
        public String creator;

        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("extension")
        public String extension;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("hasExtendChunk")
        public Boolean hasExtendChunk;

        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultDingHelperDocsScoreItem scoreItem;

        @NameInMap("small2bigText")
        public String small2bigText;

        @NameInMap("text")
        public String text;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("uploadSource")
        public String uploadSource;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultDingHelperDocs build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultDingHelperDocs self = new RetrieveResponseBodyResultDingHelperDocs();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultDingHelperDocs setAbleDashboardModel(RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel ableDashboardModel) {
            this.ableDashboardModel = ableDashboardModel;
            return this;
        }
        public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel getAbleDashboardModel() {
            return this.ableDashboardModel;
        }

        public RetrieveResponseBodyResultDingHelperDocs setChunkId(Integer chunkId) {
            this.chunkId = chunkId;
            return this;
        }
        public Integer getChunkId() {
            return this.chunkId;
        }

        public RetrieveResponseBodyResultDingHelperDocs setChunkIds(java.util.List<Integer> chunkIds) {
            this.chunkIds = chunkIds;
            return this;
        }
        public java.util.List<Integer> getChunkIds() {
            return this.chunkIds;
        }

        public RetrieveResponseBodyResultDingHelperDocs setChunkModel(String chunkModel) {
            this.chunkModel = chunkModel;
            return this;
        }
        public String getChunkModel() {
            return this.chunkModel;
        }

        public RetrieveResponseBodyResultDingHelperDocs setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public RetrieveResponseBodyResultDingHelperDocs setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public RetrieveResponseBodyResultDingHelperDocs setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public RetrieveResponseBodyResultDingHelperDocs setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public RetrieveResponseBodyResultDingHelperDocs setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public RetrieveResponseBodyResultDingHelperDocs setHasExtendChunk(Boolean hasExtendChunk) {
            this.hasExtendChunk = hasExtendChunk;
            return this;
        }
        public Boolean getHasExtendChunk() {
            return this.hasExtendChunk;
        }

        public RetrieveResponseBodyResultDingHelperDocs setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultDingHelperDocs setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultDingHelperDocs setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultDingHelperDocs setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultDingHelperDocs setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultDingHelperDocs setScoreItem(RetrieveResponseBodyResultDingHelperDocsScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultDingHelperDocsScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultDingHelperDocs setSmall2bigText(String small2bigText) {
            this.small2bigText = small2bigText;
            return this;
        }
        public String getSmall2bigText() {
            return this.small2bigText;
        }

        public RetrieveResponseBodyResultDingHelperDocs setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public RetrieveResponseBodyResultDingHelperDocs setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultDingHelperDocs setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultDingHelperDocs setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultDingHelperDocs setUploadSource(String uploadSource) {
            this.uploadSource = uploadSource;
            return this;
        }
        public String getUploadSource() {
            return this.uploadSource;
        }

        public RetrieveResponseBodyResultDingHelperDocs setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResultDocsAbleDashboardModel extends TeaModel {
        @NameInMap("chartName")
        public String chartName;

        @NameInMap("chartType")
        public String chartType;

        @NameInMap("dashboardName")
        public String dashboardName;

        @NameInMap("data")
        public String data;

        @NameInMap("sheetName")
        public String sheetName;

        @NameInMap("type")
        public String type;

        public static RetrieveResponseBodyResultDocsAbleDashboardModel build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultDocsAbleDashboardModel self = new RetrieveResponseBodyResultDocsAbleDashboardModel();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultDocsAbleDashboardModel setChartName(String chartName) {
            this.chartName = chartName;
            return this;
        }
        public String getChartName() {
            return this.chartName;
        }

        public RetrieveResponseBodyResultDocsAbleDashboardModel setChartType(String chartType) {
            this.chartType = chartType;
            return this;
        }
        public String getChartType() {
            return this.chartType;
        }

        public RetrieveResponseBodyResultDocsAbleDashboardModel setDashboardName(String dashboardName) {
            this.dashboardName = dashboardName;
            return this;
        }
        public String getDashboardName() {
            return this.dashboardName;
        }

        public RetrieveResponseBodyResultDocsAbleDashboardModel setData(String data) {
            this.data = data;
            return this;
        }
        public String getData() {
            return this.data;
        }

        public RetrieveResponseBodyResultDocsAbleDashboardModel setSheetName(String sheetName) {
            this.sheetName = sheetName;
            return this;
        }
        public String getSheetName() {
            return this.sheetName;
        }

        public RetrieveResponseBodyResultDocsAbleDashboardModel setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class RetrieveResponseBodyResultDocsScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultDocsScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultDocsScoreItem self = new RetrieveResponseBodyResultDocsScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultDocsScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultDocsScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultDocsScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultDocsScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultDocsScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultDocs extends TeaModel {
        @NameInMap("ableDashboardModel")
        public RetrieveResponseBodyResultDocsAbleDashboardModel ableDashboardModel;

        @NameInMap("chunkId")
        public Integer chunkId;

        @NameInMap("chunkIds")
        public java.util.List<Integer> chunkIds;

        @NameInMap("chunkModel")
        public String chunkModel;

        @NameInMap("creator")
        public String creator;

        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("extension")
        public String extension;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("hasExtendChunk")
        public Boolean hasExtendChunk;

        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultDocsScoreItem scoreItem;

        @NameInMap("small2bigText")
        public String small2bigText;

        @NameInMap("text")
        public String text;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("uploadSource")
        public String uploadSource;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultDocs build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultDocs self = new RetrieveResponseBodyResultDocs();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultDocs setAbleDashboardModel(RetrieveResponseBodyResultDocsAbleDashboardModel ableDashboardModel) {
            this.ableDashboardModel = ableDashboardModel;
            return this;
        }
        public RetrieveResponseBodyResultDocsAbleDashboardModel getAbleDashboardModel() {
            return this.ableDashboardModel;
        }

        public RetrieveResponseBodyResultDocs setChunkId(Integer chunkId) {
            this.chunkId = chunkId;
            return this;
        }
        public Integer getChunkId() {
            return this.chunkId;
        }

        public RetrieveResponseBodyResultDocs setChunkIds(java.util.List<Integer> chunkIds) {
            this.chunkIds = chunkIds;
            return this;
        }
        public java.util.List<Integer> getChunkIds() {
            return this.chunkIds;
        }

        public RetrieveResponseBodyResultDocs setChunkModel(String chunkModel) {
            this.chunkModel = chunkModel;
            return this;
        }
        public String getChunkModel() {
            return this.chunkModel;
        }

        public RetrieveResponseBodyResultDocs setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public RetrieveResponseBodyResultDocs setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public RetrieveResponseBodyResultDocs setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public RetrieveResponseBodyResultDocs setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public RetrieveResponseBodyResultDocs setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public RetrieveResponseBodyResultDocs setHasExtendChunk(Boolean hasExtendChunk) {
            this.hasExtendChunk = hasExtendChunk;
            return this;
        }
        public Boolean getHasExtendChunk() {
            return this.hasExtendChunk;
        }

        public RetrieveResponseBodyResultDocs setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultDocs setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultDocs setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultDocs setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultDocs setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultDocs setScoreItem(RetrieveResponseBodyResultDocsScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultDocsScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultDocs setSmall2bigText(String small2bigText) {
            this.small2bigText = small2bigText;
            return this;
        }
        public String getSmall2bigText() {
            return this.small2bigText;
        }

        public RetrieveResponseBodyResultDocs setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public RetrieveResponseBodyResultDocs setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultDocs setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultDocs setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultDocs setUploadSource(String uploadSource) {
            this.uploadSource = uploadSource;
            return this;
        }
        public String getUploadSource() {
            return this.uploadSource;
        }

        public RetrieveResponseBodyResultDocs setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResultFaqsScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultFaqsScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultFaqsScoreItem self = new RetrieveResponseBodyResultFaqsScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultFaqsScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultFaqsScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultFaqsScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultFaqsScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultFaqsScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultFaqs extends TeaModel {
        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultFaqsScoreItem scoreItem;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultFaqs build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultFaqs self = new RetrieveResponseBodyResultFaqs();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultFaqs setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultFaqs setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultFaqs setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultFaqs setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultFaqs setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultFaqs setScoreItem(RetrieveResponseBodyResultFaqsScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultFaqsScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultFaqs setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultFaqs setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultFaqs setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultFaqs setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResultFinalResultsScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultFinalResultsScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultFinalResultsScoreItem self = new RetrieveResponseBodyResultFinalResultsScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultFinalResultsScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultFinalResultsScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultFinalResultsScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultFinalResultsScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultFinalResultsScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultFinalResults extends TeaModel {
        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultFinalResultsScoreItem scoreItem;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultFinalResults build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultFinalResults self = new RetrieveResponseBodyResultFinalResults();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultFinalResults setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultFinalResults setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultFinalResults setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultFinalResults setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultFinalResults setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultFinalResults setScoreItem(RetrieveResponseBodyResultFinalResultsScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultFinalResultsScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultFinalResults setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultFinalResults setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultFinalResults setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultFinalResults setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResultMinutesScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultMinutesScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultMinutesScoreItem self = new RetrieveResponseBodyResultMinutesScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultMinutesScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultMinutesScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultMinutesScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultMinutesScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultMinutesScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultMinutes extends TeaModel {
        @NameInMap("corpId")
        public Long corpId;

        @NameInMap("creator")
        public String creator;

        @NameInMap("extension")
        public String extension;

        @NameInMap("fullTextSummary")
        public String fullTextSummary;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("originText")
        public String originText;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultMinutesScoreItem scoreItem;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultMinutes build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultMinutes self = new RetrieveResponseBodyResultMinutes();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultMinutes setCorpId(Long corpId) {
            this.corpId = corpId;
            return this;
        }
        public Long getCorpId() {
            return this.corpId;
        }

        public RetrieveResponseBodyResultMinutes setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public RetrieveResponseBodyResultMinutes setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public RetrieveResponseBodyResultMinutes setFullTextSummary(String fullTextSummary) {
            this.fullTextSummary = fullTextSummary;
            return this;
        }
        public String getFullTextSummary() {
            return this.fullTextSummary;
        }

        public RetrieveResponseBodyResultMinutes setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public RetrieveResponseBodyResultMinutes setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultMinutes setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultMinutes setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultMinutes setOriginText(String originText) {
            this.originText = originText;
            return this;
        }
        public String getOriginText() {
            return this.originText;
        }

        public RetrieveResponseBodyResultMinutes setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultMinutes setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultMinutes setScoreItem(RetrieveResponseBodyResultMinutesScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultMinutesScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultMinutes setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultMinutes setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultMinutes setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultMinutes setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResultReportsScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultReportsScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultReportsScoreItem self = new RetrieveResponseBodyResultReportsScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultReportsScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultReportsScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultReportsScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultReportsScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultReportsScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultReports extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("corpId")
        public Long corpId;

        @NameInMap("creator")
        public String creator;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultReportsScoreItem scoreItem;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultReports build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultReports self = new RetrieveResponseBodyResultReports();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultReports setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public RetrieveResponseBodyResultReports setCorpId(Long corpId) {
            this.corpId = corpId;
            return this;
        }
        public Long getCorpId() {
            return this.corpId;
        }

        public RetrieveResponseBodyResultReports setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public RetrieveResponseBodyResultReports setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public RetrieveResponseBodyResultReports setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public RetrieveResponseBodyResultReports setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultReports setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultReports setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultReports setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultReports setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultReports setScoreItem(RetrieveResponseBodyResultReportsScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultReportsScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultReports setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultReports setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultReports setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultReports setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResultWikisScoreItem extends TeaModel {
        @NameInMap("finallyScore")
        public Double finallyScore;

        @NameInMap("scoreMap")
        public java.util.Map<String, Double> scoreMap;

        @NameInMap("scoreThreshold")
        public Double scoreThreshold;

        @NameInMap("selectedBranch")
        public java.util.List<String> selectedBranch;

        @NameInMap("selectedCategory")
        public String selectedCategory;

        public static RetrieveResponseBodyResultWikisScoreItem build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultWikisScoreItem self = new RetrieveResponseBodyResultWikisScoreItem();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultWikisScoreItem setFinallyScore(Double finallyScore) {
            this.finallyScore = finallyScore;
            return this;
        }
        public Double getFinallyScore() {
            return this.finallyScore;
        }

        public RetrieveResponseBodyResultWikisScoreItem setScoreMap(java.util.Map<String, Double> scoreMap) {
            this.scoreMap = scoreMap;
            return this;
        }
        public java.util.Map<String, Double> getScoreMap() {
            return this.scoreMap;
        }

        public RetrieveResponseBodyResultWikisScoreItem setScoreThreshold(Double scoreThreshold) {
            this.scoreThreshold = scoreThreshold;
            return this;
        }
        public Double getScoreThreshold() {
            return this.scoreThreshold;
        }

        public RetrieveResponseBodyResultWikisScoreItem setSelectedBranch(java.util.List<String> selectedBranch) {
            this.selectedBranch = selectedBranch;
            return this;
        }
        public java.util.List<String> getSelectedBranch() {
            return this.selectedBranch;
        }

        public RetrieveResponseBodyResultWikisScoreItem setSelectedCategory(String selectedCategory) {
            this.selectedCategory = selectedCategory;
            return this;
        }
        public String getSelectedCategory() {
            return this.selectedCategory;
        }

    }

    public static class RetrieveResponseBodyResultWikis extends TeaModel {
        @NameInMap("corpId")
        public Long corpId;

        @NameInMap("icon")
        public String icon;

        @NameInMap("matchIntimacy")
        public Boolean matchIntimacy;

        @NameInMap("material")
        public String material;

        @NameInMap("refType")
        public String refType;

        @NameInMap("score")
        public Double score;

        @NameInMap("scoreItem")
        public RetrieveResponseBodyResultWikisScoreItem scoreItem;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static RetrieveResponseBodyResultWikis build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResultWikis self = new RetrieveResponseBodyResultWikis();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResultWikis setCorpId(Long corpId) {
            this.corpId = corpId;
            return this;
        }
        public Long getCorpId() {
            return this.corpId;
        }

        public RetrieveResponseBodyResultWikis setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RetrieveResponseBodyResultWikis setMatchIntimacy(Boolean matchIntimacy) {
            this.matchIntimacy = matchIntimacy;
            return this;
        }
        public Boolean getMatchIntimacy() {
            return this.matchIntimacy;
        }

        public RetrieveResponseBodyResultWikis setMaterial(String material) {
            this.material = material;
            return this;
        }
        public String getMaterial() {
            return this.material;
        }

        public RetrieveResponseBodyResultWikis setRefType(String refType) {
            this.refType = refType;
            return this;
        }
        public String getRefType() {
            return this.refType;
        }

        public RetrieveResponseBodyResultWikis setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public RetrieveResponseBodyResultWikis setScoreItem(RetrieveResponseBodyResultWikisScoreItem scoreItem) {
            this.scoreItem = scoreItem;
            return this;
        }
        public RetrieveResponseBodyResultWikisScoreItem getScoreItem() {
            return this.scoreItem;
        }

        public RetrieveResponseBodyResultWikis setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public RetrieveResponseBodyResultWikis setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public RetrieveResponseBodyResultWikis setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetrieveResponseBodyResultWikis setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class RetrieveResponseBodyResult extends TeaModel {
        @NameInMap("calendars")
        public java.util.List<RetrieveResponseBodyResultCalendars> calendars;

        @NameInMap("dingHelperDocs")
        public java.util.List<RetrieveResponseBodyResultDingHelperDocs> dingHelperDocs;

        @NameInMap("docs")
        public java.util.List<RetrieveResponseBodyResultDocs> docs;

        @NameInMap("faqs")
        public java.util.List<RetrieveResponseBodyResultFaqs> faqs;

        @NameInMap("finalResults")
        public java.util.List<RetrieveResponseBodyResultFinalResults> finalResults;

        @NameInMap("minutes")
        public java.util.List<RetrieveResponseBodyResultMinutes> minutes;

        @NameInMap("reports")
        public java.util.List<RetrieveResponseBodyResultReports> reports;

        @NameInMap("wikis")
        public java.util.List<RetrieveResponseBodyResultWikis> wikis;

        public static RetrieveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RetrieveResponseBodyResult self = new RetrieveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RetrieveResponseBodyResult setCalendars(java.util.List<RetrieveResponseBodyResultCalendars> calendars) {
            this.calendars = calendars;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultCalendars> getCalendars() {
            return this.calendars;
        }

        public RetrieveResponseBodyResult setDingHelperDocs(java.util.List<RetrieveResponseBodyResultDingHelperDocs> dingHelperDocs) {
            this.dingHelperDocs = dingHelperDocs;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultDingHelperDocs> getDingHelperDocs() {
            return this.dingHelperDocs;
        }

        public RetrieveResponseBodyResult setDocs(java.util.List<RetrieveResponseBodyResultDocs> docs) {
            this.docs = docs;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultDocs> getDocs() {
            return this.docs;
        }

        public RetrieveResponseBodyResult setFaqs(java.util.List<RetrieveResponseBodyResultFaqs> faqs) {
            this.faqs = faqs;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultFaqs> getFaqs() {
            return this.faqs;
        }

        public RetrieveResponseBodyResult setFinalResults(java.util.List<RetrieveResponseBodyResultFinalResults> finalResults) {
            this.finalResults = finalResults;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultFinalResults> getFinalResults() {
            return this.finalResults;
        }

        public RetrieveResponseBodyResult setMinutes(java.util.List<RetrieveResponseBodyResultMinutes> minutes) {
            this.minutes = minutes;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultMinutes> getMinutes() {
            return this.minutes;
        }

        public RetrieveResponseBodyResult setReports(java.util.List<RetrieveResponseBodyResultReports> reports) {
            this.reports = reports;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultReports> getReports() {
            return this.reports;
        }

        public RetrieveResponseBodyResult setWikis(java.util.List<RetrieveResponseBodyResultWikis> wikis) {
            this.wikis = wikis;
            return this;
        }
        public java.util.List<RetrieveResponseBodyResultWikis> getWikis() {
            return this.wikis;
        }

    }

}
