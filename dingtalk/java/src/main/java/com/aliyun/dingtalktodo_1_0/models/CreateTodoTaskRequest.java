// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTaskRequest extends TeaModel {
    @NameInMap("actionList")
    public java.util.List<CreateTodoTaskRequestActionList> actionList;

    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    @NameInMap("contentFieldList")
    public java.util.List<CreateTodoTaskRequestContentFieldList> contentFieldList;

    @NameInMap("creatorId")
    public String creatorId;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public CreateTodoTaskRequestDetailUrl detailUrl;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    @NameInMap("notifyConfigs")
    public CreateTodoTaskRequestNotifyConfigs notifyConfigs;

    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    @NameInMap("priority")
    public Integer priority;

    @NameInMap("remindNotifyConfigs")
    public CreateTodoTaskRequestRemindNotifyConfigs remindNotifyConfigs;

    @NameInMap("reminderTimeStamp")
    public Long reminderTimeStamp;

    @NameInMap("sourceId")
    public String sourceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <strong>example:</strong>
     * <p>TODO</p>
     */
    @NameInMap("todoType")
    public String todoType;

    @NameInMap("operatorId")
    public String operatorId;

    public static CreateTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTaskRequest self = new CreateTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateTodoTaskRequest setActionList(java.util.List<CreateTodoTaskRequestActionList> actionList) {
        this.actionList = actionList;
        return this;
    }
    public java.util.List<CreateTodoTaskRequestActionList> getActionList() {
        return this.actionList;
    }

    public CreateTodoTaskRequest setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

    public CreateTodoTaskRequest setContentFieldList(java.util.List<CreateTodoTaskRequestContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<CreateTodoTaskRequestContentFieldList> getContentFieldList() {
        return this.contentFieldList;
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

    public CreateTodoTaskRequest setDetailUrl(CreateTodoTaskRequestDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public CreateTodoTaskRequestDetailUrl getDetailUrl() {
        return this.detailUrl;
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

    public CreateTodoTaskRequest setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public CreateTodoTaskRequest setNotifyConfigs(CreateTodoTaskRequestNotifyConfigs notifyConfigs) {
        this.notifyConfigs = notifyConfigs;
        return this;
    }
    public CreateTodoTaskRequestNotifyConfigs getNotifyConfigs() {
        return this.notifyConfigs;
    }

    public CreateTodoTaskRequest setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public CreateTodoTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public CreateTodoTaskRequest setRemindNotifyConfigs(CreateTodoTaskRequestRemindNotifyConfigs remindNotifyConfigs) {
        this.remindNotifyConfigs = remindNotifyConfigs;
        return this;
    }
    public CreateTodoTaskRequestRemindNotifyConfigs getRemindNotifyConfigs() {
        return this.remindNotifyConfigs;
    }

    public CreateTodoTaskRequest setReminderTimeStamp(Long reminderTimeStamp) {
        this.reminderTimeStamp = reminderTimeStamp;
        return this;
    }
    public Long getReminderTimeStamp() {
        return this.reminderTimeStamp;
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

    public CreateTodoTaskRequest setTodoType(String todoType) {
        this.todoType = todoType;
        return this;
    }
    public String getTodoType() {
        return this.todoType;
    }

    public CreateTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateTodoTaskRequestActionListParam extends TeaModel {
        @NameInMap("body")
        public String body;

        @NameInMap("header")
        public java.util.Map<String, ?> header;

        public static CreateTodoTaskRequestActionListParam build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestActionListParam self = new CreateTodoTaskRequestActionListParam();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestActionListParam setBody(String body) {
            this.body = body;
            return this;
        }
        public String getBody() {
            return this.body;
        }

        public CreateTodoTaskRequestActionListParam setHeader(java.util.Map<String, ?> header) {
            this.header = header;
            return this;
        }
        public java.util.Map<String, ?> getHeader() {
            return this.header;
        }

    }

    public static class CreateTodoTaskRequestActionList extends TeaModel {
        @NameInMap("actionKey")
        public String actionKey;

        @NameInMap("actionType")
        public Integer actionType;

        @NameInMap("buttonStyleType")
        public Integer buttonStyleType;

        @NameInMap("param")
        public CreateTodoTaskRequestActionListParam param;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("title")
        public String title;

        @NameInMap("url")
        public String url;

        public static CreateTodoTaskRequestActionList build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestActionList self = new CreateTodoTaskRequestActionList();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestActionList setActionKey(String actionKey) {
            this.actionKey = actionKey;
            return this;
        }
        public String getActionKey() {
            return this.actionKey;
        }

        public CreateTodoTaskRequestActionList setActionType(Integer actionType) {
            this.actionType = actionType;
            return this;
        }
        public Integer getActionType() {
            return this.actionType;
        }

        public CreateTodoTaskRequestActionList setButtonStyleType(Integer buttonStyleType) {
            this.buttonStyleType = buttonStyleType;
            return this;
        }
        public Integer getButtonStyleType() {
            return this.buttonStyleType;
        }

        public CreateTodoTaskRequestActionList setParam(CreateTodoTaskRequestActionListParam param) {
            this.param = param;
            return this;
        }
        public CreateTodoTaskRequestActionListParam getParam() {
            return this.param;
        }

        public CreateTodoTaskRequestActionList setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public CreateTodoTaskRequestActionList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CreateTodoTaskRequestActionList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class CreateTodoTaskRequestContentFieldList extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldValue")
        public String fieldValue;

        public static CreateTodoTaskRequestContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestContentFieldList self = new CreateTodoTaskRequestContentFieldList();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public CreateTodoTaskRequestContentFieldList setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

    }

    public static class CreateTodoTaskRequestDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

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

    public static class CreateTodoTaskRequestNotifyConfigs extends TeaModel {
        @NameInMap("dingNotify")
        public String dingNotify;

        @NameInMap("sendAssistantChat")
        public String sendAssistantChat;

        @NameInMap("sendTodoApn")
        public String sendTodoApn;

        public static CreateTodoTaskRequestNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestNotifyConfigs self = new CreateTodoTaskRequestNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

        public CreateTodoTaskRequestNotifyConfigs setSendAssistantChat(String sendAssistantChat) {
            this.sendAssistantChat = sendAssistantChat;
            return this;
        }
        public String getSendAssistantChat() {
            return this.sendAssistantChat;
        }

        public CreateTodoTaskRequestNotifyConfigs setSendTodoApn(String sendTodoApn) {
            this.sendTodoApn = sendTodoApn;
            return this;
        }
        public String getSendTodoApn() {
            return this.sendTodoApn;
        }

    }

    public static class CreateTodoTaskRequestRemindNotifyConfigs extends TeaModel {
        @NameInMap("dingNotify")
        public String dingNotify;

        @NameInMap("sendTodoApn")
        public String sendTodoApn;

        public static CreateTodoTaskRequestRemindNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskRequestRemindNotifyConfigs self = new CreateTodoTaskRequestRemindNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskRequestRemindNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

        public CreateTodoTaskRequestRemindNotifyConfigs setSendTodoApn(String sendTodoApn) {
            this.sendTodoApn = sendTodoApn;
            return this;
        }
        public String getSendTodoApn() {
            return this.sendTodoApn;
        }

    }

}
