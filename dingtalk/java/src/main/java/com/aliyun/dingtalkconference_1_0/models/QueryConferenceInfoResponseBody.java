// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoResponseBody extends TeaModel {
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
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("activeNum")
        public Integer activeNum;

        /**
         * <strong>example:</strong>
         * <p>15</p>
         */
        @NameInMap("attendNum")
        public Integer attendNum;

        /**
         * <strong>example:</strong>
         * <p>1000000</p>
         */
        @NameInMap("confDuration")
        public Long confDuration;

        /**
         * <strong>example:</strong>
         * <p>6323d7568777190142ab9d10</p>
         */
        @NameInMap("conferenceId")
        public String conferenceId;

        /**
         * <strong>example:</strong>
         * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>昵称</p>
         */
        @NameInMap("creatorNick")
        public String creatorNick;

        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p><a href="https://meeting.dingtalk.com/app?roomCode=42726033559&token=1_7ac974ac-6e4f-47c3-b82b-bfb32fd94d2c">https://meeting.dingtalk.com/app?roomCode=42726033559&amp;token=1_7ac974ac-6e4f-47c3-b82b-bfb32fd94d2c</a></p>
         */
        @NameInMap("externalLinkUrl")
        public String externalLinkUrl;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("invitedNum")
        public Integer invitedNum;

        /**
         * <strong>example:</strong>
         * <p>42726033559</p>
         */
        @NameInMap("roomCode")
        public String roomCode;

        /**
         * <strong>example:</strong>
         * <p>1663293270000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <strong>example:</strong>
         * <p>标题</p>
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
