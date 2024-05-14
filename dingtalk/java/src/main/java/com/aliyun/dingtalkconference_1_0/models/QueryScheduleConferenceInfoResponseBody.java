// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConferenceInfoResponseBody extends TeaModel {
    @NameInMap("conferenceList")
    public java.util.List<QueryScheduleConferenceInfoResponseBodyConferenceList> conferenceList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryScheduleConferenceInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConferenceInfoResponseBody self = new QueryScheduleConferenceInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConferenceInfoResponseBody setConferenceList(java.util.List<QueryScheduleConferenceInfoResponseBodyConferenceList> conferenceList) {
        this.conferenceList = conferenceList;
        return this;
    }
    public java.util.List<QueryScheduleConferenceInfoResponseBodyConferenceList> getConferenceList() {
        return this.conferenceList;
    }

    public QueryScheduleConferenceInfoResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryScheduleConferenceInfoResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryScheduleConferenceInfoResponseBodyConferenceList extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

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

        public static QueryScheduleConferenceInfoResponseBodyConferenceList build(java.util.Map<String, ?> map) throws Exception {
            QueryScheduleConferenceInfoResponseBodyConferenceList self = new QueryScheduleConferenceInfoResponseBodyConferenceList();
            return TeaModel.build(map, self);
        }

        public QueryScheduleConferenceInfoResponseBodyConferenceList setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public QueryScheduleConferenceInfoResponseBodyConferenceList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryScheduleConferenceInfoResponseBodyConferenceList setRoomCode(String roomCode) {
            this.roomCode = roomCode;
            return this;
        }
        public String getRoomCode() {
            return this.roomCode;
        }

        public QueryScheduleConferenceInfoResponseBodyConferenceList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryScheduleConferenceInfoResponseBodyConferenceList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryScheduleConferenceInfoResponseBodyConferenceList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
