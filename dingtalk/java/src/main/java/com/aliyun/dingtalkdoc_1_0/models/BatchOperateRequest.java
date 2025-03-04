// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchOperateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>requests</p>
     */
    @NameInMap("requests")
    public java.util.List<BatchOperateRequestRequests> requests;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static BatchOperateRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchOperateRequest self = new BatchOperateRequest();
        return TeaModel.build(map, self);
    }

    public BatchOperateRequest setRequests(java.util.List<BatchOperateRequestRequests> requests) {
        this.requests = requests;
        return this;
    }
    public java.util.List<BatchOperateRequestRequests> getRequests() {
        return this.requests;
    }

    public BatchOperateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class BatchOperateRequestRequests extends TeaModel {
        @NameInMap("body")
        public Object body;

        @NameInMap("method")
        public String method;

        @NameInMap("path")
        public String path;

        public static BatchOperateRequestRequests build(java.util.Map<String, ?> map) throws Exception {
            BatchOperateRequestRequests self = new BatchOperateRequestRequests();
            return TeaModel.build(map, self);
        }

        public BatchOperateRequestRequests setBody(Object body) {
            this.body = body;
            return this;
        }
        public Object getBody() {
            return this.body;
        }

        public BatchOperateRequestRequests setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public BatchOperateRequestRequests setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

    }

}
