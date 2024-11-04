// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteDataServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SmartQuoteDataServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteDataServiceResponseBody self = new SmartQuoteDataServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SmartQuoteDataServiceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
