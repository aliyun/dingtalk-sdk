// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskFlowResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SearchTaskFlowResponseBodyResult> result;

    public static SearchTaskFlowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskFlowResponseBody self = new SearchTaskFlowResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchTaskFlowResponseBody setResult(java.util.List<SearchTaskFlowResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchTaskFlowResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SearchTaskFlowResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>62c25e3b376ecxxxxxxx</p>
         */
        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        /**
         * <strong>example:</strong>
         * <p>project</p>
         */
        @NameInMap("boundToObjectType")
        public String boundToObjectType;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>07151530111xxxxx</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <strong>example:</strong>
         * <p>工作流1</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>60a2187eb72xxxxxxx</p>
         */
        @NameInMap("taskflowId")
        public String taskflowId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static SearchTaskFlowResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchTaskFlowResponseBodyResult self = new SearchTaskFlowResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchTaskFlowResponseBodyResult setBoundToObjectId(String boundToObjectId) {
            this.boundToObjectId = boundToObjectId;
            return this;
        }
        public String getBoundToObjectId() {
            return this.boundToObjectId;
        }

        public SearchTaskFlowResponseBodyResult setBoundToObjectType(String boundToObjectType) {
            this.boundToObjectType = boundToObjectType;
            return this;
        }
        public String getBoundToObjectType() {
            return this.boundToObjectType;
        }

        public SearchTaskFlowResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchTaskFlowResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchTaskFlowResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public SearchTaskFlowResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchTaskFlowResponseBodyResult setTaskflowId(String taskflowId) {
            this.taskflowId = taskflowId;
            return this;
        }
        public String getTaskflowId() {
            return this.taskflowId;
        }

        public SearchTaskFlowResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
