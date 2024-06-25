// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDetailDataResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<GetConfDetailDataResponseBodyList> list;

    /**
     * <strong>example:</strong>
     * <p>xxxxZ0bVGoqxxBGQbxdxxxx</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("belongOrg")
        public String belongOrg;

        /**
         * <strong>example:</strong>
         * <p>6449d8a6414xxxxxxxx01464af9f0</p>
         */
        @NameInMap("conferenceId")
        public String conferenceId;

        /**
         * <strong>example:</strong>
         * <p>Mac</p>
         */
        @NameInMap("deviceType")
        public String deviceType;

        /**
         * <strong>example:</strong>
         * <p>974000</p>
         */
        @NameInMap("duration")
        public Long duration;

        /**
         * <strong>example:</strong>
         * <p>1682561199000</p>
         */
        @NameInMap("joinTime")
        public Long joinTime;

        /**
         * <strong>example:</strong>
         * <p>1682562173000</p>
         */
        @NameInMap("leaveTime")
        public Long leaveTime;

        /**
         * <strong>example:</strong>
         * <p>-1</p>
         */
        @NameInMap("networkQuality")
        public String networkQuality;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("nick")
        public String nick;

        /**
         * <strong>example:</strong>
         * <p>参会人</p>
         */
        @NameInMap("role")
        public String role;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("sessionId")
        public String sessionId;

        /**
         * <strong>example:</strong>
         * <p>已离开</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>njMTqKo9xxxxEiE</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>6.1.1</p>
         */
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
