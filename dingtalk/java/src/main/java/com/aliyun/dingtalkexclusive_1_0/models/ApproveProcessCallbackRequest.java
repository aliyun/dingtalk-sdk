// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ApproveProcessCallbackRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sampleKeyId1234</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sampleSecretId1234</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("request")
    public ApproveProcessCallbackRequestRequest request;

    /**
     * <strong>example:</strong>
     * <p>dingxxxxxxxxxxxx</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static ApproveProcessCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        ApproveProcessCallbackRequest self = new ApproveProcessCallbackRequest();
        return TeaModel.build(map, self);
    }

    public ApproveProcessCallbackRequest setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public ApproveProcessCallbackRequest setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public ApproveProcessCallbackRequest setRequest(ApproveProcessCallbackRequestRequest request) {
        this.request = request;
        return this;
    }
    public ApproveProcessCallbackRequestRequest getRequest() {
        return this.request;
    }

    public ApproveProcessCallbackRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public static class ApproveProcessCallbackRequestRequest extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>agree</p>
         */
        @NameInMap("approveResult")
        public String approveResult;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("approveType")
        public String approveType;

        @NameInMap("approvers")
        public java.util.List<String> approvers;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1495592259000</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>approve_open_group_expansion</p>
         */
        @NameInMap("eventType")
        public String eventType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1495592259000</p>
         */
        @NameInMap("finishTime")
        public Long finishTime;

        @NameInMap("params")
        public String params;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("title")
        public String title;

        public static ApproveProcessCallbackRequestRequest build(java.util.Map<String, ?> map) throws Exception {
            ApproveProcessCallbackRequestRequest self = new ApproveProcessCallbackRequestRequest();
            return TeaModel.build(map, self);
        }

        public ApproveProcessCallbackRequestRequest setApproveResult(String approveResult) {
            this.approveResult = approveResult;
            return this;
        }
        public String getApproveResult() {
            return this.approveResult;
        }

        public ApproveProcessCallbackRequestRequest setApproveType(String approveType) {
            this.approveType = approveType;
            return this;
        }
        public String getApproveType() {
            return this.approveType;
        }

        public ApproveProcessCallbackRequestRequest setApprovers(java.util.List<String> approvers) {
            this.approvers = approvers;
            return this;
        }
        public java.util.List<String> getApprovers() {
            return this.approvers;
        }

        public ApproveProcessCallbackRequestRequest setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public ApproveProcessCallbackRequestRequest setEventType(String eventType) {
            this.eventType = eventType;
            return this;
        }
        public String getEventType() {
            return this.eventType;
        }

        public ApproveProcessCallbackRequestRequest setFinishTime(Long finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public Long getFinishTime() {
            return this.finishTime;
        }

        public ApproveProcessCallbackRequestRequest setParams(String params) {
            this.params = params;
            return this;
        }
        public String getParams() {
            return this.params;
        }

        public ApproveProcessCallbackRequestRequest setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public ApproveProcessCallbackRequestRequest setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
