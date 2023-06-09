// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryIdentityByTicketResponseBody extends TeaModel {
    @NameInMap("result")
    public EsignQueryIdentityByTicketResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static EsignQueryIdentityByTicketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryIdentityByTicketResponseBody self = new EsignQueryIdentityByTicketResponseBody();
        return TeaModel.build(map, self);
    }

    public EsignQueryIdentityByTicketResponseBody setResult(EsignQueryIdentityByTicketResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EsignQueryIdentityByTicketResponseBodyResult getResult() {
        return this.result;
    }

    public EsignQueryIdentityByTicketResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class EsignQueryIdentityByTicketResponseBodyResult extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        public static EsignQueryIdentityByTicketResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EsignQueryIdentityByTicketResponseBodyResult self = new EsignQueryIdentityByTicketResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EsignQueryIdentityByTicketResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
