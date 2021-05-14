// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetWebChannelUserTokenResponseBody extends TeaModel {
    // 返回结果
    @NameInMap("result")
    public String result;

    public static GetWebChannelUserTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWebChannelUserTokenResponseBody self = new GetWebChannelUserTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWebChannelUserTokenResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
