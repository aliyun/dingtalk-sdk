// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceMembersResponseBody extends TeaModel {
    @NameInMap("memberModels")
    public java.util.List<QueryConferenceMembersResponseBodyMemberModels> memberModels;

    /**
     * <strong>example:</strong>
     * <p>123000000</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryConferenceMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceMembersResponseBody self = new QueryConferenceMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryConferenceMembersResponseBody setMemberModels(java.util.List<QueryConferenceMembersResponseBodyMemberModels> memberModels) {
        this.memberModels = memberModels;
        return this;
    }
    public java.util.List<QueryConferenceMembersResponseBodyMemberModels> getMemberModels() {
        return this.memberModels;
    }

    public QueryConferenceMembersResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryConferenceMembersResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryConferenceMembersResponseBodyMemberModels extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>6</p>
         */
        @NameInMap("attendStatus")
        public Integer attendStatus;

        @NameInMap("coHost")
        public Boolean coHost;

        /**
         * <strong>example:</strong>
         * <p>6323d7562b18000142ab9d10</p>
         */
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("duration")
        public Long duration;

        @NameInMap("host")
        public Boolean host;

        @NameInMap("joinTime")
        public Long joinTime;

        @NameInMap("leaveTime")
        public Long leaveTime;

        @NameInMap("outerOrgMember")
        public Boolean outerOrgMember;

        @NameInMap("pstnJoin")
        public Boolean pstnJoin;

        /**
         * <strong>example:</strong>
         * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>昵称</p>
         */
        @NameInMap("userNick")
        public String userNick;

        public static QueryConferenceMembersResponseBodyMemberModels build(java.util.Map<String, ?> map) throws Exception {
            QueryConferenceMembersResponseBodyMemberModels self = new QueryConferenceMembersResponseBodyMemberModels();
            return TeaModel.build(map, self);
        }

        public QueryConferenceMembersResponseBodyMemberModels setAttendStatus(Integer attendStatus) {
            this.attendStatus = attendStatus;
            return this;
        }
        public Integer getAttendStatus() {
            return this.attendStatus;
        }

        public QueryConferenceMembersResponseBodyMemberModels setCoHost(Boolean coHost) {
            this.coHost = coHost;
            return this;
        }
        public Boolean getCoHost() {
            return this.coHost;
        }

        public QueryConferenceMembersResponseBodyMemberModels setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public QueryConferenceMembersResponseBodyMemberModels setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryConferenceMembersResponseBodyMemberModels setHost(Boolean host) {
            this.host = host;
            return this;
        }
        public Boolean getHost() {
            return this.host;
        }

        public QueryConferenceMembersResponseBodyMemberModels setJoinTime(Long joinTime) {
            this.joinTime = joinTime;
            return this;
        }
        public Long getJoinTime() {
            return this.joinTime;
        }

        public QueryConferenceMembersResponseBodyMemberModels setLeaveTime(Long leaveTime) {
            this.leaveTime = leaveTime;
            return this;
        }
        public Long getLeaveTime() {
            return this.leaveTime;
        }

        public QueryConferenceMembersResponseBodyMemberModels setOuterOrgMember(Boolean outerOrgMember) {
            this.outerOrgMember = outerOrgMember;
            return this;
        }
        public Boolean getOuterOrgMember() {
            return this.outerOrgMember;
        }

        public QueryConferenceMembersResponseBodyMemberModels setPstnJoin(Boolean pstnJoin) {
            this.pstnJoin = pstnJoin;
            return this;
        }
        public Boolean getPstnJoin() {
            return this.pstnJoin;
        }

        public QueryConferenceMembersResponseBodyMemberModels setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryConferenceMembersResponseBodyMemberModels setUserNick(String userNick) {
            this.userNick = userNick;
            return this;
        }
        public String getUserNick() {
            return this.userNick;
        }

    }

}
