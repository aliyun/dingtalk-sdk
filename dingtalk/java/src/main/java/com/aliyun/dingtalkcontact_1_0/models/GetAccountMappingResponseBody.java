// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetAccountMappingResponseBody extends TeaModel {
    @NameInMap("result")
    public GetAccountMappingResponseBodyResult result;

    public static GetAccountMappingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAccountMappingResponseBody self = new GetAccountMappingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAccountMappingResponseBody setResult(GetAccountMappingResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAccountMappingResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetAccountMappingResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>BizName1</p>
         */
        @NameInMap("domain")
        public String domain;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        /**
         * <strong>example:</strong>
         * <p>o_123</p>
         */
        @NameInMap("outId")
        public String outId;

        /**
         * <strong>example:</strong>
         * <p>t_123,如果不区分，填写固定值</p>
         */
        @NameInMap("outTenantId")
        public String outTenantId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>id_123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetAccountMappingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAccountMappingResponseBodyResult self = new GetAccountMappingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAccountMappingResponseBodyResult setDomain(String domain) {
            this.domain = domain;
            return this;
        }
        public String getDomain() {
            return this.domain;
        }

        public GetAccountMappingResponseBodyResult setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public GetAccountMappingResponseBodyResult setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

        public GetAccountMappingResponseBodyResult setOutTenantId(String outTenantId) {
            this.outTenantId = outTenantId;
            return this;
        }
        public String getOutTenantId() {
            return this.outTenantId;
        }

        public GetAccountMappingResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
