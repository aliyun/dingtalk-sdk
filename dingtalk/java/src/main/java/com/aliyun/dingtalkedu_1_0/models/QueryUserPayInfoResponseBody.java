// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUserPayInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("signNo")
    public String signNo;

    public static QueryUserPayInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserPayInfoResponseBody self = new QueryUserPayInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserPayInfoResponseBody setSignNo(String signNo) {
        this.signNo = signNo;
        return this;
    }
    public String getSignNo() {
        return this.signNo;
    }

}
