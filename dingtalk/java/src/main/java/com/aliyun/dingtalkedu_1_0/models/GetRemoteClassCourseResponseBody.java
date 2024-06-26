// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetRemoteClassCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public GetRemoteClassCourseResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
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
         * <strong>example:</strong>
         * <p>ding23456</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>组织234</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <strong>example:</strong>
         * <p>865306</p>
         */
        @NameInMap("participantId")
        public String participantId;

        /**
         * <strong>example:</strong>
         * <p>二年级1班</p>
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
         * <strong>example:</strong>
         * <p>2021-11-17T02:08:45Z</p>
         */
        @NameInMap("startTime")
        public String startTime;

        /**
         * <strong>example:</strong>
         * <p>2021-11-17T04:08:45Z</p>
         */
        @NameInMap("stopTime")
        public String stopTime;

        /**
         * <strong>example:</strong>
         * <p><a href="http://oss.xxx.com/xxxx">http://oss.xxx.com/xxxx</a></p>
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
         * <strong>example:</strong>
         * <p>ding1234</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>组织123</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <strong>example:</strong>
         * <p>881436</p>
         */
        @NameInMap("participantId")
        public String participantId;

        /**
         * <strong>example:</strong>
         * <p>一年级1班</p>
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
        @NameInMap("attendParticipants")
        public java.util.List<GetRemoteClassCourseResponseBodyResultAttendParticipants> attendParticipants;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("canEdit")
        public Boolean canEdit;

        /**
         * <strong>example:</strong>
         * <p>UvCIp16813006</p>
         */
        @NameInMap("courseCode")
        public String courseCode;

        /**
         * <strong>example:</strong>
         * <p>春天来了</p>
         */
        @NameInMap("courseName")
        public String courseName;

        /**
         * <strong>example:</strong>
         * <p>1635157800000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p><a href="https://pre-live.edu.dingtalk.com/live/showLive?courseCode=UvCIp16813006#/aiclass">https://pre-live.edu.dingtalk.com/live/showLive?courseCode=UvCIp16813006#/aiclass</a></p>
         */
        @NameInMap("liveUrl")
        public String liveUrl;

        @NameInMap("recordInfos")
        public java.util.List<GetRemoteClassCourseResponseBodyResultRecordInfos> recordInfos;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("roomStatus")
        public Integer roomStatus;

        /**
         * <strong>example:</strong>
         * <p>1635150600000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Integer status;

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
