// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgConferenceListResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("onGoingConfList")
    public java.util.List<QueryOrgConferenceListResponseBodyOnGoingConfList> onGoingConfList;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryOrgConferenceListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgConferenceListResponseBody self = new QueryOrgConferenceListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgConferenceListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryOrgConferenceListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryOrgConferenceListResponseBody setOnGoingConfList(java.util.List<QueryOrgConferenceListResponseBodyOnGoingConfList> onGoingConfList) {
        this.onGoingConfList = onGoingConfList;
        return this;
    }
    public java.util.List<QueryOrgConferenceListResponseBodyOnGoingConfList> getOnGoingConfList() {
        return this.onGoingConfList;
    }

    public QueryOrgConferenceListResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryOrgConferenceListResponseBodyOnGoingConfList extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("creatorNick")
        public String creatorNick;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("roomCode")
        public String roomCode;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("title")
        public String title;

        public static QueryOrgConferenceListResponseBodyOnGoingConfList build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgConferenceListResponseBodyOnGoingConfList self = new QueryOrgConferenceListResponseBodyOnGoingConfList();
            return TeaModel.build(map, self);
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setRoomCode(String roomCode) {
            this.roomCode = roomCode;
            return this;
        }
        public String getRoomCode() {
            return this.roomCode;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryOrgConferenceListResponseBodyOnGoingConfList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
