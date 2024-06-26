// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchUserTaskResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>DXF1ZXJ5QW5kRmV0Y2gBAAAAAAbMXT4WVjNKbUstaldRX3lOOHNBbElzcjA5Zw==</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>F86698E9-E4F5-1231-AC99-2ECFC0D37BDE</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<SearchUserTaskResponseBodyResult> result;

    public static SearchUserTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchUserTaskResponseBody self = new SearchUserTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchUserTaskResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchUserTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SearchUserTaskResponseBody setResult(java.util.List<SearchUserTaskResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchUserTaskResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SearchUserTaskResponseBodyResultCustomFieldsValue extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>642fb16c4a622b2e3184229c</p>
         */
        @NameInMap("customFieldValueId")
        public String customFieldValueId;

        /**
         * <strong>example:</strong>
         * <p>元数据内容</p>
         */
        @NameInMap("metaString")
        public String metaString;

        /**
         * <strong>example:</strong>
         * <p>标题</p>
         */
        @NameInMap("title")
        public String title;

        public static SearchUserTaskResponseBodyResultCustomFieldsValue build(java.util.Map<String, ?> map) throws Exception {
            SearchUserTaskResponseBodyResultCustomFieldsValue self = new SearchUserTaskResponseBodyResultCustomFieldsValue();
            return TeaModel.build(map, self);
        }

        public SearchUserTaskResponseBodyResultCustomFieldsValue setCustomFieldValueId(String customFieldValueId) {
            this.customFieldValueId = customFieldValueId;
            return this;
        }
        public String getCustomFieldValueId() {
            return this.customFieldValueId;
        }

        public SearchUserTaskResponseBodyResultCustomFieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public SearchUserTaskResponseBodyResultCustomFieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SearchUserTaskResponseBodyResultCustomFields extends TeaModel {
        @NameInMap("customFieldId")
        public String customFieldId;

        /**
         * <strong>example:</strong>
         * <p>number</p>
         */
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<SearchUserTaskResponseBodyResultCustomFieldsValue> value;

        public static SearchUserTaskResponseBodyResultCustomFields build(java.util.Map<String, ?> map) throws Exception {
            SearchUserTaskResponseBodyResultCustomFields self = new SearchUserTaskResponseBodyResultCustomFields();
            return TeaModel.build(map, self);
        }

        public SearchUserTaskResponseBodyResultCustomFields setCustomFieldId(String customFieldId) {
            this.customFieldId = customFieldId;
            return this;
        }
        public String getCustomFieldId() {
            return this.customFieldId;
        }

        public SearchUserTaskResponseBodyResultCustomFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public SearchUserTaskResponseBodyResultCustomFields setValue(java.util.List<SearchUserTaskResponseBodyResultCustomFieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<SearchUserTaskResponseBodyResultCustomFieldsValue> getValue() {
            return this.value;
        }

    }

    public static class SearchUserTaskResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2023-04-12T03:39:54.918Z</p>
         */
        @NameInMap("accomplishTime")
        public String accomplishTime;

        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        /**
         * <strong>example:</strong>
         * <p>任务内容</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>63a9207a042f7c254f60519c</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customFields")
        public java.util.List<SearchUserTaskResponseBodyResultCustomFields> customFields;

        /**
         * <strong>example:</strong>
         * <p>2022-07-05T03:29:34.770Z</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <strong>example:</strong>
         * <p>63a9207a042f7c254f60519c</p>
         */
        @NameInMap("executorId")
        public String executorId;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <strong>example:</strong>
         * <p>备注内容</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <strong>example:</strong>
         * <p>644b6f4cca369863fbc8abbb</p>
         */
        @NameInMap("parentTaskId")
        public String parentTaskId;

        @NameInMap("priority")
        public Integer priority;

        /**
         * <strong>example:</strong>
         * <p>643394f81502a928dbd5ba37</p>
         */
        @NameInMap("projectId")
        public String projectId;

        @NameInMap("recurrence")
        public java.util.List<String> recurrence;

        /**
         * <strong>example:</strong>
         * <p>64099d5b2f404400174d7fc1</p>
         */
        @NameInMap("scenarioFieldConfigId")
        public String scenarioFieldConfigId;

        /**
         * <strong>example:</strong>
         * <p>64099d5b2f404400174d7fc1</p>
         */
        @NameInMap("sprintId")
        public String sprintId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("storyPoint")
        public String storyPoint;

        @NameInMap("tagIds")
        public java.util.List<String> tagIds;

        /**
         * <strong>example:</strong>
         * <p>642befe827feb683f91bd529</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>6436278ea14fe435351668a2</p>
         */
        @NameInMap("taskListId")
        public String taskListId;

        /**
         * <strong>example:</strong>
         * <p>6436278ea14fe435351668a4</p>
         */
        @NameInMap("taskStageId")
        public String taskStageId;

        /**
         * <strong>example:</strong>
         * <p>64099d5b2f404400174d7fbb</p>
         */
        @NameInMap("taskflowStatusId")
        public String taskflowStatusId;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("uniqueId")
        public String uniqueId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <strong>example:</strong>
         * <p>projectMembers</p>
         */
        @NameInMap("visible")
        public String visible;

        public static SearchUserTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchUserTaskResponseBodyResult self = new SearchUserTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchUserTaskResponseBodyResult setAccomplishTime(String accomplishTime) {
            this.accomplishTime = accomplishTime;
            return this;
        }
        public String getAccomplishTime() {
            return this.accomplishTime;
        }

        public SearchUserTaskResponseBodyResult setAncestorIds(java.util.List<String> ancestorIds) {
            this.ancestorIds = ancestorIds;
            return this;
        }
        public java.util.List<String> getAncestorIds() {
            return this.ancestorIds;
        }

        public SearchUserTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public SearchUserTaskResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchUserTaskResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchUserTaskResponseBodyResult setCustomFields(java.util.List<SearchUserTaskResponseBodyResultCustomFields> customFields) {
            this.customFields = customFields;
            return this;
        }
        public java.util.List<SearchUserTaskResponseBodyResultCustomFields> getCustomFields() {
            return this.customFields;
        }

        public SearchUserTaskResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public SearchUserTaskResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public SearchUserTaskResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public SearchUserTaskResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public SearchUserTaskResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public SearchUserTaskResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public SearchUserTaskResponseBodyResult setParentTaskId(String parentTaskId) {
            this.parentTaskId = parentTaskId;
            return this;
        }
        public String getParentTaskId() {
            return this.parentTaskId;
        }

        public SearchUserTaskResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public SearchUserTaskResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public SearchUserTaskResponseBodyResult setRecurrence(java.util.List<String> recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public java.util.List<String> getRecurrence() {
            return this.recurrence;
        }

        public SearchUserTaskResponseBodyResult setScenarioFieldConfigId(String scenarioFieldConfigId) {
            this.scenarioFieldConfigId = scenarioFieldConfigId;
            return this;
        }
        public String getScenarioFieldConfigId() {
            return this.scenarioFieldConfigId;
        }

        public SearchUserTaskResponseBodyResult setSprintId(String sprintId) {
            this.sprintId = sprintId;
            return this;
        }
        public String getSprintId() {
            return this.sprintId;
        }

        public SearchUserTaskResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public SearchUserTaskResponseBodyResult setStoryPoint(String storyPoint) {
            this.storyPoint = storyPoint;
            return this;
        }
        public String getStoryPoint() {
            return this.storyPoint;
        }

        public SearchUserTaskResponseBodyResult setTagIds(java.util.List<String> tagIds) {
            this.tagIds = tagIds;
            return this;
        }
        public java.util.List<String> getTagIds() {
            return this.tagIds;
        }

        public SearchUserTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public SearchUserTaskResponseBodyResult setTaskListId(String taskListId) {
            this.taskListId = taskListId;
            return this;
        }
        public String getTaskListId() {
            return this.taskListId;
        }

        public SearchUserTaskResponseBodyResult setTaskStageId(String taskStageId) {
            this.taskStageId = taskStageId;
            return this;
        }
        public String getTaskStageId() {
            return this.taskStageId;
        }

        public SearchUserTaskResponseBodyResult setTaskflowStatusId(String taskflowStatusId) {
            this.taskflowStatusId = taskflowStatusId;
            return this;
        }
        public String getTaskflowStatusId() {
            return this.taskflowStatusId;
        }

        public SearchUserTaskResponseBodyResult setUniqueId(String uniqueId) {
            this.uniqueId = uniqueId;
            return this;
        }
        public String getUniqueId() {
            return this.uniqueId;
        }

        public SearchUserTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public SearchUserTaskResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
