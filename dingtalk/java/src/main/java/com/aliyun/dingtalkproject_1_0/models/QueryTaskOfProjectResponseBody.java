// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskOfProjectResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<QueryTaskOfProjectResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryTaskOfProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTaskOfProjectResponseBody self = new QueryTaskOfProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTaskOfProjectResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryTaskOfProjectResponseBody setResult(java.util.List<QueryTaskOfProjectResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryTaskOfProjectResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryTaskOfProjectResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryTaskOfProjectResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("customfieldId")
        public String customfieldId;

        public static QueryTaskOfProjectResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskOfProjectResponseBodyResultCustomfields self = new QueryTaskOfProjectResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public QueryTaskOfProjectResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

    }

    public static class QueryTaskOfProjectResponseBodyResult extends TeaModel {
        @NameInMap("accomplished")
        public String accomplished;

        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        @NameInMap("content")
        public String content;

        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfields")
        public java.util.List<QueryTaskOfProjectResponseBodyResultCustomfields> customfields;

        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("isDeleted")
        public Boolean isDeleted;

        @NameInMap("isDone")
        public Boolean isDone;

        @NameInMap("labels")
        public java.util.List<String> labels;

        @NameInMap("note")
        public String note;

        @NameInMap("priority")
        public Long priority;

        @NameInMap("progress")
        public Integer progress;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("scenariofieldconfigId")
        public String scenariofieldconfigId;

        @NameInMap("sprintId")
        public String sprintId;

        @NameInMap("stageId")
        public String stageId;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("storyPoint")
        public Integer storyPoint;

        @NameInMap("tagIds")
        public java.util.List<String> tagIds;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskflowstatusId")
        public String taskflowstatusId;

        @NameInMap("updated")
        public String updated;

        @NameInMap("visible")
        public String visible;

        public static QueryTaskOfProjectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskOfProjectResponseBodyResult self = new QueryTaskOfProjectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryTaskOfProjectResponseBodyResult setAccomplished(String accomplished) {
            this.accomplished = accomplished;
            return this;
        }
        public String getAccomplished() {
            return this.accomplished;
        }

        public QueryTaskOfProjectResponseBodyResult setAncestorIds(java.util.List<String> ancestorIds) {
            this.ancestorIds = ancestorIds;
            return this;
        }
        public java.util.List<String> getAncestorIds() {
            return this.ancestorIds;
        }

        public QueryTaskOfProjectResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryTaskOfProjectResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public QueryTaskOfProjectResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryTaskOfProjectResponseBodyResult setCustomfields(java.util.List<QueryTaskOfProjectResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<QueryTaskOfProjectResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

        public QueryTaskOfProjectResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public QueryTaskOfProjectResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public QueryTaskOfProjectResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public QueryTaskOfProjectResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public QueryTaskOfProjectResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public QueryTaskOfProjectResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryTaskOfProjectResponseBodyResult setLabels(java.util.List<String> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<String> getLabels() {
            return this.labels;
        }

        public QueryTaskOfProjectResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public QueryTaskOfProjectResponseBodyResult setPriority(Long priority) {
            this.priority = priority;
            return this;
        }
        public Long getPriority() {
            return this.priority;
        }

        public QueryTaskOfProjectResponseBodyResult setProgress(Integer progress) {
            this.progress = progress;
            return this;
        }
        public Integer getProgress() {
            return this.progress;
        }

        public QueryTaskOfProjectResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public QueryTaskOfProjectResponseBodyResult setScenariofieldconfigId(String scenariofieldconfigId) {
            this.scenariofieldconfigId = scenariofieldconfigId;
            return this;
        }
        public String getScenariofieldconfigId() {
            return this.scenariofieldconfigId;
        }

        public QueryTaskOfProjectResponseBodyResult setSprintId(String sprintId) {
            this.sprintId = sprintId;
            return this;
        }
        public String getSprintId() {
            return this.sprintId;
        }

        public QueryTaskOfProjectResponseBodyResult setStageId(String stageId) {
            this.stageId = stageId;
            return this;
        }
        public String getStageId() {
            return this.stageId;
        }

        public QueryTaskOfProjectResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public QueryTaskOfProjectResponseBodyResult setStoryPoint(Integer storyPoint) {
            this.storyPoint = storyPoint;
            return this;
        }
        public Integer getStoryPoint() {
            return this.storyPoint;
        }

        public QueryTaskOfProjectResponseBodyResult setTagIds(java.util.List<String> tagIds) {
            this.tagIds = tagIds;
            return this;
        }
        public java.util.List<String> getTagIds() {
            return this.tagIds;
        }

        public QueryTaskOfProjectResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public QueryTaskOfProjectResponseBodyResult setTaskflowstatusId(String taskflowstatusId) {
            this.taskflowstatusId = taskflowstatusId;
            return this;
        }
        public String getTaskflowstatusId() {
            return this.taskflowstatusId;
        }

        public QueryTaskOfProjectResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public QueryTaskOfProjectResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
