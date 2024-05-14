// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFileUploadUrlResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileId")
    public String fileId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("uploadUrl")
    public String uploadUrl;

    public static GetFileUploadUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadUrlResponseBody self = new GetFileUploadUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileUploadUrlResponseBody setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public GetFileUploadUrlResponseBody setUploadUrl(String uploadUrl) {
        this.uploadUrl = uploadUrl;
        return this;
    }
    public String getUploadUrl() {
        return this.uploadUrl;
    }

}
