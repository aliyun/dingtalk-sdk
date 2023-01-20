// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDomainInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称</p>
     * <p>Number:备案号</p>
     * <p>Domain:域名</p>
     * <p>SiteName:网站名称</p>
     * <p>HomeUrl:网站首页链接</p>
     * <p>CheckDate:备案日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
