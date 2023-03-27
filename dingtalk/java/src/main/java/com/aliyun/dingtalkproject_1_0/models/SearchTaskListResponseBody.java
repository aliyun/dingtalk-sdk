// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskListResponseBody extends TeaModel {
    /**
     * <p>分页标，供分页使用，下一页token。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>任务分0组列表。</p>
     */
    @NameInMap("result")
    public java.util.List<SearchTaskListResponseBodyResult> result;

    /**
     * <p>总数。</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static SearchTaskListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskListResponseBody self = new SearchTaskListResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchTaskListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchTaskListResponseBody setResult(java.util.List<SearchTaskListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchTaskListResponseBodyResult> getResult() {
        return this.result;
    }

    public SearchTaskListResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class SearchTaskListResponseBodyResult extends TeaModel {
        /**
         * <p>创建时间。</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建者用户ID。</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>任务分组名称。</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>项目ID。</p>
         */
        @NameInMap("projectId")
        public String projectId;

        /**
         * <p>任务分组ID。</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <p>任务分组名称。</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>更新时间。</p>
         */
        @NameInMap("updated")
        public String updated;

        public static SearchTaskListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchTaskListResponseBodyResult self = new SearchTaskListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchTaskListResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchTaskListResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchTaskListResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public SearchTaskListResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public SearchTaskListResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public SearchTaskListResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchTaskListResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
