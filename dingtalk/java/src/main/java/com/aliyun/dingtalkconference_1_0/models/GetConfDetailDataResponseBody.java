// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDetailDataResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<GetConfDetailDataResponseBodyList> list;

    @NameInMap("nextToken")
    public String nextToken;

    public static GetConfDetailDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConfDetailDataResponseBody self = new GetConfDetailDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConfDetailDataResponseBody setList(java.util.List<GetConfDetailDataResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<GetConfDetailDataResponseBodyList> getList() {
        return this.list;
    }

    public GetConfDetailDataResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class GetConfDetailDataResponseBodyList extends TeaModel {
        @NameInMap("belongOrg")
        public String belongOrg;

        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("deviceType")
        public String deviceType;

        @NameInMap("duration")
        public Long duration;

        @NameInMap("joinTime")
        public Long joinTime;

        @NameInMap("leaveTime")
        public Long leaveTime;

        @NameInMap("networkQuality")
        public String networkQuality;

        @NameInMap("nick")
        public String nick;

        @NameInMap("role")
        public String role;

        @NameInMap("sessionId")
        public String sessionId;

        @NameInMap("status")
        public String status;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("version")
        public String version;

        public static GetConfDetailDataResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            GetConfDetailDataResponseBodyList self = new GetConfDetailDataResponseBodyList();
            return TeaModel.build(map, self);
        }

        public GetConfDetailDataResponseBodyList setBelongOrg(String belongOrg) {
            this.belongOrg = belongOrg;
            return this;
        }
        public String getBelongOrg() {
            return this.belongOrg;
        }

        public GetConfDetailDataResponseBodyList setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public GetConfDetailDataResponseBodyList setDeviceType(String deviceType) {
            this.deviceType = deviceType;
            return this;
        }
        public String getDeviceType() {
            return this.deviceType;
        }

        public GetConfDetailDataResponseBodyList setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public GetConfDetailDataResponseBodyList setJoinTime(Long joinTime) {
            this.joinTime = joinTime;
            return this;
        }
        public Long getJoinTime() {
            return this.joinTime;
        }

        public GetConfDetailDataResponseBodyList setLeaveTime(Long leaveTime) {
            this.leaveTime = leaveTime;
            return this;
        }
        public Long getLeaveTime() {
            return this.leaveTime;
        }

        public GetConfDetailDataResponseBodyList setNetworkQuality(String networkQuality) {
            this.networkQuality = networkQuality;
            return this;
        }
        public String getNetworkQuality() {
            return this.networkQuality;
        }

        public GetConfDetailDataResponseBodyList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public GetConfDetailDataResponseBodyList setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public GetConfDetailDataResponseBodyList setSessionId(String sessionId) {
            this.sessionId = sessionId;
            return this;
        }
        public String getSessionId() {
            return this.sessionId;
        }

        public GetConfDetailDataResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetConfDetailDataResponseBodyList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetConfDetailDataResponseBodyList setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
