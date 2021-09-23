// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchEmployeeFieldValuesResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static SearchEmployeeFieldValuesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchEmployeeFieldValuesResponseBody self = new SearchEmployeeFieldValuesResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchEmployeeFieldValuesResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
