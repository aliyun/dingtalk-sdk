// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchUserTaskResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<SearchUserTaskResponseBodyResult> result;

    @NameInMap("totalSize")
    public Integer totalSize;

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

    public SearchUserTaskResponseBody setTotalSize(Integer totalSize) {
        this.totalSize = totalSize;
        return this;
    }
    public Integer getTotalSize() {
        return this.totalSize;
    }

    public static class SearchUserTaskResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static SearchUserTaskResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            SearchUserTaskResponseBodyResultCustomfieldsValue self = new SearchUserTaskResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public SearchUserTaskResponseBodyResultCustomfieldsValue setFieldvalueId(String fieldvalueId) {
            this.fieldvalueId = fieldvalueId;
            return this;
        }
        public String getFieldvalueId() {
            return this.fieldvalueId;
        }

        public SearchUserTaskResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public SearchUserTaskResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchUserTaskResponseBodyResultCustomfieldsValue setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

    public static class SearchUserTaskResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("customfieldId")
        public String customfieldId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<SearchUserTaskResponseBodyResultCustomfieldsValue> value;

        public static SearchUserTaskResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            SearchUserTaskResponseBodyResultCustomfields self = new SearchUserTaskResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public SearchUserTaskResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public SearchUserTaskResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public SearchUserTaskResponseBodyResultCustomfields setValue(java.util.List<SearchUserTaskResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<SearchUserTaskResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class SearchUserTaskResponseBodyResult extends TeaModel {
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

        @NameInMap("customfields")
        public java.util.List<SearchUserTaskResponseBodyResultCustomfields> customfields;

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

        @NameInMap("sfcId")
        public String sfcId;

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

        @NameInMap("taskflowstatusId")
        public String taskflowstatusId;

        @NameInMap("taskstageId")
        public String taskstageId;

        @NameInMap("uniqueId")
        public String uniqueId;

        @NameInMap("updated")
        public String updated;

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

        public SearchUserTaskResponseBodyResult setCustomfields(java.util.List<SearchUserTaskResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<SearchUserTaskResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
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

        public SearchUserTaskResponseBodyResult setSfcId(String sfcId) {
            this.sfcId = sfcId;
            return this;
        }
        public String getSfcId() {
            return this.sfcId;
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

        public SearchUserTaskResponseBodyResult setTaskflowstatusId(String taskflowstatusId) {
            this.taskflowstatusId = taskflowstatusId;
            return this;
        }
        public String getTaskflowstatusId() {
            return this.taskflowstatusId;
        }

        public SearchUserTaskResponseBodyResult setTaskstageId(String taskstageId) {
            this.taskstageId = taskstageId;
            return this;
        }
        public String getTaskstageId() {
            return this.taskstageId;
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
