// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignUserVerifyResponseBody extends TeaModel {
    @NameInMap("result")
    public EsignUserVerifyResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static EsignUserVerifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EsignUserVerifyResponseBody self = new EsignUserVerifyResponseBody();
        return TeaModel.build(map, self);
    }

    public EsignUserVerifyResponseBody setResult(EsignUserVerifyResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EsignUserVerifyResponseBodyResult getResult() {
        return this.result;
    }

    public EsignUserVerifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class EsignUserVerifyResponseBodyResult extends TeaModel {
        @NameInMap("canAccess")
        public Boolean canAccess;

        public static EsignUserVerifyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EsignUserVerifyResponseBodyResult self = new EsignUserVerifyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EsignUserVerifyResponseBodyResult setCanAccess(Boolean canAccess) {
            this.canAccess = canAccess;
            return this;
        }
        public Boolean getCanAccess() {
            return this.canAccess;
        }

    }

}
