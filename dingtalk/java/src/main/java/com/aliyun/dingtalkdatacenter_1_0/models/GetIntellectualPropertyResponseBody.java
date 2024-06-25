// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetIntellectualPropertyResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;Status&quot;: &quot;有效&quot;,       &quot;Type&quot;: &quot;专利&quot;,       &quot;Pledgor&quot;: &quot;齐风莲&quot;,       &quot;Number&quot;: &quot;91611024MA70X17M7E&quot;,       &quot;Period&quot;: &quot;2015年06月11日至2015年06月11日&quot;,       &quot;PublicDate&quot;: &quot;2015-06-18 00:00:00&quot;,       &quot;Pawnee&quot;: &quot;齐风莲&quot;,       &quot;entName&quot;: &quot;东兰县鸿发摩托车安全技术检验有限公司&quot;     }   ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetIntellectualPropertyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetIntellectualPropertyResponseBody self = new GetIntellectualPropertyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetIntellectualPropertyResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetIntellectualPropertyResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
