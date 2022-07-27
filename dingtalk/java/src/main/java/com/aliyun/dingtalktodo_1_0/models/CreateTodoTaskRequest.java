// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTaskRequest extends TeaModel {
    @NameInMap("actionList")
    public java.util.List<CreateTodoTaskRequestActionList> actionList;

    // 二级分类
    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    // 待办卡片内容区表单自定义字段列表
    @NameInMap("contentFieldList")
    public java.util.List<CreateTodoTaskRequestContentFieldList> contentFieldList;

    // 创建者id，需传用户的unionId
    @NameInMap("creatorId")
    public String creatorId;

    // 待办备注描述
    @NameInMap("description")
    public String description;

    // 详情页url跳转地址
    @NameInMap("detailUrl")
    public CreateTodoTaskRequestDetailUrl detailUrl;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 执行者列表，需传用户的unionId
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 生成的待办是否仅展示在执行者的待办列表中
    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    // 通知提醒配置
    @NameInMap("notifyConfigs")
    public CreateTodoTaskRequestNotifyConfigs notifyConfigs;

    // 参与者列表，需传用户的unionId
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 优先级
    @NameInMap("priority")
    public Integer priority;

    // 来源id，接入业务系统侧的唯一标识id
    @NameInMap("sourceId")
    public String sourceId;

    // 待办标题
    @NameInMap("subject")
    public String subject;

    // 当前操作者id，需传用户的unionId
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
        // 字段唯一标识
        @NameInMap("fieldKey")
        public String fieldKey;

        // 字段值
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

    public static class CreateTodoTaskRequestNotifyConfigs extends TeaModel {
        // ding通知配置：1钉弹框通知
        @NameInMap("dingNotify")
        public String dingNotify;

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

    }

}
