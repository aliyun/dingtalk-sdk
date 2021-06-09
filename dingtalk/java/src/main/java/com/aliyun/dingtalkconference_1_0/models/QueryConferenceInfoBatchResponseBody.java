// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoBatchResponseBody extends TeaModel {
    // 会议详情列表
    @NameInMap("infos")
    public java.util.List<QueryConferenceInfoBatchResponseBodyInfos> infos;

    public static QueryConferenceInfoBatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceInfoBatchResponseBody self = new QueryConferenceInfoBatchResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryConferenceInfoBatchResponseBody setInfos(java.util.List<QueryConferenceInfoBatchResponseBodyInfos> infos) {
        this.infos = infos;
        return this;
    }
    public java.util.List<QueryConferenceInfoBatchResponseBodyInfos> getInfos() {
        return this.infos;
    }

    public static class QueryConferenceInfoBatchResponseBodyInfosUserList extends TeaModel {
        // 用户id
        @NameInMap("userId")
        public String userId;

        // 名称
        @NameInMap("nick")
        public String nick;

        // 在会状态
        @NameInMap("attendStatus")
        public Long attendStatus;

        // 摄像头状态
        @NameInMap("cameraStatus")
        public Long cameraStatus;

        // 麦克风状态
        @NameInMap("micStatus")
        public Long micStatus;

        // 拒绝原因
        @NameInMap("rejectDescription")
        public String rejectDescription;

        public static QueryConferenceInfoBatchResponseBodyInfosUserList build(java.util.Map<String, ?> map) throws Exception {
            QueryConferenceInfoBatchResponseBodyInfosUserList self = new QueryConferenceInfoBatchResponseBodyInfosUserList();
            return TeaModel.build(map, self);
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setAttendStatus(Long attendStatus) {
            this.attendStatus = attendStatus;
            return this;
        }
        public Long getAttendStatus() {
            return this.attendStatus;
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setCameraStatus(Long cameraStatus) {
            this.cameraStatus = cameraStatus;
            return this;
        }
        public Long getCameraStatus() {
            return this.cameraStatus;
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setMicStatus(Long micStatus) {
            this.micStatus = micStatus;
            return this;
        }
        public Long getMicStatus() {
            return this.micStatus;
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setRejectDescription(String rejectDescription) {
            this.rejectDescription = rejectDescription;
            return this;
        }
        public String getRejectDescription() {
            return this.rejectDescription;
        }

    }

    public static class QueryConferenceInfoBatchResponseBodyInfos extends TeaModel {
        // 会议iD
        @NameInMap("conferenceId")
        public String conferenceId;

        // 会议名称
        @NameInMap("title")
        public String title;

        // 会议开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 会议状态
        @NameInMap("status")
        public Long status;

        // 媒体状态
        @NameInMap("mediaStatus")
        public Long mediaStatus;

        // 参会用户列表
        @NameInMap("userList")
        public java.util.List<QueryConferenceInfoBatchResponseBodyInfosUserList> userList;

        public static QueryConferenceInfoBatchResponseBodyInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryConferenceInfoBatchResponseBodyInfos self = new QueryConferenceInfoBatchResponseBodyInfos();
            return TeaModel.build(map, self);
        }

        public QueryConferenceInfoBatchResponseBodyInfos setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public QueryConferenceInfoBatchResponseBodyInfos setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryConferenceInfoBatchResponseBodyInfos setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryConferenceInfoBatchResponseBodyInfos setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public QueryConferenceInfoBatchResponseBodyInfos setMediaStatus(Long mediaStatus) {
            this.mediaStatus = mediaStatus;
            return this;
        }
        public Long getMediaStatus() {
            return this.mediaStatus;
        }

        public QueryConferenceInfoBatchResponseBodyInfos setUserList(java.util.List<QueryConferenceInfoBatchResponseBodyInfosUserList> userList) {
            this.userList = userList;
            return this;
        }
        public java.util.List<QueryConferenceInfoBatchResponseBodyInfosUserList> getUserList() {
            return this.userList;
        }

    }

}
