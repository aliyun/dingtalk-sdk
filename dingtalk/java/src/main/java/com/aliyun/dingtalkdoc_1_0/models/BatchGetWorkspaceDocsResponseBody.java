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
        @NameInMap("name")
        public String name;

        @NameInMap("nodeId")
        public String nodeId;

        @NameInMap("url")
        public String url;

        @NameInMap("deleted")
        public Boolean deleted;

        public static BatchGetWorkspaceDocsResponseBodyResultNodeBO build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspaceDocsResponseBodyResultNodeBO self = new BatchGetWorkspaceDocsResponseBodyResultNodeBO();
            return TeaModel.build(map, self);
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

        public BatchGetWorkspaceDocsResponseBodyResultNodeBO setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

    }

    public static class BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO extends TeaModel {
        @NameInMap("workspaceId")
        public String workspaceId;

        @NameInMap("name")
        public String name;

        public static BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO self = new BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO();
            return TeaModel.build(map, self);
        }

        public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class BatchGetWorkspaceDocsResponseBodyResult extends TeaModel {
        @NameInMap("nodeBO")
        public BatchGetWorkspaceDocsResponseBodyResultNodeBO nodeBO;

        @NameInMap("workspaceBO")
        public BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO workspaceBO;

        @NameInMap("hasPermission")
        public Boolean hasPermission;

        public static BatchGetWorkspaceDocsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchGetWorkspaceDocsResponseBodyResult self = new BatchGetWorkspaceDocsResponseBodyResult();
            return TeaModel.build(map, self);
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

        public BatchGetWorkspaceDocsResponseBodyResult setHasPermission(Boolean hasPermission) {
            this.hasPermission = hasPermission;
            return this;
        }
        public Boolean getHasPermission() {
            return this.hasPermission;
        }

    }

}
