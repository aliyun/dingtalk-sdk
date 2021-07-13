// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class InvokeHtmlBundleBuildResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static InvokeHtmlBundleBuildResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InvokeHtmlBundleBuildResponseBody self = new InvokeHtmlBundleBuildResponseBody();
        return TeaModel.build(map, self);
    }

    public InvokeHtmlBundleBuildResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
