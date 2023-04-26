// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateMiniAppResponseBody extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    public static CreateMiniAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMiniAppResponseBody self = new CreateMiniAppResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMiniAppResponseBody setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
