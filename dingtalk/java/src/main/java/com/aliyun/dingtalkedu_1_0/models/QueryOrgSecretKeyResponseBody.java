// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgSecretKeyResponseBody extends TeaModel {
    /**
     * <p>秘钥信息</p>
     */
    @NameInMap("universitySecretKeyInfo")
    public QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo universitySecretKeyInfo;

    public static QueryOrgSecretKeyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgSecretKeyResponseBody self = new QueryOrgSecretKeyResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgSecretKeyResponseBody setUniversitySecretKeyInfo(QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo universitySecretKeyInfo) {
        this.universitySecretKeyInfo = universitySecretKeyInfo;
        return this;
    }
    public QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo getUniversitySecretKeyInfo() {
        return this.universitySecretKeyInfo;
    }

    public static class QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo extends TeaModel {
        /**
         * <p>秘钥key</p>
         */
        @NameInMap("secretKey")
        public String secretKey;

        public static QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo self = new QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo();
            return TeaModel.build(map, self);
        }

        public QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo setSecretKey(String secretKey) {
            this.secretKey = secretKey;
            return this;
        }
        public String getSecretKey() {
            return this.secretKey;
        }

    }

}
