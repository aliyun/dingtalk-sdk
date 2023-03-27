// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTaskByIdsResponseBody extends TeaModel {
    /**
     * <p>任务详情集合。</p>
     */
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

    public static class GetTaskByIdsResponseBodyResultCustomfieldsValue extends TeaModel {
        /**
         * <p>字段值ID。</p>
         */
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        /**
         * <p>字段值元属性。</p>
         */
        @NameInMap("metaString")
        public String metaString;

        /**
         * <p>字段值内容。</p>
         */
        @NameInMap("title")
        public String title;

        public static GetTaskByIdsResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            GetTaskByIdsResponseBodyResultCustomfieldsValue self = new GetTaskByIdsResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public GetTaskByIdsResponseBodyResultCustomfieldsValue setFieldvalueId(String fieldvalueId) {
            this.fieldvalueId = fieldvalueId;
            return this;
        }
        public String getFieldvalueId() {
            return this.fieldvalueId;
        }

        public GetTaskByIdsResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public GetTaskByIdsResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetTaskByIdsResponseBodyResultCustomfields extends TeaModel {
        /**
         * <p>自定义字段ID。</p>
         */
        @NameInMap("customfieldId")
        public String customfieldId;

        /**
         * <p>自定义字段类型。</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>字段值集合。</p>
         */
        @NameInMap("value")
        public java.util.List<GetTaskByIdsResponseBodyResultCustomfieldsValue> value;

        public static GetTaskByIdsResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            GetTaskByIdsResponseBodyResultCustomfields self = new GetTaskByIdsResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public GetTaskByIdsResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public GetTaskByIdsResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetTaskByIdsResponseBodyResultCustomfields setValue(java.util.List<GetTaskByIdsResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<GetTaskByIdsResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class GetTaskByIdsResponseBodyResult extends TeaModel {
        /**
         * <p>任务完成时间(UTC)。</p>
         */
        @NameInMap("accomplishTime")
        public String accomplishTime;

        /**
         * <p>祖先任务ID列表。</p>
         */
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        /**
         * <p>任务标题。</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>创建时间(UTC)。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建人ID。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>自定义字段值集合。</p>
         */
        @NameInMap("customfields")
        public java.util.List<GetTaskByIdsResponseBodyResultCustomfields> customfields;

        /**
         * <p>任务截止时间(UTC)。</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <p>执行人ID。</p>
         */
        @NameInMap("executorId")
        public String executorId;

        /**
         * <p>参与者ID集合。</p>
         */
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <p>是否任务放入回收站。</p>
         */
        @NameInMap("isArchived")
        public Boolean isArchived;

        /**
         * <p>是否任务已完成。</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <p>任务备注。</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <p>父任务ID。</p>
         */
        @NameInMap("parentTaskId")
        public String parentTaskId;

        /**
         * <p>任务优先级。</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <p>项目ID。</p>
         */
        @NameInMap("projectId")
        public String projectId;

        /**
         * <p>重复规则列表。</p>
         */
        @NameInMap("recurrence")
        public java.util.List<String> recurrence;

        /**
         * <p>任务类型ID。</p>
         */
        @NameInMap("scenariofieldconfigId")
        public String scenariofieldconfigId;

        /**
         * <p>迭代ID。</p>
         */
        @NameInMap("sprintId")
        public String sprintId;

        /**
         * <p>任务列ID。</p>
         */
        @NameInMap("stageId")
        public String stageId;

        /**
         * <p>任务开始时间(UTC)。</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>StoryPoint。</p>
         */
        @NameInMap("storyPoint")
        public String storyPoint;

        /**
         * <p>标签ID集合。</p>
         */
        @NameInMap("tagIds")
        public java.util.List<String> tagIds;

        /**
         * <p>任务ID。</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <p>任务分组ID。</p>
         */
        @NameInMap("taskListId")
        public String taskListId;

        /**
         * <p>任务状态ID。</p>
         */
        @NameInMap("taskflowstatusId")
        public String taskflowstatusId;

        /**
         * <p>任务数字ID。</p>
         */
        @NameInMap("uniqueId")
        public String uniqueId;

        /**
         * <p>更新时间(UTC)。</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <p>任务隐私性，'involves'表达仅参与者可见; 'members'表达项目成员可见。</p>
         */
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

        public GetTaskByIdsResponseBodyResult setCustomfields(java.util.List<GetTaskByIdsResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<GetTaskByIdsResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
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

        public GetTaskByIdsResponseBodyResult setScenariofieldconfigId(String scenariofieldconfigId) {
            this.scenariofieldconfigId = scenariofieldconfigId;
            return this;
        }
        public String getScenariofieldconfigId() {
            return this.scenariofieldconfigId;
        }

        public GetTaskByIdsResponseBodyResult setSprintId(String sprintId) {
            this.sprintId = sprintId;
            return this;
        }
        public String getSprintId() {
            return this.sprintId;
        }

        public GetTaskByIdsResponseBodyResult setStageId(String stageId) {
            this.stageId = stageId;
            return this;
        }
        public String getStageId() {
            return this.stageId;
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

        public GetTaskByIdsResponseBodyResult setTaskflowstatusId(String taskflowstatusId) {
            this.taskflowstatusId = taskflowstatusId;
            return this;
        }
        public String getTaskflowstatusId() {
            return this.taskflowstatusId;
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
