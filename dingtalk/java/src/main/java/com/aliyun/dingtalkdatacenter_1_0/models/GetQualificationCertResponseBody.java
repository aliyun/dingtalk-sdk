// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQualificationCertResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[{&quot;EntName&quot;:&quot;企业名称&quot;, &quot;CertType&quot;:&quot;证书类型&quot;, &quot;CertNum&quot;:&quot;证书认证编号&quot;, &quot;ValidStartDate&quot;:&quot;有效期开始日期&quot;, &quot;ValidEndDate&quot;:&quot;有效期截止日期&quot;, &quot;AuthorizeDate&quot;:&quot;授权日期&quot;, &quot;AuthorizeDepartment&quot;:&quot;授权部门&quot;, &quot;PubDate&quot;:&quot;公示日期&quot;, &quot;Province&quot;:&quot;省份&quot;, &quot;CertScope&quot;:&quot;认证范围&quot;} ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetQualificationCertResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetQualificationCertResponseBody self = new GetQualificationCertResponseBody();
        return TeaModel.build(map, self);
    }

    public GetQualificationCertResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetQualificationCertResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
