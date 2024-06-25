// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativeLicensingResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;LicenseNo&quot;: &quot;梯4403331978&quot;,       &quot;StartDate&quot;: &quot;2022-05-10&quot;,       &quot;Department&quot;: &quot;深圳市市场监督管理局&quot;,       &quot;Content&quot;: &quot;注册代码:7;设备种类:电梯&quot;,       &quot;LicenseName&quot;: &quot;特种设备使用登记&quot;,       &quot;EndDate&quot;: &quot;2099-12-31&quot;     },     {       &quot;LicenseNo&quot;: &quot;东水务审﹝2021﹞8267号&quot;,       &quot;StartDate&quot;: &quot;2021-06-11&quot;,       &quot;Department&quot;: &quot;东莞市水务局&quot;,       &quot;Content&quot;: &quot;水土保持方案审批准予行政许可决定&quot;,       &quot;LicenseName&quot;: &quot;&quot;,       &quot;EndDate&quot;: &quot;2026-12-31&quot;     } ]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetAdministrativeLicensingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAdministrativeLicensingResponseBody self = new GetAdministrativeLicensingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAdministrativeLicensingResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetAdministrativeLicensingResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
