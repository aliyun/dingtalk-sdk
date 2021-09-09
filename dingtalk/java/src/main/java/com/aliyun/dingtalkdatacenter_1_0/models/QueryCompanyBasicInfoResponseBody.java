// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCompanyBasicInfoResponseBody extends TeaModel {
    // message
    @NameInMap("message")
    public String message;

    // traceId
    @NameInMap("requestId")
    public String requestId;

    // total
    @NameInMap("total")
    public Integer total;

    // data
    @NameInMap("data")
    public String data;

    // code
    @NameInMap("code")
    public Integer code;

    public static QueryCompanyBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCompanyBasicInfoResponseBody self = new QueryCompanyBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCompanyBasicInfoResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public QueryCompanyBasicInfoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryCompanyBasicInfoResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public QueryCompanyBasicInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public QueryCompanyBasicInfoResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

}
