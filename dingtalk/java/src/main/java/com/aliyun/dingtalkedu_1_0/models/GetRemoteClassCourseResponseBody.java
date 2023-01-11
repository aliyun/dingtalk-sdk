// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetRemoteClassCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public GetRemoteClassCourseResponseBodyResult result;

    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetRemoteClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRemoteClassCourseResponseBody self = new GetRemoteClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRemoteClassCourseResponseBody setResult(GetRemoteClassCourseResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetRemoteClassCourseResponseBodyResult getResult() {
        return this.result;
    }

    public GetRemoteClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetRemoteClassCourseResponseBodyResultAttendParticipants extends TeaModel {
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

        public static GetRemoteClassCourseResponseBodyResultAttendParticipants build(java.util.Map<String, ?> map) throws Exception {
            GetRemoteClassCourseResponseBodyResultAttendParticipants self = new GetRemoteClassCourseResponseBodyResultAttendParticipants();
            return TeaModel.build(map, self);
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

    }

    public static class GetRemoteClassCourseResponseBodyResultRecordInfos extends TeaModel {
        /**
         * <p>录制开始时间（UTC/GMT格式）</p>
         */
        @NameInMap("startTime")
        public String startTime;

        /**
         * <p>录制结束时间（UTC/GMT格式）</p>
         */
        @NameInMap("stopTime")
        public String stopTime;

        /**
         * <p>录制文件地址（文件有效期7天）</p>
         */
        @NameInMap("url")
        public String url;

        public static GetRemoteClassCourseResponseBodyResultRecordInfos build(java.util.Map<String, ?> map) throws Exception {
            GetRemoteClassCourseResponseBodyResultRecordInfos self = new GetRemoteClassCourseResponseBodyResultRecordInfos();
            return TeaModel.build(map, self);
        }

        public GetRemoteClassCourseResponseBodyResultRecordInfos setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

        public GetRemoteClassCourseResponseBodyResultRecordInfos setStopTime(String stopTime) {
            this.stopTime = stopTime;
            return this;
        }
        public String getStopTime() {
            return this.stopTime;
        }

        public GetRemoteClassCourseResponseBodyResultRecordInfos setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetRemoteClassCourseResponseBodyResultTeachingParticipant extends TeaModel {
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

        public static GetRemoteClassCourseResponseBodyResultTeachingParticipant build(java.util.Map<String, ?> map) throws Exception {
            GetRemoteClassCourseResponseBodyResultTeachingParticipant self = new GetRemoteClassCourseResponseBodyResultTeachingParticipant();
            return TeaModel.build(map, self);
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

    }

    public static class GetRemoteClassCourseResponseBodyResult extends TeaModel {
        /**
         * <p>听课设备列表</p>
         */
        @NameInMap("attendParticipants")
        public java.util.List<GetRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants;

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
         * <p>结束时间</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>直播观看URL（如果有）</p>
         */
        @NameInMap("liveUrl")
        public String liveUrl;

        /**
         * <p>录制信息列表（如果有）。根据录制端的不同，有不同时长的延迟</p>
         */
        @NameInMap("recordInfos")
        public java.util.List<GetRemoteClassCourseResponseBodyResultRecordInfos> recordInfos;

        /**
         * <p>课堂当前状态：0: 未进行；1: 进行中</p>
         */
        @NameInMap("roomStatus")
        public Integer roomStatus;

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
        public GetRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant;

        public static GetRemoteClassCourseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRemoteClassCourseResponseBodyResult self = new GetRemoteClassCourseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRemoteClassCourseResponseBodyResult setAttendParticipants(java.util.List<GetRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants) {
            this.attendParticipants = attendParticipants;
            return this;
        }
        public java.util.List<GetRemoteClassCourseResponseBodyResultAttendParticipants> getAttendParticipants() {
            return this.attendParticipants;
        }

        public GetRemoteClassCourseResponseBodyResult setCanEdit(Boolean canEdit) {
            this.canEdit = canEdit;
            return this;
        }
        public Boolean getCanEdit() {
            return this.canEdit;
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

        public GetRemoteClassCourseResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetRemoteClassCourseResponseBodyResult setLiveUrl(String liveUrl) {
            this.liveUrl = liveUrl;
            return this;
        }
        public String getLiveUrl() {
            return this.liveUrl;
        }

        public GetRemoteClassCourseResponseBodyResult setRecordInfos(java.util.List<GetRemoteClassCourseResponseBodyResultRecordInfos> recordInfos) {
            this.recordInfos = recordInfos;
            return this;
        }
        public java.util.List<GetRemoteClassCourseResponseBodyResultRecordInfos> getRecordInfos() {
            return this.recordInfos;
        }

        public GetRemoteClassCourseResponseBodyResult setRoomStatus(Integer roomStatus) {
            this.roomStatus = roomStatus;
            return this;
        }
        public Integer getRoomStatus() {
            return this.roomStatus;
        }

        public GetRemoteClassCourseResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetRemoteClassCourseResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public GetRemoteClassCourseResponseBodyResult setTeachingParticipant(GetRemoteClassCourseResponseBodyResultTeachingParticipant teachingParticipant) {
            this.teachingParticipant = teachingParticipant;
            return this;
        }
        public GetRemoteClassCourseResponseBodyResultTeachingParticipant getTeachingParticipant() {
            return this.teachingParticipant;
        }

    }

}
