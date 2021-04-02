// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTaskResponseBody extends TeaModel {
    // id
    @NameInMap("id")
    public String id;

    // 标题
    @NameInMap("subject")
    public String subject;

    // 描述
    @NameInMap("description")
    public String description;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 完成时间
    @NameInMap("finishTime")
    public Long finishTime;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 执行者列表
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 提醒规则
    @NameInMap("reminder")
    public CreateTodoTaskResponseBodyReminder reminder;

    // 待办通知配置（包含单聊卡片、ding通知、群聊卡片、同步日历、同步系统消息等通知能力）
    @NameInMap("notifyConfigs")
    public CreateTodoTaskResponseBodyNotifyConfigs notifyConfigs;

    // 自定义详情页跳转配置
    @NameInMap("detailUrl")
    public CreateTodoTaskResponseBodyDetailUrl detailUrl;

    // 重复规则
    @NameInMap("recurrence")
    public String recurrence;

    // 业务来源
    @NameInMap("source")
    public String source;

    // 业务来源id
    @NameInMap("sourceId")
    public String sourceId;

    // 创建时间
    @NameInMap("createdTime")
    public Long createdTime;

    // 更新时间
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    // 创建者
    @NameInMap("creatorId")
    public String creatorId;

    // 更新者
    @NameInMap("modifierId")
    public String modifierId;

    // 租户id
    @NameInMap("tenantId")
    public String tenantId;

    // 接入应用标识
    @NameInMap("bizTag")
    public String bizTag;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    public static CreateTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTaskResponseBody self = new CreateTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTodoTaskResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateTodoTaskResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public CreateTodoTaskResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTodoTaskResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateTodoTaskResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public CreateTodoTaskResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public CreateTodoTaskResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public CreateTodoTaskResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public CreateTodoTaskResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public CreateTodoTaskResponseBody setReminder(CreateTodoTaskResponseBodyReminder reminder) {
        this.reminder = reminder;
        return this;
    }
    public CreateTodoTaskResponseBodyReminder getReminder() {
        return this.reminder;
    }

    public CreateTodoTaskResponseBody setNotifyConfigs(CreateTodoTaskResponseBodyNotifyConfigs notifyConfigs) {
        this.notifyConfigs = notifyConfigs;
        return this;
    }
    public CreateTodoTaskResponseBodyNotifyConfigs getNotifyConfigs() {
        return this.notifyConfigs;
    }

    public CreateTodoTaskResponseBody setDetailUrl(CreateTodoTaskResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public CreateTodoTaskResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public CreateTodoTaskResponseBody setRecurrence(String recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public String getRecurrence() {
        return this.recurrence;
    }

    public CreateTodoTaskResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public CreateTodoTaskResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public CreateTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public CreateTodoTaskResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public CreateTodoTaskResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateTodoTaskResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public CreateTodoTaskResponseBody setTenantId(String tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public String getTenantId() {
        return this.tenantId;
    }

    public CreateTodoTaskResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public CreateTodoTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class CreateTodoTaskResponseBodyReminderRules extends TeaModel {
        // 目前支持三种类型：tartDate: 相对开始时间；dueDate: 相对截止时间；customDate: 绝对时间
        @NameInMap("baseTime")
        public String baseTime;

        // 偏移值：baseTime 为 startDate 或者 dueDate 时，offset 为相对分钟的偏移值；baseTime 为 customDate 时，offset 为毫秒时间戳
        @NameInMap("offset")
        public Long offset;

        public static CreateTodoTaskResponseBodyReminderRules build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyReminderRules self = new CreateTodoTaskResponseBodyReminderRules();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyReminderRules setBaseTime(String baseTime) {
            this.baseTime = baseTime;
            return this;
        }
        public String getBaseTime() {
            return this.baseTime;
        }

        public CreateTodoTaskResponseBodyReminderRules setOffset(Long offset) {
            this.offset = offset;
            return this;
        }
        public Long getOffset() {
            return this.offset;
        }

    }

    public static class CreateTodoTaskResponseBodyReminder extends TeaModel {
        // 提醒通道
        @NameInMap("channel")
        public Integer channel;

        // 提醒规则配置
        @NameInMap("rules")
        public CreateTodoTaskResponseBodyReminderRules rules;

        public static CreateTodoTaskResponseBodyReminder build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyReminder self = new CreateTodoTaskResponseBodyReminder();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyReminder setChannel(Integer channel) {
            this.channel = channel;
            return this;
        }
        public Integer getChannel() {
            return this.channel;
        }

        public CreateTodoTaskResponseBodyReminder setRules(CreateTodoTaskResponseBodyReminderRules rules) {
            this.rules = rules;
            return this;
        }
        public CreateTodoTaskResponseBodyReminderRules getRules() {
            return this.rules;
        }

    }

    public static class CreateTodoTaskResponseBodyNotifyConfigs extends TeaModel {
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

        public static CreateTodoTaskResponseBodyNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyNotifyConfigs self = new CreateTodoTaskResponseBodyNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyNotifyConfigs setSingleChat(String singleChat) {
            this.singleChat = singleChat;
            return this;
        }
        public String getSingleChat() {
            return this.singleChat;
        }

        public CreateTodoTaskResponseBodyNotifyConfigs setGroupChat(String groupChat) {
            this.groupChat = groupChat;
            return this;
        }
        public String getGroupChat() {
            return this.groupChat;
        }

        public CreateTodoTaskResponseBodyNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

        public CreateTodoTaskResponseBodyNotifyConfigs setCanlender(String canlender) {
            this.canlender = canlender;
            return this;
        }
        public String getCanlender() {
            return this.canlender;
        }

    }

    public static class CreateTodoTaskResponseBodyDetailUrl extends TeaModel {
        // pc端详情页地址
        @NameInMap("pcUrl")
        public String pcUrl;

        // app端详情页地址
        @NameInMap("appUrl")
        public String appUrl;

        public static CreateTodoTaskResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyDetailUrl self = new CreateTodoTaskResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public CreateTodoTaskResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

    }

}
