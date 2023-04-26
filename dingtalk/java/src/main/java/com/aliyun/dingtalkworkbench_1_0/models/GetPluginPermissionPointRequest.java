// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetPluginPermissionPointRequest extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    public static GetPluginPermissionPointRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPluginPermissionPointRequest self = new GetPluginPermissionPointRequest();
        return TeaModel.build(map, self);
    }

    public GetPluginPermissionPointRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
