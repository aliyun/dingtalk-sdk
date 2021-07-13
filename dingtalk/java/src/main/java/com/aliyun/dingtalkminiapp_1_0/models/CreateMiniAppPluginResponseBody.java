// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateMiniAppPluginResponseBody extends TeaModel {
    // result
    @NameInMap("miniAppId")
    public String miniAppId;

    public static CreateMiniAppPluginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMiniAppPluginResponseBody self = new CreateMiniAppPluginResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMiniAppPluginResponseBody setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
