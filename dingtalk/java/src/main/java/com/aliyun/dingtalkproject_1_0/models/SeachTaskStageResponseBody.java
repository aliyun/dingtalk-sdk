// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SeachTaskStageResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<SeachTaskStageResponseBodyResult> result;

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

    public static class SeachTaskStageResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>0715153011125xxxx</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>描述...</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>自定义列1</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>62c25e3b376ecxxxxxxx</p>
         */
        @NameInMap("projectId")
        public String projectId;

        /**
         * <strong>example:</strong>
         * <p>60a2187eb72xxxxxxx</p>
         */
        @NameInMap("taskListId")
        public String taskListId;

        /**
         * <strong>example:</strong>
         * <p>60a2187eb72xxxxxxx</p>
         */
        @NameInMap("taskStageId")
        public String taskStageId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
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
