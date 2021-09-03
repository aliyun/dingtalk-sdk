// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetTranslateFileJobResultResponseBody extends TeaModel {
    // 0 任务进行中 1 任务处理成功 2 任务处理失败
    @NameInMap("status")
    public String status;

    // 文件内容转译成功后的url，需要用户通过oauth2授权登录在用户侧打开
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
