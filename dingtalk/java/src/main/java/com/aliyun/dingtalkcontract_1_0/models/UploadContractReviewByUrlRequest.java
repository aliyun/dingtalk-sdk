// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UploadContractReviewByUrlRequest extends TeaModel {
    @NameInMap("file_url")
    public String fileUrl;

    @NameInMap("filename")
    public String filename;

    @NameInMap("session_id")
    public String sessionId;

    public static UploadContractReviewByUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadContractReviewByUrlRequest self = new UploadContractReviewByUrlRequest();
        return TeaModel.build(map, self);
    }

    public UploadContractReviewByUrlRequest setFileUrl(String fileUrl) {
        this.fileUrl = fileUrl;
        return this;
    }
    public String getFileUrl() {
        return this.fileUrl;
    }

    public UploadContractReviewByUrlRequest setFilename(String filename) {
        this.filename = filename;
        return this;
    }
    public String getFilename() {
        return this.filename;
    }

    public UploadContractReviewByUrlRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

}
