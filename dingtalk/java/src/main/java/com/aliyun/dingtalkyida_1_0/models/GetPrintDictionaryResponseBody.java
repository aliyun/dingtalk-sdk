// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPrintDictionaryResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("result")
    public String result;

    public static GetPrintDictionaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrintDictionaryResponseBody self = new GetPrintDictionaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrintDictionaryResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
