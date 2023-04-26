// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateVersionAcrossBundleResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static CreateVersionAcrossBundleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateVersionAcrossBundleResponseBody self = new CreateVersionAcrossBundleResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateVersionAcrossBundleResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
