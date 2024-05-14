// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendMsgByTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("messageContent")
    public SendMsgByTaskRequestMessageContent messageContent;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("queryGroup")
    public SendMsgByTaskRequestQueryGroup queryGroup;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sendConfig")
    public SendMsgByTaskRequestSendConfig sendConfig;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskName")
    public String taskName;

    public static SendMsgByTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMsgByTaskRequest self = new SendMsgByTaskRequest();
        return TeaModel.build(map, self);
    }

    public SendMsgByTaskRequest setMessageContent(SendMsgByTaskRequestMessageContent messageContent) {
        this.messageContent = messageContent;
        return this;
    }
    public SendMsgByTaskRequestMessageContent getMessageContent() {
        return this.messageContent;
    }

    public SendMsgByTaskRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public SendMsgByTaskRequest setQueryGroup(SendMsgByTaskRequestQueryGroup queryGroup) {
        this.queryGroup = queryGroup;
        return this;
    }
    public SendMsgByTaskRequestQueryGroup getQueryGroup() {
        return this.queryGroup;
    }

    public SendMsgByTaskRequest setSendConfig(SendMsgByTaskRequestSendConfig sendConfig) {
        this.sendConfig = sendConfig;
        return this;
    }
    public SendMsgByTaskRequestSendConfig getSendConfig() {
        return this.sendConfig;
    }

    public SendMsgByTaskRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

    public static class SendMsgByTaskRequestMessageContentBtns extends TeaModel {
        @NameInMap("actionURL")
        public String actionURL;

        @NameInMap("title")
        public String title;

        public static SendMsgByTaskRequestMessageContentBtns build(java.util.Map<String, ?> map) throws Exception {
            SendMsgByTaskRequestMessageContentBtns self = new SendMsgByTaskRequestMessageContentBtns();
            return TeaModel.build(map, self);
        }

        public SendMsgByTaskRequestMessageContentBtns setActionURL(String actionURL) {
            this.actionURL = actionURL;
            return this;
        }
        public String getActionURL() {
            return this.actionURL;
        }

        public SendMsgByTaskRequestMessageContentBtns setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendMsgByTaskRequestMessageContent extends TeaModel {
        @NameInMap("atActiveMemberNum")
        public Long atActiveMemberNum;

        @NameInMap("atActiveUser")
        public Boolean atActiveUser;

        @NameInMap("atAll")
        public Boolean atAll;

        @NameInMap("btns")
        public java.util.List<SendMsgByTaskRequestMessageContentBtns> btns;

        @NameInMap("content")
        public String content;

        @NameInMap("images")
        public java.util.List<String> images;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("messageType")
        public String messageType;

        @NameInMap("remind")
        public Boolean remind;

        @NameInMap("title")
        public String title;

        @NameInMap("top")
        public Boolean top;

        public static SendMsgByTaskRequestMessageContent build(java.util.Map<String, ?> map) throws Exception {
            SendMsgByTaskRequestMessageContent self = new SendMsgByTaskRequestMessageContent();
            return TeaModel.build(map, self);
        }

        public SendMsgByTaskRequestMessageContent setAtActiveMemberNum(Long atActiveMemberNum) {
            this.atActiveMemberNum = atActiveMemberNum;
            return this;
        }
        public Long getAtActiveMemberNum() {
            return this.atActiveMemberNum;
        }

        public SendMsgByTaskRequestMessageContent setAtActiveUser(Boolean atActiveUser) {
            this.atActiveUser = atActiveUser;
            return this;
        }
        public Boolean getAtActiveUser() {
            return this.atActiveUser;
        }

        public SendMsgByTaskRequestMessageContent setAtAll(Boolean atAll) {
            this.atAll = atAll;
            return this;
        }
        public Boolean getAtAll() {
            return this.atAll;
        }

        public SendMsgByTaskRequestMessageContent setBtns(java.util.List<SendMsgByTaskRequestMessageContentBtns> btns) {
            this.btns = btns;
            return this;
        }
        public java.util.List<SendMsgByTaskRequestMessageContentBtns> getBtns() {
            return this.btns;
        }

        public SendMsgByTaskRequestMessageContent setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public SendMsgByTaskRequestMessageContent setImages(java.util.List<String> images) {
            this.images = images;
            return this;
        }
        public java.util.List<String> getImages() {
            return this.images;
        }

        public SendMsgByTaskRequestMessageContent setMessageType(String messageType) {
            this.messageType = messageType;
            return this;
        }
        public String getMessageType() {
            return this.messageType;
        }

        public SendMsgByTaskRequestMessageContent setRemind(Boolean remind) {
            this.remind = remind;
            return this;
        }
        public Boolean getRemind() {
            return this.remind;
        }

        public SendMsgByTaskRequestMessageContent setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SendMsgByTaskRequestMessageContent setTop(Boolean top) {
            this.top = top;
            return this;
        }
        public Boolean getTop() {
            return this.top;
        }

    }

    public static class SendMsgByTaskRequestQueryGroup extends TeaModel {
        @NameInMap("groupTagNames")
        public java.util.List<String> groupTagNames;

        @NameInMap("lastActiveDateFilterType")
        public String lastActiveDateFilterType;

        @NameInMap("lastActiveTimeEnd")
        public String lastActiveTimeEnd;

        @NameInMap("lastActiveTimeStart")
        public String lastActiveTimeStart;

        @NameInMap("openConversationIds")
        public java.util.List<String> openConversationIds;

        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("queryType")
        public String queryType;

        public static SendMsgByTaskRequestQueryGroup build(java.util.Map<String, ?> map) throws Exception {
            SendMsgByTaskRequestQueryGroup self = new SendMsgByTaskRequestQueryGroup();
            return TeaModel.build(map, self);
        }

        public SendMsgByTaskRequestQueryGroup setGroupTagNames(java.util.List<String> groupTagNames) {
            this.groupTagNames = groupTagNames;
            return this;
        }
        public java.util.List<String> getGroupTagNames() {
            return this.groupTagNames;
        }

        public SendMsgByTaskRequestQueryGroup setLastActiveDateFilterType(String lastActiveDateFilterType) {
            this.lastActiveDateFilterType = lastActiveDateFilterType;
            return this;
        }
        public String getLastActiveDateFilterType() {
            return this.lastActiveDateFilterType;
        }

        public SendMsgByTaskRequestQueryGroup setLastActiveTimeEnd(String lastActiveTimeEnd) {
            this.lastActiveTimeEnd = lastActiveTimeEnd;
            return this;
        }
        public String getLastActiveTimeEnd() {
            return this.lastActiveTimeEnd;
        }

        public SendMsgByTaskRequestQueryGroup setLastActiveTimeStart(String lastActiveTimeStart) {
            this.lastActiveTimeStart = lastActiveTimeStart;
            return this;
        }
        public String getLastActiveTimeStart() {
            return this.lastActiveTimeStart;
        }

        public SendMsgByTaskRequestQueryGroup setOpenConversationIds(java.util.List<String> openConversationIds) {
            this.openConversationIds = openConversationIds;
            return this;
        }
        public java.util.List<String> getOpenConversationIds() {
            return this.openConversationIds;
        }

        public SendMsgByTaskRequestQueryGroup setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public SendMsgByTaskRequestQueryGroup setQueryType(String queryType) {
            this.queryType = queryType;
            return this;
        }
        public String getQueryType() {
            return this.queryType;
        }

    }

    public static class SendMsgByTaskRequestSendConfigUrlTrackConfig extends TeaModel {
        @NameInMap("title")
        public String title;

        @NameInMap("trackId")
        public String trackId;

        @NameInMap("trackUrl")
        public String trackUrl;

        public static SendMsgByTaskRequestSendConfigUrlTrackConfig build(java.util.Map<String, ?> map) throws Exception {
            SendMsgByTaskRequestSendConfigUrlTrackConfig self = new SendMsgByTaskRequestSendConfigUrlTrackConfig();
            return TeaModel.build(map, self);
        }

        public SendMsgByTaskRequestSendConfigUrlTrackConfig setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SendMsgByTaskRequestSendConfigUrlTrackConfig setTrackId(String trackId) {
            this.trackId = trackId;
            return this;
        }
        public String getTrackId() {
            return this.trackId;
        }

        public SendMsgByTaskRequestSendConfigUrlTrackConfig setTrackUrl(String trackUrl) {
            this.trackUrl = trackUrl;
            return this;
        }
        public String getTrackUrl() {
            return this.trackUrl;
        }

    }

    public static class SendMsgByTaskRequestSendConfig extends TeaModel {
        @NameInMap("needUrlTrack")
        public Boolean needUrlTrack;

        @NameInMap("sendTime")
        public String sendTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sendType")
        public String sendType;

        @NameInMap("urlTrackConfig")
        public java.util.List<SendMsgByTaskRequestSendConfigUrlTrackConfig> urlTrackConfig;

        public static SendMsgByTaskRequestSendConfig build(java.util.Map<String, ?> map) throws Exception {
            SendMsgByTaskRequestSendConfig self = new SendMsgByTaskRequestSendConfig();
            return TeaModel.build(map, self);
        }

        public SendMsgByTaskRequestSendConfig setNeedUrlTrack(Boolean needUrlTrack) {
            this.needUrlTrack = needUrlTrack;
            return this;
        }
        public Boolean getNeedUrlTrack() {
            return this.needUrlTrack;
        }

        public SendMsgByTaskRequestSendConfig setSendTime(String sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public String getSendTime() {
            return this.sendTime;
        }

        public SendMsgByTaskRequestSendConfig setSendType(String sendType) {
            this.sendType = sendType;
            return this;
        }
        public String getSendType() {
            return this.sendType;
        }

        public SendMsgByTaskRequestSendConfig setUrlTrackConfig(java.util.List<SendMsgByTaskRequestSendConfigUrlTrackConfig> urlTrackConfig) {
            this.urlTrackConfig = urlTrackConfig;
            return this;
        }
        public java.util.List<SendMsgByTaskRequestSendConfigUrlTrackConfig> getUrlTrackConfig() {
            return this.urlTrackConfig;
        }

    }

}
