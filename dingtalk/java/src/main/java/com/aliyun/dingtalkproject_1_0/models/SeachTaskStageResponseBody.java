// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SeachTaskStageResponseBody extends TeaModel {
    /**
     * <p>分页标，供分页使用，下一页token。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>任务列表列表。</p>
     */
    @NameInMap("result")
    public java.util.List<SeachTaskStageResponseBodyResult> result;

    /**
     * <p>总数。</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static SeachTaskStageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SeachTaskStageResponseBody self = new SeachTaskStageResponseBody();
        return TeaModel.build(map, self);
    }

    public SeachTaskStageResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SeachTaskStageResponseBody setResult(java.util.List<SeachTaskStageResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SeachTaskStageResponseBodyResult> getResult() {
        return this.result;
    }

    public SeachTaskStageResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class SeachTaskStageResponseBodyResult extends TeaModel {
        /**
         * <p>创建时间。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建者用户 ID。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>任务列表名称。</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>任务列表名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>项目 ID。</p>
         */
        @NameInMap("projectId")
        public String projectId;

        /**
         * <p>任务分组 ID。</p>
         */
        @NameInMap("taskListId")
        public String taskListId;

        /**
         * <p>任务列表 ID。</p>
         */
        @NameInMap("taskStageId")
        public String taskStageId;

        /**
         * <p>更新时间。</p>
         */
        @NameInMap("updated")
        public String updated;

        public static SeachTaskStageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SeachTaskStageResponseBodyResult self = new SeachTaskStageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SeachTaskStageResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SeachTaskStageResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SeachTaskStageResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public SeachTaskStageResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SeachTaskStageResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public SeachTaskStageResponseBodyResult setTaskListId(String taskListId) {
            this.taskListId = taskListId;
            return this;
        }
        public String getTaskListId() {
            return this.taskListId;
        }

        public SeachTaskStageResponseBodyResult setTaskStageId(String taskStageId) {
            this.taskStageId = taskStageId;
            return this;
        }
        public String getTaskStageId() {
            return this.taskStageId;
        }

        public SeachTaskStageResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
