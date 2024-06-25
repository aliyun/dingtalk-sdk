// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetJobInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;DEPARTMENT&quot;: &quot;xx&quot;,       &quot;IN_REASON&quot;: &quot;xx&quot;,       &quot;OUT_DATE&quot;: &quot;2006-12-07&quot;,       &quot;OUT_DEPARTMENT&quot;: &quot;xx&quot;,       &quot;IN_DATE&quot;: &quot;2006-12-07&quot;,       &quot;OUT_REASON&quot;: &quot;xx&quot;     }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetJobInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetJobInfoResponseBody self = new GetJobInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetJobInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetJobInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
