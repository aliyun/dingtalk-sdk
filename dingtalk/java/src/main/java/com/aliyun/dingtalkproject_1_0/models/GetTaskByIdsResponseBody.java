// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTaskByIdsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetTaskByIdsResponseBodyResult> result;

    public static GetTaskByIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskByIdsResponseBody self = new GetTaskByIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskByIdsResponseBody setResult(java.util.List<GetTaskByIdsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetTaskByIdsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetTaskByIdsResponseBodyResultCustomFieldsValue extends TeaModel {
        @NameInMap("customFieldValueId")
        public String customFieldValueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static GetTaskByIdsResponseBodyResultCustomFieldsValue build(java.util.Map<String, ?> map) throws Exception {
            GetTaskByIdsResponseBodyResultCustomFieldsValue self = new GetTaskByIdsResponseBodyResultCustomFieldsValue();
            return TeaModel.build(map, self);
        }

        public GetTaskByIdsResponseBodyResultCustomFieldsValue setCustomFieldValueId(String customFieldValueId) {
            this.customFieldValueId = customFieldValueId;
            return this;
        }
        public String getCustomFieldValueId() {
            return this.customFieldValueId;
        }

        public GetTaskByIdsResponseBodyResultCustomFieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public GetTaskByIdsResponseBodyResultCustomFieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetTaskByIdsResponseBodyResultCustomFields extends TeaModel {
        @NameInMap("customFieldId")
        public String customFieldId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<GetTaskByIdsResponseBodyResultCustomFieldsValue> value;

        public static GetTaskByIdsResponseBodyResultCustomFields build(java.util.Map<String, ?> map) throws Exception {
            GetTaskByIdsResponseBodyResultCustomFields self = new GetTaskByIdsResponseBodyResultCustomFields();
            return TeaModel.build(map, self);
        }

        public GetTaskByIdsResponseBodyResultCustomFields setCustomFieldId(String customFieldId) {
            this.customFieldId = customFieldId;
            return this;
        }
        public String getCustomFieldId() {
            return this.customFieldId;
        }

        public GetTaskByIdsResponseBodyResultCustomFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetTaskByIdsResponseBodyResultCustomFields setValue(java.util.List<GetTaskByIdsResponseBodyResultCustomFieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<GetTaskByIdsResponseBodyResultCustomFieldsValue> getValue() {
            return this.value;
        }

    }

    public static class GetTaskByIdsResponseBodyResult extends TeaModel {
        @NameInMap("accomplishTime")
        public String accomplishTime;

        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        @NameInMap("content")
        public String content;

        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customFields")
        public java.util.List<GetTaskByIdsResponseBodyResultCustomFields> customFields;

        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("isDone")
        public Boolean isDone;

        @NameInMap("note")
        public String note;

        @NameInMap("parentTaskId")
        public String parentTaskId;

        @NameInMap("priority")
        public Integer priority;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("recurrence")
        public java.util.List<String> recurrence;

        @NameInMap("scenarioFieldConfigId")
        public String scenarioFieldConfigId;

        @NameInMap("sprintId")
        public String sprintId;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("storyPoint")
        public String storyPoint;

        @NameInMap("tagIds")
        public java.util.List<String> tagIds;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskListId")
        public String taskListId;

        @NameInMap("taskStageId")
        public String taskStageId;

        @NameInMap("taskflowStatusId")
        public String taskflowStatusId;

        @NameInMap("uniqueId")
        public String uniqueId;

        @NameInMap("updated")
        public String updated;

        @NameInMap("visible")
        public String visible;

        public static GetTaskByIdsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTaskByIdsResponseBodyResult self = new GetTaskByIdsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTaskByIdsResponseBodyResult setAccomplishTime(String accomplishTime) {
            this.accomplishTime = accomplishTime;
            return this;
        }
        public String getAccomplishTime() {
            return this.accomplishTime;
        }

        public GetTaskByIdsResponseBodyResult setAncestorIds(java.util.List<String> ancestorIds) {
            this.ancestorIds = ancestorIds;
            return this;
        }
        public java.util.List<String> getAncestorIds() {
            return this.ancestorIds;
        }

        public GetTaskByIdsResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetTaskByIdsResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetTaskByIdsResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetTaskByIdsResponseBodyResult setCustomFields(java.util.List<GetTaskByIdsResponseBodyResultCustomFields> customFields) {
            this.customFields = customFields;
            return this;
        }
        public java.util.List<GetTaskByIdsResponseBodyResultCustomFields> getCustomFields() {
            return this.customFields;
        }

        public GetTaskByIdsResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public GetTaskByIdsResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public GetTaskByIdsResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public GetTaskByIdsResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public GetTaskByIdsResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public GetTaskByIdsResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public GetTaskByIdsResponseBodyResult setParentTaskId(String parentTaskId) {
            this.parentTaskId = parentTaskId;
            return this;
        }
        public String getParentTaskId() {
            return this.parentTaskId;
        }

        public GetTaskByIdsResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public GetTaskByIdsResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public GetTaskByIdsResponseBodyResult setRecurrence(java.util.List<String> recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public java.util.List<String> getRecurrence() {
            return this.recurrence;
        }

        public GetTaskByIdsResponseBodyResult setScenarioFieldConfigId(String scenarioFieldConfigId) {
            this.scenarioFieldConfigId = scenarioFieldConfigId;
            return this;
        }
        public String getScenarioFieldConfigId() {
            return this.scenarioFieldConfigId;
        }

        public GetTaskByIdsResponseBodyResult setSprintId(String sprintId) {
            this.sprintId = sprintId;
            return this;
        }
        public String getSprintId() {
            return this.sprintId;
        }

        public GetTaskByIdsResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetTaskByIdsResponseBodyResult setStoryPoint(String storyPoint) {
            this.storyPoint = storyPoint;
            return this;
        }
        public String getStoryPoint() {
            return this.storyPoint;
        }

        public GetTaskByIdsResponseBodyResult setTagIds(java.util.List<String> tagIds) {
            this.tagIds = tagIds;
            return this;
        }
        public java.util.List<String> getTagIds() {
            return this.tagIds;
        }

        public GetTaskByIdsResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetTaskByIdsResponseBodyResult setTaskListId(String taskListId) {
            this.taskListId = taskListId;
            return this;
        }
        public String getTaskListId() {
            return this.taskListId;
        }

        public GetTaskByIdsResponseBodyResult setTaskStageId(String taskStageId) {
            this.taskStageId = taskStageId;
            return this;
        }
        public String getTaskStageId() {
            return this.taskStageId;
        }

        public GetTaskByIdsResponseBodyResult setTaskflowStatusId(String taskflowStatusId) {
            this.taskflowStatusId = taskflowStatusId;
            return this;
        }
        public String getTaskflowStatusId() {
            return this.taskflowStatusId;
        }

        public GetTaskByIdsResponseBodyResult setUniqueId(String uniqueId) {
            this.uniqueId = uniqueId;
            return this;
        }
        public String getUniqueId() {
            return this.uniqueId;
        }

        public GetTaskByIdsResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public GetTaskByIdsResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
