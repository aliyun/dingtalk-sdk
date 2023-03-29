// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUpdateAuthInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DigitalStoreUpdateAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUpdateAuthInfoResponseBody self = new DigitalStoreUpdateAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUpdateAuthInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
