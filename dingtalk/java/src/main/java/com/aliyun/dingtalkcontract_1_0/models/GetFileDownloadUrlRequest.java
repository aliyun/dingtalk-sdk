// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadUrlRequest extends TeaModel {
    @NameInMap("bizFlowId")
    public String bizFlowId;

    @NameInMap("fileId")
    public String fileId;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("signFlowId")
    public String signFlowId;

    public static GetFileDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadUrlRequest self = new GetFileDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadUrlRequest setBizFlowId(String bizFlowId) {
        this.bizFlowId = bizFlowId;
        return this;
    }
    public String getBizFlowId() {
        return this.bizFlowId;
    }

    public GetFileDownloadUrlRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public GetFileDownloadUrlRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetFileDownloadUrlRequest setSignFlowId(String signFlowId) {
        this.signFlowId = signFlowId;
        return this;
    }
    public String getSignFlowId() {
        return this.signFlowId;
    }

}
