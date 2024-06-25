// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialAccountUserBasicInfoResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public QueryOfficialAccountUserBasicInfoResponseBodyResult result;

    public static QueryOfficialAccountUserBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialAccountUserBasicInfoResponseBody self = new QueryOfficialAccountUserBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOfficialAccountUserBasicInfoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryOfficialAccountUserBasicInfoResponseBody setResult(QueryOfficialAccountUserBasicInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOfficialAccountUserBasicInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryOfficialAccountUserBasicInfoResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>FOLLOWED</p>
         */
        @NameInMap("status")
        public String status;

        public static QueryOfficialAccountUserBasicInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOfficialAccountUserBasicInfoResponseBodyResult self = new QueryOfficialAccountUserBasicInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOfficialAccountUserBasicInfoResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
