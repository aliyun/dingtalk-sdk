// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTaskResponseBody extends TeaModel {
    /**
     * <p>接入应用标识</p>
     */
    @NameInMap("bizTag")
    public String bizTag;

    /**
     * <p>内容区表单字段配置</p>
     */
    @NameInMap("contentFieldList")
    public java.util.List<CreateTodoTaskResponseBodyContentFieldList> contentFieldList;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    /**
     * <p>创建者（用户的unionId）</p>
     */
    @NameInMap("creatorId")
    public String creatorId;

    /**
     * <p>描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>自定义详情页跳转配置</p>
     */
    @NameInMap("detailUrl")
    public CreateTodoTaskResponseBodyDetailUrl detailUrl;

    /**
     * <p>完成状态</p>
     */
    @NameInMap("done")
    public Boolean done;

    /**
     * <p>截止时间</p>
     */
    @NameInMap("dueTime")
    public Long dueTime;

    /**
     * <p>执行者列表（用户的unionId）</p>
     */
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    /**
     * <p>完成时间</p>
     */
    @NameInMap("finishTime")
    public Long finishTime;

    /**
     * <p>id</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>生成的待办是否仅展示在执行者的待办列表中</p>
     */
    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    /**
     * <p>更新时间</p>
     */
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    /**
     * <p>更新者（用户的unionId）</p>
     */
    @NameInMap("modifierId")
    public String modifierId;

    /**
     * <p>待办通知配置</p>
     */
    @NameInMap("notifyConfigs")
    public CreateTodoTaskResponseBodyNotifyConfigs notifyConfigs;

    /**
     * <p>参与者列表（用户的unionId）</p>
     */
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    /**
     * <p>优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40</p>
     */
    @NameInMap("priority")
    public Integer priority;

    /**
     * <p>requestId</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>业务来源</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>业务来源id</p>
     */
    @NameInMap("sourceId")
    public String sourceId;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>标题</p>
     */
    @NameInMap("subject")
    public String subject;

    public static CreateTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTaskResponseBody self = new CreateTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTodoTaskResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public CreateTodoTaskResponseBody setContentFieldList(java.util.List<CreateTodoTaskResponseBodyContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<CreateTodoTaskResponseBodyContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public CreateTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public CreateTodoTaskResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateTodoTaskResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTodoTaskResponseBody setDetailUrl(CreateTodoTaskResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public CreateTodoTaskResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public CreateTodoTaskResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public CreateTodoTaskResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public CreateTodoTaskResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public CreateTodoTaskResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public CreateTodoTaskResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateTodoTaskResponseBody setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public CreateTodoTaskResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public CreateTodoTaskResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public CreateTodoTaskResponseBody setNotifyConfigs(CreateTodoTaskResponseBodyNotifyConfigs notifyConfigs) {
        this.notifyConfigs = notifyConfigs;
        return this;
    }
    public CreateTodoTaskResponseBodyNotifyConfigs getNotifyConfigs() {
        return this.notifyConfigs;
    }

    public CreateTodoTaskResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public CreateTodoTaskResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public CreateTodoTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
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

    public CreateTodoTaskResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateTodoTaskResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public static class CreateTodoTaskResponseBodyContentFieldList extends TeaModel {
        /**
         * <p>字段唯一标识</p>
         */
        @NameInMap("fieldKey")
        public String fieldKey;

        /**
         * <p>字段值</p>
         */
        @NameInMap("fieldValue")
        public String fieldValue;

        public static CreateTodoTaskResponseBodyContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyContentFieldList self = new CreateTodoTaskResponseBodyContentFieldList();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public CreateTodoTaskResponseBodyContentFieldList setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

    }

    public static class CreateTodoTaskResponseBodyDetailUrl extends TeaModel {
        /**
         * <p>app端详情页地址</p>
         */
        @NameInMap("appUrl")
        public String appUrl;

        /**
         * <p>pc端详情页地址</p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        public static CreateTodoTaskResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyDetailUrl self = new CreateTodoTaskResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public CreateTodoTaskResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class CreateTodoTaskResponseBodyNotifyConfigs extends TeaModel {
        /**
         * <p>ding通知配置：value:"channel"（1钉弹框通知，2钉短信通知，3钉电话通知）</p>
         */
        @NameInMap("dingNotify")
        public String dingNotify;

        public static CreateTodoTaskResponseBodyNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyNotifyConfigs self = new CreateTodoTaskResponseBodyNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

    }

}
