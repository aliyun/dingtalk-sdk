// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetSettingByMiniAppIdResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static GetSettingByMiniAppIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSettingByMiniAppIdResponseBody self = new GetSettingByMiniAppIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSettingByMiniAppIdResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
