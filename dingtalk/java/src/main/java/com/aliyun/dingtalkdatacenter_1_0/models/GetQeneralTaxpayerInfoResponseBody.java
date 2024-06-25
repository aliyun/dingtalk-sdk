// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQeneralTaxpayerInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;DEPARTMENT&quot;:&quot;xx&quot;       &quot;END_DATE&quot;:&quot;2017-01-04&quot;       &quot;ENT_NAME&quot;:&quot;xx&quot;       &quot;QUALIFICATION&quot;       &quot;START_DATE&quot;:&quot;2017-01-04&quot;       &quot;TAXPAYER_NUM&quot;:&quot;11&quot;       &quot;JUDGE_DATE&quot;:&quot;2017-05-04&quot;      }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetQeneralTaxpayerInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetQeneralTaxpayerInfoResponseBody self = new GetQeneralTaxpayerInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetQeneralTaxpayerInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetQeneralTaxpayerInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
