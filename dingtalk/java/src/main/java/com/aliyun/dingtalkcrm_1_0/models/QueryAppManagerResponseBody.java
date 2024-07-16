// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAppManagerResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryAppManagerResponseBodyResult> result;

    public static QueryAppManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAppManagerResponseBody self = new QueryAppManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAppManagerResponseBody setResult(java.util.List<QueryAppManagerResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryAppManagerResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryAppManagerResponseBodyResult extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static QueryAppManagerResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAppManagerResponseBodyResult self = new QueryAppManagerResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAppManagerResponseBodyResult setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QueryAppManagerResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryAppManagerResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
