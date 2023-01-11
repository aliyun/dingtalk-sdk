// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendMsgByTaskRequest extends TeaModel {
    /**
     * <p>群发内容</p>
     */
    @NameInMap("messageContent")
    public SendMsgByTaskRequestMessageContent messageContent;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("queryGroup")
    public SendMsgByTaskRequestQueryGroup queryGroup;

    /**
     * <p>发送配置</p>
     */
    @NameInMap("sendConfig")
    public SendMsgByTaskRequestSendConfig sendConfig;

    /**
     * <p>群发任务名称</p>
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
        /**
         * <p>at活跃成员数量</p>
         */
        @NameInMap("atActiveMemberNum")
        public Long atActiveMemberNum;

        /**
         * <p>是否At活跃成员</p>
         */
        @NameInMap("atActiveUser")
        public Boolean atActiveUser;

        /**
         * <p>是否At全部人员</p>
         */
        @NameInMap("atAll")
        public Boolean atAll;

        @NameInMap("btns")
        public java.util.List<SendMsgByTaskRequestMessageContentBtns> btns;

        /**
         * <p>内容</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>图片列表</p>
         */
        @NameInMap("images")
        public java.util.List<String> images;

        /**
         * <p>消息类型</p>
         */
        @NameInMap("messageType")
        public String messageType;

        /**
         * <p>是否提醒群成员</p>
         */
        @NameInMap("remind")
        public Boolean remind;

        /**
         * <p>标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>是否置顶</p>
         */
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
        /**
         * <p>群标签</p>
         */
        @NameInMap("groupTagNames")
        public java.util.List<String> groupTagNames;

        /**
         * <p>活跃日期筛选类型，ACTIVE=活跃      NOTACTIVE=不活跃</p>
         */
        @NameInMap("lastActiveDateFilterType")
        public String lastActiveDateFilterType;

        /**
         * <p>最近活跃时间的结束时间</p>
         */
        @NameInMap("lastActiveTimeEnd")
        public String lastActiveTimeEnd;

        /**
         * <p>最近活跃时间的开始时间</p>
         */
        @NameInMap("lastActiveTimeStart")
        public String lastActiveTimeStart;

        /**
         * <p>精准圈选-群ID集合</p>
         */
        @NameInMap("openConversationIds")
        public java.util.List<String> openConversationIds;

        /**
         * <p>开放群组ID</p>
         */
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        /**
         * <p>群发圈选类型 1. AIMED 精准圈选 2. MULTI_CONDITIONS 多条件圈选</p>
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
        /**
         * <p>跟踪链接的标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>跟踪链接的坑位ID（sg开头）</p>
         */
        @NameInMap("trackId")
        public String trackId;

        /**
         * <p>跟踪链接URL</p>
         */
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
        /**
         * <p>是否链接追踪</p>
         */
        @NameInMap("needUrlTrack")
        public Boolean needUrlTrack;

        /**
         * <p>执行时间（sendType=TIMING时传入）</p>
         */
        @NameInMap("sendTime")
        public String sendTime;

        /**
         * <p>发送类型      * TIMING=定时执行      * INSTANT=立即执行</p>
         */
        @NameInMap("sendType")
        public String sendType;

        /**
         * <p>链接跟踪配置</p>
         */
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
