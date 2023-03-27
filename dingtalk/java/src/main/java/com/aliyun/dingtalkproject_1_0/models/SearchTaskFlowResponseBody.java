// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskFlowResponseBody extends TeaModel {
    /**
     * <p>工作流列表。</p>
     */
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
         * <p>绑定对象Id，此接口为项目id。</p>
         */
        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        /**
         * <p>绑定类型，增加项目成员默认是project。</p>
         */
        @NameInMap("boundToObjectType")
        public String boundToObjectType;

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
         * <p>是否已删除。</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <p>工作流名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>工作流ID。</p>
         */
        @NameInMap("taskflowId")
        public String taskflowId;

        /**
         * <p>更新时间。</p>
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
