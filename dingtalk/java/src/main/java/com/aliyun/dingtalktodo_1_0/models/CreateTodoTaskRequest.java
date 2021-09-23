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

    // 创建者id，需传用户的unionId
    @NameInMap("creatorId")
    public String creatorId;

    // 待办备注描述
    @NameInMap("description")
    public String description;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 执行者列表，需传用户的unionId
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表，需传用户的unionId
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 详情页url跳转地址
    @NameInMap("detailUrl")
    public CreateTodoTaskRequestDetailUrl detailUrl;

    // 生成的待办是否仅展示在执行者的待办列表中
    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    // 优先级
    @NameInMap("priority")
    public Integer priority;

    // 通知提醒配置
    @NameInMap("notifyConfigs")
    public CreateTodoTaskRequestNotifyConfigs notifyConfigs;

    // 当前操作者id，需传用户的unionId
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

    public CreateTodoTaskRequest setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public CreateTodoTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
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
