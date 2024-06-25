// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDomainInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[{ &quot;EntName&quot;:&quot;企业名称&quot; &quot;Number&quot;:&quot;备案号&quot; &quot;Domain&quot;:&quot;域名&quot; &quot;SiteName&quot;:&quot;网站名称&quot; &quot;HomeUrl&quot;:&quot;网站首页链接&quot; &quot;CheckDate&quot;:&quot;备案日期&quot; }]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetDomainInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDomainInfoResponseBody self = new GetDomainInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDomainInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetDomainInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
