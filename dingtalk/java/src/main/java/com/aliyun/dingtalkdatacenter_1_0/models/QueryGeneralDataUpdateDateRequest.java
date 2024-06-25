// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataUpdateDateRequest extends TeaModel {
    @NameInMap("serviceId")
    public String serviceId;

    public static QueryGeneralDataUpdateDateRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataUpdateDateRequest self = new QueryGeneralDataUpdateDateRequest();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataUpdateDateRequest setServiceId(String serviceId) {
        this.serviceId = serviceId;
        return this;
    }
    public String getServiceId() {
        return this.serviceId;
    }

}
