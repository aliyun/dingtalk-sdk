// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class GetPointInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetPointInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetPointInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPointInfoResponseBody self = new GetPointInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPointInfoResponseBody setResult(GetPointInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetPointInfoResponseBodyResult getResult() {
        return this.result;
    }

    public GetPointInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetPointInfoResponseBodyResult extends TeaModel {
        @NameInMap("userPoints")
        public Long userPoints;

        public static GetPointInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetPointInfoResponseBodyResult self = new GetPointInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetPointInfoResponseBodyResult setUserPoints(Long userPoints) {
            this.userPoints = userPoints;
            return this;
        }
        public Long getUserPoints() {
            return this.userPoints;
        }

    }

}
