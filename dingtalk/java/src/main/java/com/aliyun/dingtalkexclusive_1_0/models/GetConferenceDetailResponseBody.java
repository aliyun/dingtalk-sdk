// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConferenceDetailResponseBody extends TeaModel {
    // 会议ID
    @NameInMap("conferenceId")
    public String conferenceId;

    // 会议标题
    @NameInMap("title")
    public String title;

    // 开始时间
    @NameInMap("confStartTime")
    public Float confStartTime;

    // 持续时间
    @NameInMap("duration")
    public Float duration;

    // 会议人数
    @NameInMap("totalNum")
    public Long totalNum;

    // 出席会议人数
    @NameInMap("attendeeNum")
    public Long attendeeNum;

    // 出席率
    @NameInMap("attendeePercentage")
    public String attendeePercentage;

    // 发起人uid
    @NameInMap("callerId")
    public String callerId;

    // 发起人昵称
    @NameInMap("callerName")
    public String callerName;

    // 参会人员列表
    @NameInMap("memberList")
    public java.util.List<GetConferenceDetailResponseBodyMemberList> memberList;

    public static GetConferenceDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConferenceDetailResponseBody self = new GetConferenceDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConferenceDetailResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public GetConferenceDetailResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetConferenceDetailResponseBody setConfStartTime(Float confStartTime) {
        this.confStartTime = confStartTime;
        return this;
    }
    public Float getConfStartTime() {
        return this.confStartTime;
    }

    public GetConferenceDetailResponseBody setDuration(Float duration) {
        this.duration = duration;
        return this;
    }
    public Float getDuration() {
        return this.duration;
    }

    public GetConferenceDetailResponseBody setTotalNum(Long totalNum) {
        this.totalNum = totalNum;
        return this;
    }
    public Long getTotalNum() {
        return this.totalNum;
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

    public GetConferenceDetailResponseBody setMemberList(java.util.List<GetConferenceDetailResponseBodyMemberList> memberList) {
        this.memberList = memberList;
        return this;
    }
    public java.util.List<GetConferenceDetailResponseBodyMemberList> getMemberList() {
        return this.memberList;
    }

    public static class GetConferenceDetailResponseBodyMemberList extends TeaModel {
        // 用户uid
        @NameInMap("unionId")
        public String unionId;

        // 用户昵称
        @NameInMap("name")
        public String name;

        // 参会时长
        @NameInMap("attendDuration")
        public Float attendDuration;

        // 员工id
        @NameInMap("staffId")
        public String staffId;

        public static GetConferenceDetailResponseBodyMemberList build(java.util.Map<String, ?> map) throws Exception {
            GetConferenceDetailResponseBodyMemberList self = new GetConferenceDetailResponseBodyMemberList();
            return TeaModel.build(map, self);
        }

        public GetConferenceDetailResponseBodyMemberList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetConferenceDetailResponseBodyMemberList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetConferenceDetailResponseBodyMemberList setAttendDuration(Float attendDuration) {
            this.attendDuration = attendDuration;
            return this;
        }
        public Float getAttendDuration() {
            return this.attendDuration;
        }

        public GetConferenceDetailResponseBodyMemberList setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

}
