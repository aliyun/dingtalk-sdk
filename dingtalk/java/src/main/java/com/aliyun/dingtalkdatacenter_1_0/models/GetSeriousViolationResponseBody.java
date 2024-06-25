// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSeriousViolationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;IN_DATE&quot;: &quot;xx&quot;,       &quot;IN_DEPARTMENT&quot;: &quot;xx&quot;,       &quot;IN_REASON&quot;: &quot;xx&quot;      }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetSeriousViolationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSeriousViolationResponseBody self = new GetSeriousViolationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSeriousViolationResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetSeriousViolationResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
