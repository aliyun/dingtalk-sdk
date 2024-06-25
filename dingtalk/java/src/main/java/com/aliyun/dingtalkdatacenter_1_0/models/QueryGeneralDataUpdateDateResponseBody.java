// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataUpdateDateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("updateDate")
    public String updateDate;

    public static QueryGeneralDataUpdateDateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataUpdateDateResponseBody self = new QueryGeneralDataUpdateDateResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataUpdateDateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public QueryGeneralDataUpdateDateResponseBody setUpdateDate(String updateDate) {
        this.updateDate = updateDate;
        return this;
    }
    public String getUpdateDate() {
        return this.updateDate;
    }

}
