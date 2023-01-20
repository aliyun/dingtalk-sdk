// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAdministrativeLicensingResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>LicenseNo:许可文件编号</p>
     * <p>LicenseName:许可文件名称</p>
     * <p>Department:许可机关</p>
     * <p>StartDate:有效期自</p>
     * <p>EndDate:有效期至</p>
     * <p>Content:许可内容</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
