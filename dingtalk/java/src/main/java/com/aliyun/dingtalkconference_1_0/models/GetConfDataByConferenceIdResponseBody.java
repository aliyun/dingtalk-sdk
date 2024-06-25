// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDataByConferenceIdResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>6449d8a6414xxxxxxxx01464af9f0</p>
     */
    @NameInMap("conferenceId")
    public String conferenceId;

    /**
     * <strong>example:</strong>
     * <p>njMTqKo9xxxxEiE</p>
     */
    @NameInMap("creatorId")
    public String creatorId;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("creatorNick")
    public String creatorNick;

    /**
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <strong>example:</strong>
     * <p>1682561790000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("freeType")
    public String freeType;

    /**
     * <strong>example:</strong>
     * <p>ding_talk</p>
     */
    @NameInMap("scene")
    public String scene;

    /**
     * <strong>example:</strong>
     * <p>1682561190000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <strong>example:</strong>
     * <p>600000</p>
     */
    @NameInMap("timeLength")
    public Long timeLength;

    /**
     * <strong>example:</strong>
     * <p>xxxxx测试会议</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
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
