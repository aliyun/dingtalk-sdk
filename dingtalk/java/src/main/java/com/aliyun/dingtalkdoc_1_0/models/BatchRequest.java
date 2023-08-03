// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchRequest extends TeaModel {
    @NameInMap("requests")
    public java.util.List<BatchRequestRequests> requests;

    @NameInMap("operatorId")
    public String operatorId;

    public static BatchRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRequest self = new BatchRequest();
        return TeaModel.build(map, self);
    }

    public BatchRequest setRequests(java.util.List<BatchRequestRequests> requests) {
        this.requests = requests;
        return this;
    }
    public java.util.List<BatchRequestRequests> getRequests() {
        return this.requests;
    }

    public BatchRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class BatchRequestRequests extends TeaModel {
        @NameInMap("body")
        public Object body;

        @NameInMap("method")
        public String method;

        @NameInMap("path")
        public String path;

        public static BatchRequestRequests build(java.util.Map<String, ?> map) throws Exception {
            BatchRequestRequests self = new BatchRequestRequests();
            return TeaModel.build(map, self);
        }

        public BatchRequestRequests setBody(Object body) {
            this.body = body;
            return this;
        }
        public Object getBody() {
            return this.body;
        }

        public BatchRequestRequests setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public BatchRequestRequests setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

    }

}
