// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskOfProjectResponseBody extends TeaModel {
    /**
     * <p>供分页使用，下一页token，从当前页结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>任务对象列表。</p>
     */
    @NameInMap("result")
    public java.util.List<QueryTaskOfProjectResponseBodyResult> result;

    /**
     * <p>任务总数。</p>
     */
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

    public static class QueryTaskOfProjectResponseBodyResult extends TeaModel {
        /**
         * <p>任务完成时间。</p>
         */
        @NameInMap("accomplished")
        public String accomplished;

        /**
         * <p>父任务id列表。</p>
         */
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        /**
         * <p>任务标题。</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>创建时间。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建者id。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>自定义字段id列表。</p>
         */
        @NameInMap("customfields")
        public java.util.List<String> customfields;

        /**
         * <p>任务截止时间。</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <p>执行者id。</p>
         */
        @NameInMap("executorId")
        public String executorId;

        /**
         * <p>参与者列表。</p>
         */
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <p>是否归档。</p>
         */
        @NameInMap("isArchived")
        public Boolean isArchived;

        /**
         * <p>是否已删除。</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <p>任务是否已完成。</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <p>任务自定义标识。</p>
         */
        @NameInMap("labels")
        public String labels;

        /**
         * <p>备注。</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <p>任务优先级。</p>
         */
        @NameInMap("priority")
        public Long priority;

        /**
         * <p>任务进度。</p>
         */
        @NameInMap("progress")
        public Integer progress;

        /**
         * <p>项目id。</p>
         */
        @NameInMap("projectId")
        public String projectId;

        /**
         * <p>任务类型id。</p>
         */
        @NameInMap("scenariofieldconfigId")
        public String scenariofieldconfigId;

        /**
         * <p>任务迭代id。</p>
         */
        @NameInMap("sprintId")
        public String sprintId;

        /**
         * <p>任务列表Id。</p>
         */
        @NameInMap("stageId")
        public String stageId;

        /**
         * <p>任务开始时间。</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>故事点数。</p>
         */
        @NameInMap("storyPoint")
        public Integer storyPoint;

        /**
         * <p>标签id集合。</p>
         */
        @NameInMap("tagIds")
        public String tagIds;

        /**
         * <p>任务id。</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <p>任务状态id。</p>
         */
        @NameInMap("taskflowstatusId")
        public String taskflowstatusId;

        /**
         * <p>更新时间。</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <p>任务的可见性规则 involves | members。</p>
         */
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

        public QueryTaskOfProjectResponseBodyResult setCustomfields(java.util.List<String> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<String> getCustomfields() {
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

        public QueryTaskOfProjectResponseBodyResult setLabels(String labels) {
            this.labels = labels;
            return this;
        }
        public String getLabels() {
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

        public QueryTaskOfProjectResponseBodyResult setTagIds(String tagIds) {
            this.tagIds = tagIds;
            return this;
        }
        public String getTagIds() {
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
