// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialFormDataResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOfficialFormDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialFormDataResponseBody self = new QueryOfficialFormDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOfficialFormDataResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public QueryOfficialFormDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
