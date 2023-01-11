// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class GetTranscribeBriefResponseBody extends TeaModel {
    @NameInMap("data")
    public GetTranscribeBriefResponseBodyData data;

    @NameInMap("statusCode")
    public Integer statusCode;

    /**
     * <p>用于描述本次请求是否成功的字段</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetTranscribeBriefResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTranscribeBriefResponseBody self = new GetTranscribeBriefResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTranscribeBriefResponseBody setData(GetTranscribeBriefResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetTranscribeBriefResponseBodyData getData() {
        return this.data;
    }

    public GetTranscribeBriefResponseBody setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTranscribeBriefResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetTranscribeBriefResponseBodyData extends TeaModel {
        @NameInMap("bizType")
        public Integer bizType;

        public static GetTranscribeBriefResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetTranscribeBriefResponseBodyData self = new GetTranscribeBriefResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetTranscribeBriefResponseBodyData setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

    }

}
