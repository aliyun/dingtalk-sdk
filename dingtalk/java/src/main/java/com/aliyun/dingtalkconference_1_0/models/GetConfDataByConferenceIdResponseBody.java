// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDataByConferenceIdResponseBody extends TeaModel {
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

    public static GetConfDataByConferenceIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConfDataByConferenceIdResponseBody self = new GetConfDataByConferenceIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConfDataByConferenceIdResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public GetConfDataByConferenceIdResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetConfDataByConferenceIdResponseBody setCreatorNick(String creatorNick) {
        this.creatorNick = creatorNick;
        return this;
    }
    public String getCreatorNick() {
        return this.creatorNick;
    }

    public GetConfDataByConferenceIdResponseBody setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public GetConfDataByConferenceIdResponseBody setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetConfDataByConferenceIdResponseBody setFreeType(String freeType) {
        this.freeType = freeType;
        return this;
    }
    public String getFreeType() {
        return this.freeType;
    }

    public GetConfDataByConferenceIdResponseBody setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public GetConfDataByConferenceIdResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetConfDataByConferenceIdResponseBody setTimeLength(Long timeLength) {
        this.timeLength = timeLength;
        return this;
    }
    public Long getTimeLength() {
        return this.timeLength;
    }

    public GetConfDataByConferenceIdResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetConfDataByConferenceIdResponseBody setUserCount(Integer userCount) {
        this.userCount = userCount;
        return this;
    }
    public Integer getUserCount() {
        return this.userCount;
    }

}
