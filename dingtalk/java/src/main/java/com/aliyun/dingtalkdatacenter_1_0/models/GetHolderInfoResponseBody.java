// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetHolderInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;STOCK_TYPE&quot;: &quot;企业法人&quot;,       &quot;STOCK_NAME&quot;: &quot;xxx&quot;,       &quot;STOCK_PERCENT&quot;: &quot;100.00%&quot;,       &quot;SHOULD_CAPI&quot;: &quot;1000.0&quot;,       &quot;SHOULD_CAPI_TIME&quot;: &quot;2007-09-28&quot;     }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetHolderInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetHolderInfoResponseBody self = new GetHolderInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetHolderInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetHolderInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
