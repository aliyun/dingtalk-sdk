// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListDeviceRecordingDurationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("teamCode")
    public String teamCode;

    @NameInMap("userId")
    public String userId;

    public static ListDeviceRecordingDurationRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDeviceRecordingDurationRequest self = new ListDeviceRecordingDurationRequest();
        return TeaModel.build(map, self);
    }

    public ListDeviceRecordingDurationRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ListDeviceRecordingDurationRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListDeviceRecordingDurationRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListDeviceRecordingDurationRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public ListDeviceRecordingDurationRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public ListDeviceRecordingDurationRequest setTeamCode(String teamCode) {
        this.teamCode = teamCode;
        return this;
    }
    public String getTeamCode() {
        return this.teamCode;
    }

    public ListDeviceRecordingDurationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
