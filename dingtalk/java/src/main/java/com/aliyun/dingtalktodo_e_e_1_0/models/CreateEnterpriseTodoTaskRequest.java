// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class CreateEnterpriseTodoTaskRequest extends TeaModel {
    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    @NameInMap("customFields")
    public java.util.List<CreateEnterpriseTodoTaskRequestCustomFields> customFields;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public CreateEnterpriseTodoTaskRequestDetailUrl detailUrl;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("notifyConfigs")
    public CreateEnterpriseTodoTaskRequestNotifyConfigs notifyConfigs;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("priority")
    public Integer priority;

    @NameInMap("sourceId")
    public String sourceId;

    @NameInMap("sourceTitle")
    public String sourceTitle;

    @NameInMap("subject")
    public String subject;

    @NameInMap("trackerIds")
    public java.util.List<String> trackerIds;

    @NameInMap("type")
    public String type;

    public static CreateEnterpriseTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateEnterpriseTodoTaskRequest self = new CreateEnterpriseTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateEnterpriseTodoTaskRequest setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

    public CreateEnterpriseTodoTaskRequest setCustomFields(java.util.List<CreateEnterpriseTodoTaskRequestCustomFields> customFields) {
        this.customFields = customFields;
        return this;
    }
    public java.util.List<CreateEnterpriseTodoTaskRequestCustomFields> getCustomFields() {
        return this.customFields;
    }

    public CreateEnterpriseTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEnterpriseTodoTaskRequest setDetailUrl(CreateEnterpriseTodoTaskRequestDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public CreateEnterpriseTodoTaskRequestDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public CreateEnterpriseTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public CreateEnterpriseTodoTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public CreateEnterpriseTodoTaskRequest setNotifyConfigs(CreateEnterpriseTodoTaskRequestNotifyConfigs notifyConfigs) {
        this.notifyConfigs = notifyConfigs;
        return this;
    }
    public CreateEnterpriseTodoTaskRequestNotifyConfigs getNotifyConfigs() {
        return this.notifyConfigs;
    }

    public CreateEnterpriseTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateEnterpriseTodoTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public CreateEnterpriseTodoTaskRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public CreateEnterpriseTodoTaskRequest setSourceTitle(String sourceTitle) {
        this.sourceTitle = sourceTitle;
        return this;
    }
    public String getSourceTitle() {
        return this.sourceTitle;
    }

    public CreateEnterpriseTodoTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public CreateEnterpriseTodoTaskRequest setTrackerIds(java.util.List<String> trackerIds) {
        this.trackerIds = trackerIds;
        return this;
    }
    public java.util.List<String> getTrackerIds() {
        return this.trackerIds;
    }

    public CreateEnterpriseTodoTaskRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public static class CreateEnterpriseTodoTaskRequestCustomFields extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldLink")
        public String fieldLink;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("fieldValue")
        public String fieldValue;

        @NameInMap("icon")
        public String icon;

        public static CreateEnterpriseTodoTaskRequestCustomFields build(java.util.Map<String, ?> map) throws Exception {
            CreateEnterpriseTodoTaskRequestCustomFields self = new CreateEnterpriseTodoTaskRequestCustomFields();
            return TeaModel.build(map, self);
        }

        public CreateEnterpriseTodoTaskRequestCustomFields setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public CreateEnterpriseTodoTaskRequestCustomFields setFieldLink(String fieldLink) {
            this.fieldLink = fieldLink;
            return this;
        }
        public String getFieldLink() {
            return this.fieldLink;
        }

        public CreateEnterpriseTodoTaskRequestCustomFields setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public CreateEnterpriseTodoTaskRequestCustomFields setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public CreateEnterpriseTodoTaskRequestCustomFields setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

    }

    public static class CreateEnterpriseTodoTaskRequestDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

        @NameInMap("webUrl")
        public String webUrl;

        public static CreateEnterpriseTodoTaskRequestDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            CreateEnterpriseTodoTaskRequestDetailUrl self = new CreateEnterpriseTodoTaskRequestDetailUrl();
            return TeaModel.build(map, self);
        }

        public CreateEnterpriseTodoTaskRequestDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public CreateEnterpriseTodoTaskRequestDetailUrl setWebUrl(String webUrl) {
            this.webUrl = webUrl;
            return this;
        }
        public String getWebUrl() {
            return this.webUrl;
        }

    }

    public static class CreateEnterpriseTodoTaskRequestNotifyConfigs extends TeaModel {
        @NameInMap("dingNotify")
        public String dingNotify;

        public static CreateEnterpriseTodoTaskRequestNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateEnterpriseTodoTaskRequestNotifyConfigs self = new CreateEnterpriseTodoTaskRequestNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public CreateEnterpriseTodoTaskRequestNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

    }

}
