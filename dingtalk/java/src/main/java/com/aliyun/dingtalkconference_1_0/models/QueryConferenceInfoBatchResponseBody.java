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
        /**
         * <strong>example:</strong>
         * <p>0-未定义,1-初始化,2-加入中,3-在会,4-加入失败,5,被踢出,6-离开</p>
         */
        @NameInMap("attendStatus")
        public Long attendStatus;

        /**
         * <strong>example:</strong>
         * <p>0-初始化，1-关闭，2-打开</p>
         */
        @NameInMap("cameraStatus")
        public Long cameraStatus;

        /**
         * <strong>example:</strong>
         * <p>0-初始化，1-关闭，2-打开</p>
         */
        @NameInMap("micStatus")
        public Long micStatus;

        @NameInMap("nick")
        public String nick;

        /**
         * <strong>example:</strong>
         * <p>抱歉，正在开会</p>
         */
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

        /**
         * <strong>example:</strong>
         * <p>0-正常，1-麦克风静音，2-摄像头关闭，4-强制全员静音</p>
         */
        @NameInMap("mediaStatus")
        public Long mediaStatus;

        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>0-初始化，1-会议结束，2-会议开始</p>
         */
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
