// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoBatchResponseBody extends TeaModel {
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
        @NameInMap("attendStatus")
        public Long attendStatus;

        @NameInMap("cameraStatus")
        public Long cameraStatus;

        @NameInMap("micStatus")
        public Long micStatus;

        @NameInMap("nick")
        public String nick;

        @NameInMap("rejectDescription")
        public String rejectDescription;

        @NameInMap("userId")
        public String userId;

        public static QueryConferenceInfoBatchResponseBodyInfosUserList build(java.util.Map<String, ?> map) throws Exception {
            QueryConferenceInfoBatchResponseBodyInfosUserList self = new QueryConferenceInfoBatchResponseBodyInfosUserList();
            return TeaModel.build(map, self);
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

        public QueryConferenceInfoBatchResponseBodyInfosUserList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setRejectDescription(String rejectDescription) {
            this.rejectDescription = rejectDescription;
            return this;
        }
        public String getRejectDescription() {
            return this.rejectDescription;
        }

        public QueryConferenceInfoBatchResponseBodyInfosUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryConferenceInfoBatchResponseBodyInfos extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("mediaStatus")
        public Long mediaStatus;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Long status;

        @NameInMap("title")
        public String title;

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

        public QueryConferenceInfoBatchResponseBodyInfos setMediaStatus(Long mediaStatus) {
            this.mediaStatus = mediaStatus;
            return this;
        }
        public Long getMediaStatus() {
            return this.mediaStatus;
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

        public QueryConferenceInfoBatchResponseBodyInfos setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
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
