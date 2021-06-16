// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetPluginRuleCheckInfoRequest extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    public static GetPluginRuleCheckInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPluginRuleCheckInfoRequest self = new GetPluginRuleCheckInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPluginRuleCheckInfoRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
