// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppCreateEnterpriseTodoTaskRequest extends TeaModel {
    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    @NameInMap("customFields")
    public java.util.List<AppCreateEnterpriseTodoTaskRequestCustomFields> customFields;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public AppCreateEnterpriseTodoTaskRequestDetailUrl detailUrl;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("notifyConfigs")
    public AppCreateEnterpriseTodoTaskRequestNotifyConfigs notifyConfigs;

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

    @NameInMap("toolbarTemplateKey")
    public String toolbarTemplateKey;

    @NameInMap("type")
    public String type;

    public static AppCreateEnterpriseTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        AppCreateEnterpriseTodoTaskRequest self = new AppCreateEnterpriseTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public AppCreateEnterpriseTodoTaskRequest setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

    public AppCreateEnterpriseTodoTaskRequest setCustomFields(java.util.List<AppCreateEnterpriseTodoTaskRequestCustomFields> customFields) {
        this.customFields = customFields;
        return this;
    }
    public java.util.List<AppCreateEnterpriseTodoTaskRequestCustomFields> getCustomFields() {
        return this.customFields;
    }

    public AppCreateEnterpriseTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AppCreateEnterpriseTodoTaskRequest setDetailUrl(AppCreateEnterpriseTodoTaskRequestDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public AppCreateEnterpriseTodoTaskRequestDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public AppCreateEnterpriseTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public AppCreateEnterpriseTodoTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public AppCreateEnterpriseTodoTaskRequest setNotifyConfigs(AppCreateEnterpriseTodoTaskRequestNotifyConfigs notifyConfigs) {
        this.notifyConfigs = notifyConfigs;
        return this;
    }
    public AppCreateEnterpriseTodoTaskRequestNotifyConfigs getNotifyConfigs() {
        return this.notifyConfigs;
    }

    public AppCreateEnterpriseTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public AppCreateEnterpriseTodoTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public AppCreateEnterpriseTodoTaskRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public AppCreateEnterpriseTodoTaskRequest setSourceTitle(String sourceTitle) {
        this.sourceTitle = sourceTitle;
        return this;
    }
    public String getSourceTitle() {
        return this.sourceTitle;
    }

    public AppCreateEnterpriseTodoTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public AppCreateEnterpriseTodoTaskRequest setToolbarTemplateKey(String toolbarTemplateKey) {
        this.toolbarTemplateKey = toolbarTemplateKey;
        return this;
    }
    public String getToolbarTemplateKey() {
        return this.toolbarTemplateKey;
    }

    public AppCreateEnterpriseTodoTaskRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public static class AppCreateEnterpriseTodoTaskRequestCustomFields extends TeaModel {
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

        public static AppCreateEnterpriseTodoTaskRequestCustomFields build(java.util.Map<String, ?> map) throws Exception {
            AppCreateEnterpriseTodoTaskRequestCustomFields self = new AppCreateEnterpriseTodoTaskRequestCustomFields();
            return TeaModel.build(map, self);
        }

        public AppCreateEnterpriseTodoTaskRequestCustomFields setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AppCreateEnterpriseTodoTaskRequestCustomFields setFieldLink(String fieldLink) {
            this.fieldLink = fieldLink;
            return this;
        }
        public String getFieldLink() {
            return this.fieldLink;
        }

        public AppCreateEnterpriseTodoTaskRequestCustomFields setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public AppCreateEnterpriseTodoTaskRequestCustomFields setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public AppCreateEnterpriseTodoTaskRequestCustomFields setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

    }

    public static class AppCreateEnterpriseTodoTaskRequestDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

        @NameInMap("webUrl")
        public String webUrl;

        public static AppCreateEnterpriseTodoTaskRequestDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            AppCreateEnterpriseTodoTaskRequestDetailUrl self = new AppCreateEnterpriseTodoTaskRequestDetailUrl();
            return TeaModel.build(map, self);
        }

        public AppCreateEnterpriseTodoTaskRequestDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public AppCreateEnterpriseTodoTaskRequestDetailUrl setWebUrl(String webUrl) {
            this.webUrl = webUrl;
            return this;
        }
        public String getWebUrl() {
            return this.webUrl;
        }

    }

    public static class AppCreateEnterpriseTodoTaskRequestNotifyConfigs extends TeaModel {
        @NameInMap("dingNotify")
        public String dingNotify;

        public static AppCreateEnterpriseTodoTaskRequestNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            AppCreateEnterpriseTodoTaskRequestNotifyConfigs self = new AppCreateEnterpriseTodoTaskRequestNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public AppCreateEnterpriseTodoTaskRequestNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

    }

}
