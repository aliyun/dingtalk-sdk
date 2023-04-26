// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetOpenUrlRequest extends TeaModel {
    @NameInMap("fileUrl")
    public String fileUrl;

    @NameInMap("language")
    public String language;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("timeout")
    public Long timeout;

    @NameInMap("userId")
    public String userId;

    public static GetOpenUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOpenUrlRequest self = new GetOpenUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetOpenUrlRequest setFileUrl(String fileUrl) {
        this.fileUrl = fileUrl;
        return this;
    }
    public String getFileUrl() {
        return this.fileUrl;
    }

    public GetOpenUrlRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetOpenUrlRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetOpenUrlRequest setTimeout(Long timeout) {
        this.timeout = timeout;
        return this;
    }
    public Long getTimeout() {
        return this.timeout;
    }

    public GetOpenUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
