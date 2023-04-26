// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDigitalDistrictOrgInfoResponseBody extends TeaModel {
    @NameInMap("arguments")
    public java.util.List<String> arguments;

    @NameInMap("result")
    public String result;

    public static QueryDigitalDistrictOrgInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDigitalDistrictOrgInfoResponseBody self = new QueryDigitalDistrictOrgInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDigitalDistrictOrgInfoResponseBody setArguments(java.util.List<String> arguments) {
        this.arguments = arguments;
        return this;
    }
    public java.util.List<String> getArguments() {
        return this.arguments;
    }

    public QueryDigitalDistrictOrgInfoResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
