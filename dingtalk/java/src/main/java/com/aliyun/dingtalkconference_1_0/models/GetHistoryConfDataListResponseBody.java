// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetHistoryConfDataListResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<GetHistoryConfDataListResponseBodyList> list;

    @NameInMap("nextToken")
    public String nextToken;

    public static GetHistoryConfDataListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetHistoryConfDataListResponseBody self = new GetHistoryConfDataListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetHistoryConfDataListResponseBody setList(java.util.List<GetHistoryConfDataListResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<GetHistoryConfDataListResponseBodyList> getList() {
        return this.list;
    }

    public GetHistoryConfDataListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class GetHistoryConfDataListResponseBodyList extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("creatorNick")
        public String creatorNick;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("freeType")
        public String freeType;

        @NameInMap("scene")
        public String scene;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("timeLength")
        public Long timeLength;

        @NameInMap("title")
        public String title;

        @NameInMap("userCount")
        public Integer userCount;

        public static GetHistoryConfDataListResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            GetHistoryConfDataListResponseBodyList self = new GetHistoryConfDataListResponseBodyList();
            return TeaModel.build(map, self);
        }

        public GetHistoryConfDataListResponseBodyList setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public GetHistoryConfDataListResponseBodyList setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetHistoryConfDataListResponseBodyList setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public GetHistoryConfDataListResponseBodyList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetHistoryConfDataListResponseBodyList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetHistoryConfDataListResponseBodyList setFreeType(String freeType) {
            this.freeType = freeType;
            return this;
        }
        public String getFreeType() {
            return this.freeType;
        }

        public GetHistoryConfDataListResponseBodyList setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public GetHistoryConfDataListResponseBodyList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetHistoryConfDataListResponseBodyList setTimeLength(Long timeLength) {
            this.timeLength = timeLength;
            return this;
        }
        public Long getTimeLength() {
            return this.timeLength;
        }

        public GetHistoryConfDataListResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetHistoryConfDataListResponseBodyList setUserCount(Integer userCount) {
            this.userCount = userCount;
            return this;
        }
        public Integer getUserCount() {
            return this.userCount;
        }

    }

}
