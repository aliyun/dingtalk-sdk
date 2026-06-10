// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class PrepareImportUploadResponseBody extends TeaModel {
    @NameInMap("expireAt")
    public Long expireAt;

    @NameInMap("importId")
    public String importId;

    @NameInMap("uploadUrl")
    public String uploadUrl;

    public static PrepareImportUploadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PrepareImportUploadResponseBody self = new PrepareImportUploadResponseBody();
        return TeaModel.build(map, self);
    }

    public PrepareImportUploadResponseBody setExpireAt(Long expireAt) {
        this.expireAt = expireAt;
        return this;
    }
    public Long getExpireAt() {
        return this.expireAt;
    }

    public PrepareImportUploadResponseBody setImportId(String importId) {
        this.importId = importId;
        return this;
    }
    public String getImportId() {
        return this.importId;
    }

    public PrepareImportUploadResponseBody setUploadUrl(String uploadUrl) {
        this.uploadUrl = uploadUrl;
        return this;
    }
    public String getUploadUrl() {
        return this.uploadUrl;
    }

}
