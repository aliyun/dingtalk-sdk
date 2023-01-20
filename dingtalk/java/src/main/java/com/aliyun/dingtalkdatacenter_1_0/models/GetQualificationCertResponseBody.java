// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQualificationCertResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称</p>
     * <p>CertType:证书类型</p>
     * <p>CertNum:证书认证编号</p>
     * <p>ValidStartDate:有效期开始日期</p>
     * <p>ValidEndDate:有效期截止日期</p>
     * <p>AuthorizeDate:授权日期</p>
     * <p>AuthorizeDepartment:授权部门</p>
     * <p>PubDate:公示日期</p>
     * <p>Province:省份</p>
     * <p>CertScope:认证范围</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
