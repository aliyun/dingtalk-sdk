// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryRemoteClassCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryRemoteClassCourseResponseBodyResult> result;

    /**
     * <p>是否成功</p>
     */
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
        /**
         * <p>组织ID</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>组织名称</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <p>参与方ID</p>
         */
        @NameInMap("participantId")
        public String participantId;

        /**
         * <p>参与方名称</p>
         */
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
        /**
         * <p>组织ID</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>组织名称</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <p>参与方ID</p>
         */
        @NameInMap("participantId")
        public String participantId;

        /**
         * <p>参与方名称</p>
         */
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
        /**
         * <p>听课设备列表</p>
         */
        @NameInMap("attendParticipants")
        public java.util.List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants;

        /**
         * <p>课程是否可以编辑或删除</p>
         */
        @NameInMap("canEdit")
        public Boolean canEdit;

        /**
         * <p>课程code</p>
         */
        @NameInMap("courseCode")
        public String courseCode;

        /**
         * <p>课程名称</p>
         */
        @NameInMap("courseName")
        public String courseName;

        /**
         * <p>当前组织在课程中的角色列表：TEACHING：授课方；ATTEND：听课方</p>
         */
        @NameInMap("courseWays")
        public java.util.List<String> courseWays;

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
         * <p>课程状态：0: 未开始；1: 已开始；2: 已结束</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>授课设备</p>
         */
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
