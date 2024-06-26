// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAlipayAccountResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2088894773487</p>
     */
    @NameInMap("alipayUid")
    public String alipayUid;

    public static QueryUserAlipayAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserAlipayAccountResponseBody self = new QueryUserAlipayAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserAlipayAccountResponseBody setAlipayUid(String alipayUid) {
        this.alipayUid = alipayUid;
        return this;
    }
    public String getAlipayUid() {
        return this.alipayUid;
    }

}
