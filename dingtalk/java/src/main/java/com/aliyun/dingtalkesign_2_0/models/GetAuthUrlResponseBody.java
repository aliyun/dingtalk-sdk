// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetAuthUrlResponseBody extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    @NameInMap("pcUrl")
    public String pcUrl;

    @NameInMap("mobileUrl")
    public String mobileUrl;

    public static GetAuthUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAuthUrlResponseBody self = new GetAuthUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAuthUrlResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetAuthUrlResponseBody setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public GetAuthUrlResponseBody setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

}
