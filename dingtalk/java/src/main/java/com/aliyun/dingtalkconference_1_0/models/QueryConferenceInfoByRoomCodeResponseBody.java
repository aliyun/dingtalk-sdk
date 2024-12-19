// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoByRoomCodeResponseBody extends TeaModel {
    @NameInMap("conferenceList")
    public java.util.List<QueryConferenceInfoByRoomCodeResponseBodyConferenceList> conferenceList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryConferenceInfoByRoomCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceInfoByRoomCodeResponseBody self = new QueryConferenceInfoByRoomCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryConferenceInfoByRoomCodeResponseBody setConferenceList(java.util.List<QueryConferenceInfoByRoomCodeResponseBodyConferenceList> conferenceList) {
        this.conferenceList = conferenceList;
        return this;
    }
    public java.util.List<QueryConferenceInfoByRoomCodeResponseBodyConferenceList> getConferenceList() {
        return this.conferenceList;
    }

    public QueryConferenceInfoByRoomCodeResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryConferenceInfoByRoomCodeResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryConferenceInfoByRoomCodeResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryConferenceInfoByRoomCodeResponseBodyConferenceList extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("confDuration")
        public Long confDuration;

        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("creatorNick")
        public String creatorNick;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("externalLinkUrl")
        public String externalLinkUrl;

        @NameInMap("roomCode")
        public String roomCode;

        @NameInMap("scheduleConferenceId")
        public String scheduleConferenceId;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("title")
        public String title;

        public static QueryConferenceInfoByRoomCodeResponseBodyConferenceList build(java.util.Map<String, ?> map) throws Exception {
            QueryConferenceInfoByRoomCodeResponseBodyConferenceList self = new QueryConferenceInfoByRoomCodeResponseBodyConferenceList();
            return TeaModel.build(map, self);
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setConfDuration(Long confDuration) {
            this.confDuration = confDuration;
            return this;
        }
        public Long getConfDuration() {
            return this.confDuration;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setExternalLinkUrl(String externalLinkUrl) {
            this.externalLinkUrl = externalLinkUrl;
            return this;
        }
        public String getExternalLinkUrl() {
            return this.externalLinkUrl;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setRoomCode(String roomCode) {
            this.roomCode = roomCode;
            return this;
        }
        public String getRoomCode() {
            return this.roomCode;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setScheduleConferenceId(String scheduleConferenceId) {
            this.scheduleConferenceId = scheduleConferenceId;
            return this;
        }
        public String getScheduleConferenceId() {
            return this.scheduleConferenceId;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryConferenceInfoByRoomCodeResponseBodyConferenceList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
