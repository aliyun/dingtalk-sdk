// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEnvironmentalPenaltiesResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;DEPARTMENT&quot;: &quot;xx&quot;,       &quot;ENT_NAME&quot;: &quot;xx&quot;,       &quot;EXEC_STATUS&quot;: &quot;xx&quot;,       &quot;PUNISH_BASIS&quot;: &quot;xx&quot;,       &quot;PUNISH_CONTENT&quot;: &quot;xx&quot;,       &quot;PUNISH_LAW&quot;: &quot;xx&quot;,       &quot;PUNISH_NUM&quot;: &quot;xx&quot;,       &quot;PUNISH_RES&quot;: &quot;xx&quot;,       &quot;PUNISH_DATE&quot;: &quot;xx&quot;      }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetEnvironmentalPenaltiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEnvironmentalPenaltiesResponseBody self = new GetEnvironmentalPenaltiesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEnvironmentalPenaltiesResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetEnvironmentalPenaltiesResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
