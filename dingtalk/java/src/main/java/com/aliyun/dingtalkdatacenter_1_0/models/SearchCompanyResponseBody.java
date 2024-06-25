// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class SearchCompanyResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;ENT_NAME&quot;: &quot;xx&quot;,       &quot;SOCIAL_CREDIT_CODE&quot;: &quot;xx&quot;,       &quot;LICENSE_NUMBER&quot;: &quot;xx&quot;,       &quot;REG_CAP&quot;: &quot;10000000.0&quot;,       &quot;ES_DATE&quot;: &quot;2006-12-07&quot;,       &quot;LEGAL_NAME&quot;: &quot;xx&quot;,       &quot;ORG_NO&quot;: &quot;xx&quot;,       &quot;TAX_NUM&quot;: &quot;xx&quot;,       &quot;ENT_STATUS&quot;: &quot;在营&quot;     }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static SearchCompanyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchCompanyResponseBody self = new SearchCompanyResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchCompanyResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public SearchCompanyResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
