// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConferenceDetailResponseBody extends TeaModel {
    /**
     * <p>出席会议人数</p>
     */
    @NameInMap("attendeeNum")
    public Long attendeeNum;

    /**
     * <p>出席率</p>
     */
    @NameInMap("attendeePercentage")
    public String attendeePercentage;

    /**
     * <p>发起人uid</p>
     */
    @NameInMap("callerId")
    public String callerId;

    /**
     * <p>发起人昵称</p>
     */
    @NameInMap("callerName")
    public String callerName;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("confStartTime")
    public Float confStartTime;

    /**
     * <p>会议ID</p>
     */
    @NameInMap("conferenceId")
    public String conferenceId;

    /**
     * <p>持续时间</p>
     */
    @NameInMap("duration")
    public Float duration;

    /**
     * <p>参会人员列表</p>
     */
    @NameInMap("memberList")
    public java.util.List<GetConferenceDetailResponseBodyMemberList> memberList;

    /**
     * <p>会议标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>会议人数</p>
     */
    @NameInMap("totalNum")
    public Long totalNum;

    public static GetConferenceDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConferenceDetailResponseBody self = new GetConferenceDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConferenceDetailResponseBody setAttendeeNum(Long attendeeNum) {
        this.attendeeNum = attendeeNum;
        return this;
    }
    public Long getAttendeeNum() {
        return this.attendeeNum;
    }

    public GetConferenceDetailResponseBody setAttendeePercentage(String attendeePercentage) {
        this.attendeePercentage = attendeePercentage;
        return this;
    }
    public String getAttendeePercentage() {
        return this.attendeePercentage;
    }

    public GetConferenceDetailResponseBody setCallerId(String callerId) {
        this.callerId = callerId;
        return this;
    }
    public String getCallerId() {
        return this.callerId;
    }

    public GetConferenceDetailResponseBody setCallerName(String callerName) {
        this.callerName = callerName;
        return this;
    }
    public String getCallerName() {
        return this.callerName;
    }

    public GetConferenceDetailResponseBody setConfStartTime(Float confStartTime) {
        this.confStartTime = confStartTime;
        return this;
    }
    public Float getConfStartTime() {
        return this.confStartTime;
    }

    public GetConferenceDetailResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public GetConferenceDetailResponseBody setDuration(Float duration) {
        this.duration = duration;
        return this;
    }
    public Float getDuration() {
        return this.duration;
    }

    public GetConferenceDetailResponseBody setMemberList(java.util.List<GetConferenceDetailResponseBodyMemberList> memberList) {
        this.memberList = memberList;
        return this;
    }
    public java.util.List<GetConferenceDetailResponseBodyMemberList> getMemberList() {
        return this.memberList;
    }

    public GetConferenceDetailResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetConferenceDetailResponseBody setTotalNum(Long totalNum) {
        this.totalNum = totalNum;
        return this;
    }
    public Long getTotalNum() {
        return this.totalNum;
    }

    public static class GetConferenceDetailResponseBodyMemberList extends TeaModel {
        /**
         * <p>参会时长</p>
         */
        @NameInMap("attendDuration")
        public Float attendDuration;

        /**
         * <p>用户昵称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>员工id</p>
         */
        @NameInMap("staffId")
        public String staffId;

        /**
         * <p>用户uid</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static GetConferenceDetailResponseBodyMemberList build(java.util.Map<String, ?> map) throws Exception {
            GetConferenceDetailResponseBodyMemberList self = new GetConferenceDetailResponseBodyMemberList();
            return TeaModel.build(map, self);
        }

        public GetConferenceDetailResponseBodyMemberList setAttendDuration(Float attendDuration) {
            this.attendDuration = attendDuration;
            return this;
        }
        public Float getAttendDuration() {
            return this.attendDuration;
        }

        public GetConferenceDetailResponseBodyMemberList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetConferenceDetailResponseBodyMemberList setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

        public GetConferenceDetailResponseBodyMemberList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
