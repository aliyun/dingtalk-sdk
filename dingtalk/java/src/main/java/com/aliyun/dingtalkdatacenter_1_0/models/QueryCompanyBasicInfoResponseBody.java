// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCompanyBasicInfoResponseBody extends TeaModel {
    /**
     * <p>code</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public java.util.List<java.util.Map<String, String>> data;

    /**
     * <p>message</p>
     */
    @NameInMap("message")
    public String message;

    /**
     * <p>traceId</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>total</p>
     */
    @NameInMap("total")
    public Integer total;

    public static QueryCompanyBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCompanyBasicInfoResponseBody self = new QueryCompanyBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCompanyBasicInfoResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public QueryCompanyBasicInfoResponseBody setData(java.util.List<java.util.Map<String, String>> data) {
        this.data = data;
        return this;
    }
    public java.util.List<java.util.Map<String, String>> getData() {
        return this.data;
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

}
