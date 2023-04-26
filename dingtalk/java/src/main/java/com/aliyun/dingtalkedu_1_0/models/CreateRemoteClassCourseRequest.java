// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRemoteClassCourseRequest extends TeaModel {
    @NameInMap("attendParticipants")
    public java.util.List<CreateRemoteClassCourseRequestAttendParticipants> attendParticipants;

    @NameInMap("authCode")
    public String authCode;

    @NameInMap("courseName")
    public String courseName;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("teachingParticipant")
    public CreateRemoteClassCourseRequestTeachingParticipant teachingParticipant;

    public static CreateRemoteClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRemoteClassCourseRequest self = new CreateRemoteClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public CreateRemoteClassCourseRequest setAttendParticipants(java.util.List<CreateRemoteClassCourseRequestAttendParticipants> attendParticipants) {
        this.attendParticipants = attendParticipants;
        return this;
    }
    public java.util.List<CreateRemoteClassCourseRequestAttendParticipants> getAttendParticipants() {
        return this.attendParticipants;
    }

    public CreateRemoteClassCourseRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public CreateRemoteClassCourseRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public CreateRemoteClassCourseRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateRemoteClassCourseRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateRemoteClassCourseRequest setTeachingParticipant(CreateRemoteClassCourseRequestTeachingParticipant teachingParticipant) {
        this.teachingParticipant = teachingParticipant;
        return this;
    }
    public CreateRemoteClassCourseRequestTeachingParticipant getTeachingParticipant() {
        return this.teachingParticipant;
    }

    public static class CreateRemoteClassCourseRequestAttendParticipants extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("participantId")
        public String participantId;

        public static CreateRemoteClassCourseRequestAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            CreateRemoteClassCourseRequestAttendParticipants self = new CreateRemoteClassCourseRequestAttendParticipants();
            return TeaModel.build(map, self);
        }

        public CreateRemoteClassCourseRequestAttendParticipants setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public CreateRemoteClassCourseRequestAttendParticipants setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

    }

    public static class CreateRemoteClassCourseRequestTeachingParticipant extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("participantId")
        public String participantId;

        public static CreateRemoteClassCourseRequestTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            CreateRemoteClassCourseRequestTeachingParticipant self = new CreateRemoteClassCourseRequestTeachingParticipant();
            return TeaModel.build(map, self);
        }

        public CreateRemoteClassCourseRequestTeachingParticipant setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public CreateRemoteClassCourseRequestTeachingParticipant setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

    }

}
