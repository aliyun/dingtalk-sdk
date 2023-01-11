// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceMembersResponseBody extends TeaModel {
    /**
     * <p>成员列表</p>
     */
    @NameInMap("memberModels")
    public java.util.List<QueryConferenceMembersResponseBodyMemberModels> memberModels;

    /**
     * <p>分页查询下一页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>本次返回结果数</p>
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
         * <p>成员状态 </p>
         * <p>1 初始化 </p>
         * <p>2 呼叫中</p>
         * <p>3 活跃（在会）</p>
         * <p>4 入会失败（拒接等）</p>
         * <p>5 被踢</p>
         * <p>6 离会</p>
         */
        @NameInMap("attendStatus")
        public Integer attendStatus;

        /**
         * <p>是否为联席主持人</p>
         */
        @NameInMap("coHost")
        public Boolean coHost;

        /**
         * <p>会议id</p>
         */
        @NameInMap("conferenceId")
        public String conferenceId;

        /**
         * <p>在会时长</p>
         */
        @NameInMap("duration")
        public Long duration;

        /**
         * <p>是否为主持人</p>
         */
        @NameInMap("host")
        public Boolean host;

        /**
         * <p>入会时间</p>
         */
        @NameInMap("joinTime")
        public Long joinTime;

        /**
         * <p>离会时间</p>
         */
        @NameInMap("leaveTime")
        public Long leaveTime;

        /**
         * <p>是否为非会议所属企业内成员</p>
         */
        @NameInMap("outerOrgMember")
        public Boolean outerOrgMember;

        /**
         * <p>是否为pstn入会</p>
         */
        @NameInMap("pstnJoin")
        public Boolean pstnJoin;

        /**
         * <p>用户unionId</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>成员昵称</p>
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

        public QueryConferenceMembersResponseBodyMemberModels setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
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
