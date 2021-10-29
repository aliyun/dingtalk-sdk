// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetRemoteClassCourseResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("success")
    public Boolean success;

    @NameInMap("result")
    public GetRemoteClassCourseResponseBodyResult result;

    public static GetRemoteClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRemoteClassCourseResponseBody self = new GetRemoteClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRemoteClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public GetRemoteClassCourseResponseBody setResult(GetRemoteClassCourseResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetRemoteClassCourseResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetRemoteClassCourseResponseBodyResultTeachingParticipant extends TeaModel {
        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 参与方名称
        @NameInMap("participantName")
        public String participantName;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        // 组织名称
        @NameInMap("orgName")
        public String orgName;

        public static GetRemoteClassCourseResponseBodyResultTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            GetRemoteClassCourseResponseBodyResultTeachingParticipant self = new GetRemoteClassCourseResponseBodyResultTeachingParticipant();
            return TeaModel.build(map, self);
        }

        public GetRemoteClassCourseResponseBodyResultTeachingParticipant setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public GetRemoteClassCourseResponseBodyResultTeachingParticipant setParticipantName(String participantName) {
            this.participantName = participantName;
            return this;
        }
        public String getParticipantName() {
            return this.participantName;
        }

        public GetRemoteClassCourseResponseBodyResultTeachingParticipant setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetRemoteClassCourseResponseBodyResultTeachingParticipant setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class GetRemoteClassCourseResponseBodyResultAttendParticipants extends TeaModel {
        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 参与方名称
        @NameInMap("participantName")
        public String participantName;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        // 组织名称
        @NameInMap("orgName")
        public String orgName;

        public static GetRemoteClassCourseResponseBodyResultAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            GetRemoteClassCourseResponseBodyResultAttendParticipants self = new GetRemoteClassCourseResponseBodyResultAttendParticipants();
            return TeaModel.build(map, self);
        }

        public GetRemoteClassCourseResponseBodyResultAttendParticipants setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public GetRemoteClassCourseResponseBodyResultAttendParticipants setParticipantName(String participantName) {
            this.participantName = participantName;
            return this;
        }
        public String getParticipantName() {
            return this.participantName;
        }

        public GetRemoteClassCourseResponseBodyResultAttendParticipants setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetRemoteClassCourseResponseBodyResultAttendParticipants setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class GetRemoteClassCourseResponseBodyResult extends TeaModel {
        // 课程code
        @NameInMap("courseCode")
        public String courseCode;

        // 课程名称
        @NameInMap("courseName")
        public String courseName;

        // 开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 课程状态：0: 未开始；1: 已开始；2: 已结束
        @NameInMap("status")
        public Integer status;

        // 课堂当前状态：0: 未进行；1: 进行中
        @NameInMap("roomStatus")
        public Integer roomStatus;

        // 课程是否可以编辑或删除
        @NameInMap("canEdit")
        public Boolean canEdit;

        // 授课设备
        @NameInMap("teachingParticipant")
        public GetRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant;

        // 听课设备列表
        @NameInMap("attendParticipants")
        public java.util.List<GetRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants;

        public static GetRemoteClassCourseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRemoteClassCourseResponseBodyResult self = new GetRemoteClassCourseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRemoteClassCourseResponseBodyResult setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public GetRemoteClassCourseResponseBodyResult setCourseName(String courseName) {
            this.courseName = courseName;
            return this;
        }
        public String getCourseName() {
            return this.courseName;
        }

        public GetRemoteClassCourseResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetRemoteClassCourseResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetRemoteClassCourseResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public GetRemoteClassCourseResponseBodyResult setRoomStatus(Integer roomStatus) {
            this.roomStatus = roomStatus;
            return this;
        }
        public Integer getRoomStatus() {
            return this.roomStatus;
        }

        public GetRemoteClassCourseResponseBodyResult setCanEdit(Boolean canEdit) {
            this.canEdit = canEdit;
            return this;
        }
        public Boolean getCanEdit() {
            return this.canEdit;
        }

        public GetRemoteClassCourseResponseBodyResult setTeachingParticipant(GetRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant) {
            this.teachingParticipant = teachingParticipant;
            return this;
        }
        public GetRemoteClassCourseResponseBodyResultTeachingParticipant getTeachingParticipant() {
            return this.teachingParticipant;
        }

        public GetRemoteClassCourseResponseBodyResult setAttendParticipants(java.util.List<GetRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants) {
            this.attendParticipants = attendParticipants;
            return this;
        }
        public java.util.List<GetRemoteClassCourseResponseBodyResultAttendParticipants> getAttendParticipants() {
            return this.attendParticipants;
        }

    }

}
