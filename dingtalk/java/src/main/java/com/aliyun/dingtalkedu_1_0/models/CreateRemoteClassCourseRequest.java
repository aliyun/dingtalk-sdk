// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRemoteClassCourseRequest extends TeaModel {
    // 课程名称
    @NameInMap("courseName")
    public String courseName;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 授课设备
    @NameInMap("teachingParticipant")
    public CreateRemoteClassCourseRequestTeachingParticipant teachingParticipant;

    // 听课设备列表
    @NameInMap("attendParticipants")
    public java.util.List<CreateRemoteClassCourseRequestAttendParticipants> attendParticipants;

    // 免登码
    @NameInMap("authCode")
    public String authCode;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    public static CreateRemoteClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRemoteClassCourseRequest self = new CreateRemoteClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public CreateRemoteClassCourseRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public CreateRemoteClassCourseRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateRemoteClassCourseRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateRemoteClassCourseRequest setTeachingParticipant(CreateRemoteClassCourseRequestTeachingParticipant teachingParticipant) {
        this.teachingParticipant = teachingParticipant;
        return this;
    }
    public CreateRemoteClassCourseRequestTeachingParticipant getTeachingParticipant() {
        return this.teachingParticipant;
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

    public CreateRemoteClassCourseRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public CreateRemoteClassCourseRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateRemoteClassCourseRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateRemoteClassCourseRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public CreateRemoteClassCourseRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreateRemoteClassCourseRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public static class CreateRemoteClassCourseRequestTeachingParticipant extends TeaModel {
        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        public static CreateRemoteClassCourseRequestTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            CreateRemoteClassCourseRequestTeachingParticipant self = new CreateRemoteClassCourseRequestTeachingParticipant();
            return TeaModel.build(map, self);
        }

        public CreateRemoteClassCourseRequestTeachingParticipant setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public CreateRemoteClassCourseRequestTeachingParticipant setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

    public static class CreateRemoteClassCourseRequestAttendParticipants extends TeaModel {
        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        public static CreateRemoteClassCourseRequestAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            CreateRemoteClassCourseRequestAttendParticipants self = new CreateRemoteClassCourseRequestAttendParticipants();
            return TeaModel.build(map, self);
        }

        public CreateRemoteClassCourseRequestAttendParticipants setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public CreateRemoteClassCourseRequestAttendParticipants setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

}
