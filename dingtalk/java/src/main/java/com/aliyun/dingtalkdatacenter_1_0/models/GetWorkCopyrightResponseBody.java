// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetWorkCopyrightResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[{ &quot;EntName&quot;:&quot;企业名称&quot;, &quot;CopyName&quot;:&quot;作品全称&quot;, &quot;TypeName&quot;:&quot;作品类别&quot;, &quot;CopyNum&quot;:&quot;登记号&quot;, &quot;SuccessDate&quot;:&quot;创作完成日期&quot;, &quot;FirstDate&quot;:&quot;首次发表日期&quot;, &quot;ApprovalDate&quot;:&quot;登记批准日期&quot; }]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetWorkCopyrightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkCopyrightResponseBody self = new GetWorkCopyrightResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkCopyrightResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetWorkCopyrightResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
