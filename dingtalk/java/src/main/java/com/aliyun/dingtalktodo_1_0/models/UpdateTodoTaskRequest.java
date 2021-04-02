// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskRequest extends TeaModel {
    // 待办标题
    @NameInMap("sucject")
    public String sucject;

    // 待办描述备注
    @NameInMap("description")
    public String description;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 执行者列表
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 详情页url跳转地址
    @NameInMap("detailUrl")
    public UpdateTodoTaskRequestDetailUrl detailUrl;

    // 待办重复规则配置
    @NameInMap("recurrence")
    public String recurrence;

    // 待办提醒规则配置
    @NameInMap("reminder")
    public UpdateTodoTaskRequestReminder reminder;

    // 当前操作者id
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskRequest self = new UpdateTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskRequest setSucject(String sucject) {
        this.sucject = sucject;
        return this;
    }
    public String getSucject() {
        return this.sucject;
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

    public UpdateTodoTaskRequest setDetailUrl(UpdateTodoTaskRequestDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public UpdateTodoTaskRequestDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public UpdateTodoTaskRequest setRecurrence(String recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public String getRecurrence() {
        return this.recurrence;
    }

    public UpdateTodoTaskRequest setReminder(UpdateTodoTaskRequestReminder reminder) {
        this.reminder = reminder;
        return this;
    }
    public UpdateTodoTaskRequestReminder getReminder() {
        return this.reminder;
    }

    public UpdateTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateTodoTaskRequestDetailUrl extends TeaModel {
        // app端详情页url
        @NameInMap("appUrl")
        public String appUrl;

        // pc端详情页url
        @NameInMap("pcUrl")
        public String pcUrl;

        public static UpdateTodoTaskRequestDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            UpdateTodoTaskRequestDetailUrl self = new UpdateTodoTaskRequestDetailUrl();
            return TeaModel.build(map, self);
        }

        public UpdateTodoTaskRequestDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public UpdateTodoTaskRequestDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class UpdateTodoTaskRequestReminderRules extends TeaModel {
        // startTime:相对开始时间  											//  					dueTime:相对截止时间 											//						customTime: 绝对时间
        @NameInMap("baseTime")
        public String baseTime;

        // 必须，baseTime 为 startTime 或者 dueTime 时表分钟；比如截止前15分钟为 -15，截止前3小时为 -180;basetime 为 customTime 时为时间戳
        @NameInMap("offset")
        public Long offset;

        public static UpdateTodoTaskRequestReminderRules build(java.util.Map<String, ?> map) throws Exception {
            UpdateTodoTaskRequestReminderRules self = new UpdateTodoTaskRequestReminderRules();
            return TeaModel.build(map, self);
        }

        public UpdateTodoTaskRequestReminderRules setBaseTime(String baseTime) {
            this.baseTime = baseTime;
            return this;
        }
        public String getBaseTime() {
            return this.baseTime;
        }

        public UpdateTodoTaskRequestReminderRules setOffset(Long offset) {
            this.offset = offset;
            return this;
        }
        public Long getOffset() {
            return this.offset;
        }

    }

    public static class UpdateTodoTaskRequestReminder extends TeaModel {
        // 提醒通道，1 弹框，2 短信，3 电话
        @NameInMap("channel")
        public Integer channel;

        // 提醒规则列表
        @NameInMap("rules")
        public java.util.List<UpdateTodoTaskRequestReminderRules> rules;

        public static UpdateTodoTaskRequestReminder build(java.util.Map<String, ?> map) throws Exception {
            UpdateTodoTaskRequestReminder self = new UpdateTodoTaskRequestReminder();
            return TeaModel.build(map, self);
        }

        public UpdateTodoTaskRequestReminder setChannel(Integer channel) {
            this.channel = channel;
            return this;
        }
        public Integer getChannel() {
            return this.channel;
        }

        public UpdateTodoTaskRequestReminder setRules(java.util.List<UpdateTodoTaskRequestReminderRules> rules) {
            this.rules = rules;
            return this;
        }
        public java.util.List<UpdateTodoTaskRequestReminderRules> getRules() {
            return this.rules;
        }

    }

}
