// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateRemoteClassCourseRequest extends TeaModel {
    // 课程名称
    @NameInMap("courseName")
    public String courseName;

    // 课程开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 课程结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 授课设备
    @NameInMap("teachingParticipant")
    public UpdateRemoteClassCourseRequestTeachingParticipant teachingParticipant;

    // 听课设备
    @NameInMap("attendParticipants")
    public java.util.List<UpdateRemoteClassCourseRequestAttendParticipants> attendParticipants;

    // 课程码
    @NameInMap("courseCode")
    public String courseCode;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("authCode")
    public String authCode;

    public static UpdateRemoteClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRemoteClassCourseRequest self = new UpdateRemoteClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRemoteClassCourseRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public UpdateRemoteClassCourseRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public UpdateRemoteClassCourseRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public UpdateRemoteClassCourseRequest setTeachingParticipant(UpdateRemoteClassCourseRequestTeachingParticipant teachingParticipant) {
        this.teachingParticipant = teachingParticipant;
        return this;
    }
    public UpdateRemoteClassCourseRequestTeachingParticipant getTeachingParticipant() {
        return this.teachingParticipant;
    }

    public UpdateRemoteClassCourseRequest setAttendParticipants(java.util.List<UpdateRemoteClassCourseRequestAttendParticipants> attendParticipants) {
        this.attendParticipants = attendParticipants;
        return this;
    }
    public java.util.List<UpdateRemoteClassCourseRequestAttendParticipants> getAttendParticipants() {
        return this.attendParticipants;
    }

    public UpdateRemoteClassCourseRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public UpdateRemoteClassCourseRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public UpdateRemoteClassCourseRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public UpdateRemoteClassCourseRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpdateRemoteClassCourseRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public UpdateRemoteClassCourseRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public UpdateRemoteClassCourseRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpdateRemoteClassCourseRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public static class UpdateRemoteClassCourseRequestTeachingParticipant extends TeaModel {
        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        public static UpdateRemoteClassCourseRequestTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            UpdateRemoteClassCourseRequestTeachingParticipant self = new UpdateRemoteClassCourseRequestTeachingParticipant();
            return TeaModel.build(map, self);
        }

        public UpdateRemoteClassCourseRequestTeachingParticipant setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public UpdateRemoteClassCourseRequestTeachingParticipant setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

    public static class UpdateRemoteClassCourseRequestAttendParticipants extends TeaModel {
        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        public static UpdateRemoteClassCourseRequestAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            UpdateRemoteClassCourseRequestAttendParticipants self = new UpdateRemoteClassCourseRequestAttendParticipants();
            return TeaModel.build(map, self);
        }

        public UpdateRemoteClassCourseRequestAttendParticipants setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public UpdateRemoteClassCourseRequestAttendParticipants setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

}
