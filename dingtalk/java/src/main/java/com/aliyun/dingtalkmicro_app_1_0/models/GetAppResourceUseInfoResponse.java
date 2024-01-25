// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetAppResourceUseInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public java.util.List<GetAppResourceUseInfoResponseBody> body;

    public static GetAppResourceUseInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAppResourceUseInfoResponse self = new GetAppResourceUseInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetAppResourceUseInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAppResourceUseInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAppResourceUseInfoResponse setBody(java.util.List<GetAppResourceUseInfoResponseBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<GetAppResourceUseInfoResponseBody> getBody() {
        return this.body;
    }

    public static class GetAppResourceUseInfoResponseBody extends TeaModel {
        @NameInMap("period")
        public String period;

        @NameInMap("usedNum")
        public Long usedNum;

        @NameInMap("quotaNum")
        public Long quotaNum;

        public static GetAppResourceUseInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
            GetAppResourceUseInfoResponseBody self = new GetAppResourceUseInfoResponseBody();
            return TeaModel.build(map, self);
        }

        public GetAppResourceUseInfoResponseBody setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public GetAppResourceUseInfoResponseBody setUsedNum(Long usedNum) {
            this.usedNum = usedNum;
            return this;
        }
        public Long getUsedNum() {
            return this.usedNum;
        }

        public GetAppResourceUseInfoResponseBody setQuotaNum(Long quotaNum) {
            this.quotaNum = quotaNum;
            return this;
        }
        public Long getQuotaNum() {
            return this.quotaNum;
        }

    }

}
