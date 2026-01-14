// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ActivateMcpResponseBody extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("jsonConfig")
    public String jsonConfig;

    @NameInMap("url")
    public String url;

    public static ActivateMcpResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ActivateMcpResponseBody self = new ActivateMcpResponseBody();
        return TeaModel.build(map, self);
    }

    public ActivateMcpResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public ActivateMcpResponseBody setJsonConfig(String jsonConfig) {
        this.jsonConfig = jsonConfig;
        return this;
    }
    public String getJsonConfig() {
        return this.jsonConfig;
    }

    public ActivateMcpResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
