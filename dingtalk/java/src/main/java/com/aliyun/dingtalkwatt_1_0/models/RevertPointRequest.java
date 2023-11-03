// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class RevertPointRequest extends TeaModel {
    @NameInMap("body")
    public RevertPointRequestBody body;

    public static RevertPointRequest build(java.util.Map<String, ?> map) throws Exception {
        RevertPointRequest self = new RevertPointRequest();
        return TeaModel.build(map, self);
    }

    public RevertPointRequest setBody(RevertPointRequestBody body) {
        this.body = body;
        return this;
    }
    public RevertPointRequestBody getBody() {
        return this.body;
    }

    public static class RevertPointRequestBody extends TeaModel {
        @NameInMap("pointPoolCode")
        public String pointPoolCode;

        @NameInMap("requestId")
        public String requestId;

        public static RevertPointRequestBody build(java.util.Map<String, ?> map) throws Exception {
            RevertPointRequestBody self = new RevertPointRequestBody();
            return TeaModel.build(map, self);
        }

        public RevertPointRequestBody setPointPoolCode(String pointPoolCode) {
            this.pointPoolCode = pointPoolCode;
            return this;
        }
        public String getPointPoolCode() {
            return this.pointPoolCode;
        }

        public RevertPointRequestBody setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
