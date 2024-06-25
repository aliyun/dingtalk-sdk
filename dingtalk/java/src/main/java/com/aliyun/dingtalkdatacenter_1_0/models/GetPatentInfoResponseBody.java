// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetPatentInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[{&quot;EntName&quot;:&quot;企业名称&quot;, &quot;PatentType&quot;:&quot;专利类型&quot;, &quot;PatentName&quot;:&quot;专利名&quot;, &quot;PatentStatus&quot;:&quot;专利状态&quot;, &quot;RequestNum&quot;:&quot;申请号&quot;, &quot;RequestDate&quot;:&quot;申请日&quot;, &quot;PublicNum&quot;:&quot;公开(公告)号&quot;, &quot;PublicDate&quot;:&quot;公开(公告)日&quot;, &quot;InventorList&quot;:&quot;发明人&quot;, &quot;PatenteeList&quot;:&quot;专利权人&quot;, &quot;CateNum&quot;:&quot;分类号&quot;, &quot;PrioNum&quot;:&quot;优先权号&quot;, &quot;PrioDate&quot;:&quot;优先权日&quot;, &quot;Agency&quot;:&quot;专利代理机构&quot;, &quot;Agent&quot;:&quot;代理人&quot;, &quot;Brief&quot;:&quot;简要说明&quot;, &quot;MainClaim&quot;:&quot;主权项&quot;}]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetPatentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPatentInfoResponseBody self = new GetPatentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPatentInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetPatentInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
