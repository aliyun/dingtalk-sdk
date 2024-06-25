// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskListResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<SearchTaskListResponseBodyResult> result;

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

    public static class SearchTaskListResponseBodyResult extends TeaModel {
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
         * <p>自定义分组1</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
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

        public SearchTaskListResponseBodyResult setTaskListId(String taskListId) {
            this.taskListId = taskListId;
            return this;
        }
        public String getTaskListId() {
            return this.taskListId;
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
