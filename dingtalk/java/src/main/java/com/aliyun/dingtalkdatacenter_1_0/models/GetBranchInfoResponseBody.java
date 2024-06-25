// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBranchInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;OperName&quot;: &quot;李柯&quot;,       &quot;EntStatus&quot;: &quot;&quot;,       &quot;EntName&quot;: &quot;华为技术有限公司驻广州办事处&quot;,       &quot;EsDate&quot;: &quot;&quot;     },     {       &quot;OperName&quot;: &quot;李实&quot;,       &quot;EntStatus&quot;: &quot;&quot;,       &quot;EntName&quot;: &quot;华为技术有限公司重庆分公司&quot;,       &quot;EsDate&quot;: &quot;&quot;     } ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetBranchInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBranchInfoResponseBody self = new GetBranchInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBranchInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetBranchInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
