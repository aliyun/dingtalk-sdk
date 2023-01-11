// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspaceDocsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<BatchGetWorkspaceDocsResponseBodyResult> result;

    public static BatchGetWorkspaceDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspaceDocsResponseBody self = new BatchGetWorkspaceDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspaceDocsResponseBody setResult(java.util.List<BatchGetWorkspaceDocsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<BatchGetWorkspaceDocsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class BatchGetWorkspaceDocsResponseBodyResultNodeBO extends TeaModel {
        @NameInMap("deleted")
        public Boolean deleted;

        /**
         * <p>节点类型</p>
         */
        @NameInMap("docType")
        public String docType;

        /**
         * <p>最后编辑时间</p>
         */
        @NameInMap("lastEditTime")
        public Long lastEditTime;

        @NameInMap("name")
        public String name;

        @NameInMap("nodeId")
        public String nodeId;

        @NameInMap("url")
        public String url;

        public static BatchGetWorkspaceDocsResponseBodyResultNodeBO build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspaceDocsResponseBodyResultNodeBO self = new BatchGetWorkspaceDocsResponseBodyResultNodeBO();
            return TeaModel.build(map, self);
        }

        public BatchGetWorkspaceDocsResponseBodyResultNodeBO setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

        public BatchGetWorkspaceDocsResponseBodyResultNodeBO setDocType(String docType) {
            this.docType = docType;
            return this;
        }
        public String getDocType() {
            return this.docType;
        }

        public BatchGetWorkspaceDocsResponseBodyResultNodeBO setLastEditTime(Long lastEditTime) {
            this.lastEditTime = lastEditTime;
            return this;
        }
        public Long getLastEditTime() {
            return this.lastEditTime;
        }

        public BatchGetWorkspaceDocsResponseBodyResultNodeBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchGetWorkspaceDocsResponseBodyResultNodeBO setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public BatchGetWorkspaceDocsResponseBodyResultNodeBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("workspaceId")
        public String workspaceId;

        public static BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO self = new BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO();
            return TeaModel.build(map, self);
        }

        public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

    public static class BatchGetWorkspaceDocsResponseBodyResult extends TeaModel {
        @NameInMap("hasPermission")
        public Boolean hasPermission;

        @NameInMap("nodeBO")
        public BatchGetWorkspaceDocsResponseBodyResultNodeBO nodeBO;

        @NameInMap("workspaceBO")
        public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO workspaceBO;

        public static BatchGetWorkspaceDocsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspaceDocsResponseBodyResult self = new BatchGetWorkspaceDocsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchGetWorkspaceDocsResponseBodyResult setHasPermission(Boolean hasPermission) {
            this.hasPermission = hasPermission;
            return this;
        }
        public Boolean getHasPermission() {
            return this.hasPermission;
        }

        public BatchGetWorkspaceDocsResponseBodyResult setNodeBO(BatchGetWorkspaceDocsResponseBodyResultNodeBO nodeBO) {
            this.nodeBO = nodeBO;
            return this;
        }
        public BatchGetWorkspaceDocsResponseBodyResultNodeBO getNodeBO() {
            return this.nodeBO;
        }

        public BatchGetWorkspaceDocsResponseBodyResult setWorkspaceBO(BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO workspaceBO) {
            this.workspaceBO = workspaceBO;
            return this;
        }
        public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO getWorkspaceBO() {
            return this.workspaceBO;
        }

    }

}
