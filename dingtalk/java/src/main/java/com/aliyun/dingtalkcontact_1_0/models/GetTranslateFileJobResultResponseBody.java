// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetTranslateFileJobResultResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("url")
    public String url;

    public static GetTranslateFileJobResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTranslateFileJobResultResponseBody self = new GetTranslateFileJobResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTranslateFileJobResultResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetTranslateFileJobResultResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
