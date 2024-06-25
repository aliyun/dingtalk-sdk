// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSoftwareCopyrightResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[{ &quot;EntName:企业名称&quot;, &quot;CopyNum:登记号&quot;, &quot;TypeNum:分类号&quot;, &quot;ShortName:作品简称&quot;, &quot;CopyName:作品全称&quot;, &quot;Version:版本号&quot;, &quot;SuccessDate:创作完成日期&quot;, &quot;FirstDate:首次发表日期&quot;, &quot;ApprovalDate:登记批准日期&quot; }]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetSoftwareCopyrightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSoftwareCopyrightResponseBody self = new GetSoftwareCopyrightResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSoftwareCopyrightResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetSoftwareCopyrightResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
