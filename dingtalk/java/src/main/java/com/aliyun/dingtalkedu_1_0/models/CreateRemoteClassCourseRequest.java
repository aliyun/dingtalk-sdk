// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRemoteClassCourseRequest extends TeaModel {
    /**
     * <p>听课设备列表</p>
     */
    @NameInMap("attendParticipants")
    public java.util.List<CreateRemoteClassCourseRequestAttendParticipants> attendParticipants;

    /**
     * <p>免登码</p>
     */
    @NameInMap("authCode")
    public String authCode;

    /**
     * <p>课程名称</p>
     */
    @NameInMap("courseName")
    public String courseName;

    /**
     * <p>结束时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>授课设备</p>
     */
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
        /**
         * <p>组织ID</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>参与方ID</p>
         */
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
        /**
         * <p>组织ID</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>参与方ID</p>
         */
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
