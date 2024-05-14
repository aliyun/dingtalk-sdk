// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateRemoteClassCourseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("attendParticipants")
    public java.util.List<UpdateRemoteClassCourseRequestAttendParticipants> attendParticipants;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authCode")
    public String authCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courseCode")
    public String courseCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courseName")
    public String courseName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teachingParticipant")
    public UpdateRemoteClassCourseRequestTeachingParticipant teachingParticipant;

    public static UpdateRemoteClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRemoteClassCourseRequest self = new UpdateRemoteClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRemoteClassCourseRequest setAttendParticipants(java.util.List<UpdateRemoteClassCourseRequestAttendParticipants> attendParticipants) {
        this.attendParticipants = attendParticipants;
        return this;
    }
    public java.util.List<UpdateRemoteClassCourseRequestAttendParticipants> getAttendParticipants() {
        return this.attendParticipants;
    }

    public UpdateRemoteClassCourseRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public UpdateRemoteClassCourseRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public UpdateRemoteClassCourseRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public UpdateRemoteClassCourseRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public UpdateRemoteClassCourseRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public UpdateRemoteClassCourseRequest setTeachingParticipant(UpdateRemoteClassCourseRequestTeachingParticipant teachingParticipant) {
        this.teachingParticipant = teachingParticipant;
        return this;
    }
    public UpdateRemoteClassCourseRequestTeachingParticipant getTeachingParticipant() {
        return this.teachingParticipant;
    }

    public static class UpdateRemoteClassCourseRequestAttendParticipants extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("participantId")
        public String participantId;

        public static UpdateRemoteClassCourseRequestAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            UpdateRemoteClassCourseRequestAttendParticipants self = new UpdateRemoteClassCourseRequestAttendParticipants();
            return TeaModel.build(map, self);
        }

        public UpdateRemoteClassCourseRequestAttendParticipants setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public UpdateRemoteClassCourseRequestAttendParticipants setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

    }

    public static class UpdateRemoteClassCourseRequestTeachingParticipant extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("participantId")
        public String participantId;

        public static UpdateRemoteClassCourseRequestTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            UpdateRemoteClassCourseRequestTeachingParticipant self = new UpdateRemoteClassCourseRequestTeachingParticipant();
            return TeaModel.build(map, self);
        }

        public UpdateRemoteClassCourseRequestTeachingParticipant setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public UpdateRemoteClassCourseRequestTeachingParticipant setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

    }

}
