// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetServiceInvocationResponseBody extends TeaModel {
    @NameInMap("completedAt")
    public String completedAt;

    @NameInMap("createdAt")
    public String createdAt;

    @NameInMap("deviceName")
    public String deviceName;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("identifier")
    public String identifier;

    @NameInMap("invocationId")
    public String invocationId;

    @NameInMap("outputData")
    public java.util.Map<String, ?> outputData;

    @NameInMap("processingTimeMs")
    public Long processingTimeMs;

    @NameInMap("productKey")
    public String productKey;

    @NameInMap("status")
    public String status;

    public static GetServiceInvocationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetServiceInvocationResponseBody self = new GetServiceInvocationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetServiceInvocationResponseBody setCompletedAt(String completedAt) {
        this.completedAt = completedAt;
        return this;
    }
    public String getCompletedAt() {
        return this.completedAt;
    }

    public GetServiceInvocationResponseBody setCreatedAt(String createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public String getCreatedAt() {
        return this.createdAt;
    }

    public GetServiceInvocationResponseBody setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

    public GetServiceInvocationResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public GetServiceInvocationResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public GetServiceInvocationResponseBody setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public GetServiceInvocationResponseBody setInvocationId(String invocationId) {
        this.invocationId = invocationId;
        return this;
    }
    public String getInvocationId() {
        return this.invocationId;
    }

    public GetServiceInvocationResponseBody setOutputData(java.util.Map<String, ?> outputData) {
        this.outputData = outputData;
        return this;
    }
    public java.util.Map<String, ?> getOutputData() {
        return this.outputData;
    }

    public GetServiceInvocationResponseBody setProcessingTimeMs(Long processingTimeMs) {
        this.processingTimeMs = processingTimeMs;
        return this;
    }
    public Long getProcessingTimeMs() {
        return this.processingTimeMs;
    }

    public GetServiceInvocationResponseBody setProductKey(String productKey) {
        this.productKey = productKey;
        return this;
    }
    public String getProductKey() {
        return this.productKey;
    }

    public GetServiceInvocationResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
