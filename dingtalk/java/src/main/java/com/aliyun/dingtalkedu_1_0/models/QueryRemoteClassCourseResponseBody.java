// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryRemoteClassCourseResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("success")
    public Boolean success;

    @NameInMap("result")
    public java.util.List<QueryRemoteClassCourseResponseBodyResult> result;

    public static QueryRemoteClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRemoteClassCourseResponseBody self = new QueryRemoteClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRemoteClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public QueryRemoteClassCourseResponseBody setResult(java.util.List<QueryRemoteClassCourseResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryRemoteClassCourseResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryRemoteClassCourseResponseBodyResultTeachingParticipant extends TeaModel {
        // 参与方名称
        @NameInMap("participantName")
        public String participantName;

        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        // 组织名称
        @NameInMap("orgName")
        public String orgName;

        public static QueryRemoteClassCourseResponseBodyResultTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            QueryRemoteClassCourseResponseBodyResultTeachingParticipant self = new QueryRemoteClassCourseResponseBodyResultTeachingParticipant();
            return TeaModel.build(map, self);
        }

        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant setParticipantName(String participantName) {
            this.participantName = participantName;
            return this;
        }
        public String getParticipantName() {
            return this.participantName;
        }

        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class QueryRemoteClassCourseResponseBodyResultAttendParticipants extends TeaModel {
        // 参与方名称
        @NameInMap("participantName")
        public String participantName;

        // 参与方ID
        @NameInMap("participantId")
        public String participantId;

        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        // 组织名称
        @NameInMap("orgName")
        public String orgName;

        public static QueryRemoteClassCourseResponseBodyResultAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            QueryRemoteClassCourseResponseBodyResultAttendParticipants self = new QueryRemoteClassCourseResponseBodyResultAttendParticipants();
            return TeaModel.build(map, self);
        }

        public QueryRemoteClassCourseResponseBodyResultAttendParticipants setParticipantName(String participantName) {
            this.participantName = participantName;
            return this;
        }
        public String getParticipantName() {
            return this.participantName;
        }

        public QueryRemoteClassCourseResponseBodyResultAttendParticipants setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public QueryRemoteClassCourseResponseBodyResultAttendParticipants setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryRemoteClassCourseResponseBodyResultAttendParticipants setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class QueryRemoteClassCourseResponseBodyResult extends TeaModel {
        // 课程code
        @NameInMap("courseCode")
        public String courseCode;

        // 课程名称
        @NameInMap("courseName")
        public String courseName;

        // 课程状态：0: 未开始；1: 已开始；2: 已结束
        @NameInMap("status")
        public Integer status;

        // 开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 课程是否可以编辑或删除
        @NameInMap("canEdit")
        public Boolean canEdit;

        // 授课设备
        @NameInMap("teachingParticipant")
        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant;

        // 听课设备列表
        @NameInMap("attendParticipants")
        public java.util.List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants;

        // 当前组织在课程中的角色列表：TEACHING：授课方；ATTEND：听课方
        @NameInMap("courseWays")
        public java.util.List<String> courseWays;

        public static QueryRemoteClassCourseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryRemoteClassCourseResponseBodyResult self = new QueryRemoteClassCourseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryRemoteClassCourseResponseBodyResult setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public QueryRemoteClassCourseResponseBodyResult setCourseName(String courseName) {
            this.courseName = courseName;
            return this;
        }
        public String getCourseName() {
            return this.courseName;
        }

        public QueryRemoteClassCourseResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryRemoteClassCourseResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryRemoteClassCourseResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryRemoteClassCourseResponseBodyResult setCanEdit(Boolean canEdit) {
            this.canEdit = canEdit;
            return this;
        }
        public Boolean getCanEdit() {
            return this.canEdit;
        }

        public QueryRemoteClassCourseResponseBodyResult setTeachingParticipant(QueryRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant) {
            this.teachingParticipant = teachingParticipant;
            return this;
        }
        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant getTeachingParticipant() {
            return this.teachingParticipant;
        }

        public QueryRemoteClassCourseResponseBodyResult setAttendParticipants(java.util.List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants) {
            this.attendParticipants = attendParticipants;
            return this;
        }
        public java.util.List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> getAttendParticipants() {
            return this.attendParticipants;
        }

        public QueryRemoteClassCourseResponseBodyResult setCourseWays(java.util.List<String> courseWays) {
            this.courseWays = courseWays;
            return this;
        }
        public java.util.List<String> getCourseWays() {
            return this.courseWays;
        }

    }

}
