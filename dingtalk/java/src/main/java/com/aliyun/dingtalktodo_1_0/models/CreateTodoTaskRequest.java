// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTaskRequest extends TeaModel {
    // 来源id，接入业务系统侧的唯一标识id
    @NameInMap("sourceId")
    public String sourceId;

    // 待办标题
    @NameInMap("subject")
    public String subject;

    // 创建者id
    @NameInMap("creatorId")
    public String creatorId;

    // 待办备注描述
    @NameInMap("description")
    public String description;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 执行者列表
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 详情页url跳转地址
    @NameInMap("detailUrl")
    public CreateTodoTaskRequestDetailUrl detailUrl;

    // 待办重复规则配置
    @NameInMap("recurrence")
    public String recurrence;

    // 待办提醒规则配置
    @NameInMap("reminder")
    public CreateTodoTaskRequestReminder reminder;

    // 待办通知配置（包含单聊卡片、ding通知、群聊卡片、同步日历、同步系统消息等通知能力）
    @NameInMap("notifyConfigs")
    public CreateTodoTaskRequestNotifyConfigs notifyConfigs;

    // 当前操作者id
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTaskRequest self = new CreateTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateTodoTaskRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public CreateTodoTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public CreateTodoTaskRequest setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public CreateTodoTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public CreateTodoTaskRequest setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public CreateTodoTaskRequest setDetailUrl(CreateTodoTaskRequestDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public CreateTodoTaskRequestDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public CreateTodoTaskRequest setRecurrence(String recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public String getRecurrence() {
        return this.recurrence;
    }

    public CreateTodoTaskRequest setReminder(CreateTodoTaskRequestReminder reminder) {
        this.reminder = reminder;
        return this;
    }
    public CreateTodoTaskRequestReminder getReminder() {
        return this.reminder;
    }

    public CreateTodoTaskRequest setNotifyConfigs(CreateTodoTaskRequestNotifyConfigs notifyConfigs) {
        this.notifyConfigs = notifyConfigs;
        return this;
    }
    public CreateTodoTaskRequestNotifyConfigs getNotifyConfigs() {
        return this.notifyConfigs;
    }

    public CreateTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateTodoTaskRequestDetailUrl extends TeaModel {
        // app端详情页url
        @NameInMap("appUrl")
        public String appUrl;

        // pc端详情页url
        @NameInMap("pcUrl")
        public String pcUrl;

        public static CreateTodoTaskRequestDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestDetailUrl self = new CreateTodoTaskRequestDetailUrl();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public CreateTodoTaskRequestDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class CreateTodoTaskRequestReminderRules extends TeaModel {
        // startTime:相对开始时间  											//  					dueTime:相对截止时间 											//						customTime: 绝对时间
        @NameInMap("baseTime")
        public String baseTime;

        // 必须，baseTime 为 startTime 或者 dueTime 时表分钟；比如截止前15分钟为 -15，截止前3小时为 -180;basetime 为 customTime 时为时间戳
        @NameInMap("offset")
        public Long offset;

        public static CreateTodoTaskRequestReminderRules build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestReminderRules self = new CreateTodoTaskRequestReminderRules();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestReminderRules setBaseTime(String baseTime) {
            this.baseTime = baseTime;
            return this;
        }
        public String getBaseTime() {
            return this.baseTime;
        }

        public CreateTodoTaskRequestReminderRules setOffset(Long offset) {
            this.offset = offset;
            return this;
        }
        public Long getOffset() {
            return this.offset;
        }

    }

    public static class CreateTodoTaskRequestReminder extends TeaModel {
        // 提醒通道，1 弹框，2 短信，3 电话
        @NameInMap("channel")
        public Integer channel;

        // 提醒规则列表
        @NameInMap("rules")
        public java.util.List<CreateTodoTaskRequestReminderRules> rules;

        public static CreateTodoTaskRequestReminder build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestReminder self = new CreateTodoTaskRequestReminder();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestReminder setChannel(Integer channel) {
            this.channel = channel;
            return this;
        }
        public Integer getChannel() {
            return this.channel;
        }

        public CreateTodoTaskRequestReminder setRules(java.util.List<CreateTodoTaskRequestReminderRules> rules) {
            this.rules = rules;
            return this;
        }
        public java.util.List<CreateTodoTaskRequestReminderRules> getRules() {
            return this.rules;
        }

    }

    public static class CreateTodoTaskRequestNotifyConfigs extends TeaModel {
        // 是否发送单聊卡片：value:"true/false" （发送则传true）
        @NameInMap("singleChat")
        public String singleChat;

        // 是否发送群聊卡片：value:"groupId"（发送则传对应群聊id）
        @NameInMap("groupChat")
        public String groupChat;

        // ding通知配置：value:"channel"（1钉弹框通知，2钉短信通知，3钉电话通知）
        @NameInMap("dingNotify")
        public String dingNotify;

        // 是否同步到日历：value:"true/false"（同步则传true）
        @NameInMap("canlender")
        public String canlender;

        public static CreateTodoTaskRequestNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestNotifyConfigs self = new CreateTodoTaskRequestNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestNotifyConfigs setSingleChat(String singleChat) {
            this.singleChat = singleChat;
            return this;
        }
        public String getSingleChat() {
            return this.singleChat;
        }

        public CreateTodoTaskRequestNotifyConfigs setGroupChat(String groupChat) {
            this.groupChat = groupChat;
            return this;
        }
        public String getGroupChat() {
            return this.groupChat;
        }

        public CreateTodoTaskRequestNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

        public CreateTodoTaskRequestNotifyConfigs setCanlender(String canlender) {
            this.canlender = canlender;
            return this;
        }
        public String getCanlender() {
            return this.canlender;
        }

    }

}
