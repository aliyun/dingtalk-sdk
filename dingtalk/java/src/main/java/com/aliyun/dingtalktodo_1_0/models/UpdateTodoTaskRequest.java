// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskRequest extends TeaModel {
    // 待办标题
    @NameInMap("subject")
    public String subject;

    // 待办描述备注
    @NameInMap("description")
    public String description;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 执行者列表，需传用户的unionId
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表，需传用户的unionId
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 待办卡片类型id
    @NameInMap("cardTypeId")
    public String cardTypeId;

    // 内容区表单字段配置
    @NameInMap("contentFieldList")
    public java.util.List<UpdateTodoTaskRequestContentFieldList> contentFieldList;

    // 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
    @NameInMap("priority")
    public Integer priority;

    // 业务来源展示名称
    @NameInMap("sourceTitle")
    public String sourceTitle;

    // 当前操作者id，需传用户的unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskRequest self = new UpdateTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public UpdateTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public UpdateTodoTaskRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public UpdateTodoTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public UpdateTodoTaskRequest setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public UpdateTodoTaskRequest setCardTypeId(String cardTypeId) {
        this.cardTypeId = cardTypeId;
        return this;
    }
    public String getCardTypeId() {
        return this.cardTypeId;
    }

    public UpdateTodoTaskRequest setContentFieldList(java.util.List<UpdateTodoTaskRequestContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<UpdateTodoTaskRequestContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public UpdateTodoTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public UpdateTodoTaskRequest setSourceTitle(String sourceTitle) {
        this.sourceTitle = sourceTitle;
        return this;
    }
    public String getSourceTitle() {
        return this.sourceTitle;
    }

    public UpdateTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateTodoTaskRequestContentFieldList extends TeaModel {
        // 字段唯一标识
        @NameInMap("fieldKey")
        public String fieldKey;

        // 字段值
        @NameInMap("fieldValue")
        public String fieldValue;

        public static UpdateTodoTaskRequestContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            UpdateTodoTaskRequestContentFieldList self = new UpdateTodoTaskRequestContentFieldList();
            return TeaModel.build(map, self);
        }

        public UpdateTodoTaskRequestContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public UpdateTodoTaskRequestContentFieldList setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

    }

}
