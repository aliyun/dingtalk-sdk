// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class ExtractFacialFeatureResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ExtractFacialFeatureResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExtractFacialFeatureResponseBody self = new ExtractFacialFeatureResponseBody();
        return TeaModel.build(map, self);
    }

    public ExtractFacialFeatureResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
