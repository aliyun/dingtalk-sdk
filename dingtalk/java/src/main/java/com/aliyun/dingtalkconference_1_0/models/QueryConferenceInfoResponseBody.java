// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoResponseBody extends TeaModel {
    /**
     * <p>会议信息结构体</p>
     */
    @NameInMap("confInfo")
    public QueryConferenceInfoResponseBodyConfInfo confInfo;

    public static QueryConferenceInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceInfoResponseBody self = new QueryConferenceInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryConferenceInfoResponseBody setConfInfo(QueryConferenceInfoResponseBodyConfInfo confInfo) {
        this.confInfo = confInfo;
        return this;
    }
    public QueryConferenceInfoResponseBodyConfInfo getConfInfo() {
        return this.confInfo;
    }

    public static class QueryConferenceInfoResponseBodyConfInfo extends TeaModel {
        /**
         * <p>当前在会人数</p>
         */
        @NameInMap("activeNum")
        public Integer activeNum;

        /**
         * <p>累积入会人数</p>
         */
        @NameInMap("attendNum")
        public Integer attendNum;

        /**
         * <p>会议时长</p>
         */
        @NameInMap("confDuration")
        public Long confDuration;

        /**
         * <p>会议id</p>
         */
        @NameInMap("conferenceId")
        public String conferenceId;

        /**
         * <p>会议创建人unionId</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>会议创建人昵称</p>
         */
        @NameInMap("creatorNick")
        public String creatorNick;

        /**
         * <p>会议结束时间</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>会议web入会链接</p>
         */
        @NameInMap("externalLinkUrl")
        public String externalLinkUrl;

        /**
         * <p>邀请人数</p>
         */
        @NameInMap("invitedNum")
        public Integer invitedNum;

        /**
         * <p>会议码</p>
         */
        @NameInMap("roomCode")
        public String roomCode;

        /**
         * <p>会议开始时间</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>会议状态</p>
         * <p>0 初始化</p>
         * <p>1 开始</p>
         * <p>2 结束</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>会议标题</p>
         */
        @NameInMap("title")
        public String title;

        public static QueryConferenceInfoResponseBodyConfInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryConferenceInfoResponseBodyConfInfo self = new QueryConferenceInfoResponseBodyConfInfo();
            return TeaModel.build(map, self);
        }

        public QueryConferenceInfoResponseBodyConfInfo setActiveNum(Integer activeNum) {
            this.activeNum = activeNum;
            return this;
        }
        public Integer getActiveNum() {
            return this.activeNum;
        }

        public QueryConferenceInfoResponseBodyConfInfo setAttendNum(Integer attendNum) {
            this.attendNum = attendNum;
            return this;
        }
        public Integer getAttendNum() {
            return this.attendNum;
        }

        public QueryConferenceInfoResponseBodyConfInfo setConfDuration(Long confDuration) {
            this.confDuration = confDuration;
            return this;
        }
        public Long getConfDuration() {
            return this.confDuration;
        }

        public QueryConferenceInfoResponseBodyConfInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public QueryConferenceInfoResponseBodyConfInfo setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryConferenceInfoResponseBodyConfInfo setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryConferenceInfoResponseBodyConfInfo setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryConferenceInfoResponseBodyConfInfo setExternalLinkUrl(String externalLinkUrl) {
            this.externalLinkUrl = externalLinkUrl;
            return this;
        }
        public String getExternalLinkUrl() {
            return this.externalLinkUrl;
        }

        public QueryConferenceInfoResponseBodyConfInfo setInvitedNum(Integer invitedNum) {
            this.invitedNum = invitedNum;
            return this;
        }
        public Integer getInvitedNum() {
            return this.invitedNum;
        }

        public QueryConferenceInfoResponseBodyConfInfo setRoomCode(String roomCode) {
            this.roomCode = roomCode;
            return this;
        }
        public String getRoomCode() {
            return this.roomCode;
        }

        public QueryConferenceInfoResponseBodyConfInfo setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryConferenceInfoResponseBodyConfInfo setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryConferenceInfoResponseBodyConfInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
