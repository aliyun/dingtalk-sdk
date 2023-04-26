// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryRemoteClassCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryRemoteClassCourseResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryRemoteClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRemoteClassCourseResponseBody self = new QueryRemoteClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRemoteClassCourseResponseBody setResult(java.util.List<QueryRemoteClassCourseResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryRemoteClassCourseResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryRemoteClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryRemoteClassCourseResponseBodyResultAttendParticipants extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("participantId")
        public String participantId;

        @NameInMap("participantName")
        public String participantName;

        public static QueryRemoteClassCourseResponseBodyResultAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            QueryRemoteClassCourseResponseBodyResultAttendParticipants self = new QueryRemoteClassCourseResponseBodyResultAttendParticipants();
            return TeaModel.build(map, self);
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

        public QueryRemoteClassCourseResponseBodyResultAttendParticipants setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public QueryRemoteClassCourseResponseBodyResultAttendParticipants setParticipantName(String participantName) {
            this.participantName = participantName;
            return this;
        }
        public String getParticipantName() {
            return this.participantName;
        }

    }

    public static class QueryRemoteClassCourseResponseBodyResultTeachingParticipant extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("participantId")
        public String participantId;

        @NameInMap("participantName")
        public String participantName;

        public static QueryRemoteClassCourseResponseBodyResultTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            QueryRemoteClassCourseResponseBodyResultTeachingParticipant self = new QueryRemoteClassCourseResponseBodyResultTeachingParticipant();
            return TeaModel.build(map, self);
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

        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant setParticipantId(String participantId) {
            this.participantId = participantId;
            return this;
        }
        public String getParticipantId() {
            return this.participantId;
        }

        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant setParticipantName(String participantName) {
            this.participantName = participantName;
            return this;
        }
        public String getParticipantName() {
            return this.participantName;
        }

    }

    public static class QueryRemoteClassCourseResponseBodyResult extends TeaModel {
        @NameInMap("attendParticipants")
        public java.util.List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants;

        @NameInMap("canEdit")
        public Boolean canEdit;

        @NameInMap("courseCode")
        public String courseCode;

        @NameInMap("courseName")
        public String courseName;

        @NameInMap("courseWays")
        public java.util.List<String> courseWays;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("teachingParticipant")
        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant;

        public static QueryRemoteClassCourseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryRemoteClassCourseResponseBodyResult self = new QueryRemoteClassCourseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryRemoteClassCourseResponseBodyResult setAttendParticipants(java.util.List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants) {
            this.attendParticipants = attendParticipants;
            return this;
        }
        public java.util.List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> getAttendParticipants() {
            return this.attendParticipants;
        }

        public QueryRemoteClassCourseResponseBodyResult setCanEdit(Boolean canEdit) {
            this.canEdit = canEdit;
            return this;
        }
        public Boolean getCanEdit() {
            return this.canEdit;
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

        public QueryRemoteClassCourseResponseBodyResult setCourseWays(java.util.List<String> courseWays) {
            this.courseWays = courseWays;
            return this;
        }
        public java.util.List<String> getCourseWays() {
            return this.courseWays;
        }

        public QueryRemoteClassCourseResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryRemoteClassCourseResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryRemoteClassCourseResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryRemoteClassCourseResponseBodyResult setTeachingParticipant(QueryRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant) {
            this.teachingParticipant = teachingParticipant;
            return this;
        }
        public QueryRemoteClassCourseResponseBodyResultTeachingParticipant getTeachingParticipant() {
            return this.teachingParticipant;
        }

    }

}
