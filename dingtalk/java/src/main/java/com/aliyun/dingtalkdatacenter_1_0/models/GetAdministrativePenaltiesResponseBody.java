// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativePenaltiesResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;DATE_COL&quot;: &quot;xx&quot;,       &quot;NUMBER&quot;: &quot;xx&quot;,       &quot;ILLEGAL_TYPE&quot;: &quot;xx&quot;,       &quot;DEPARTMENT&quot;: &quot;xx&quot;,       &quot;PUBLIC_DATE&quot;: &quot;xx&quot;,       &quot;CONTENT&quot;: &quot;xx&quot;,       &quot;BASED_ON&quot;:&quot;xx&quot;,       &quot;DESCRIPTION&quot;:&quot;xx&quot;      }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetAdministrativePenaltiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAdministrativePenaltiesResponseBody self = new GetAdministrativePenaltiesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAdministrativePenaltiesResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetAdministrativePenaltiesResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
