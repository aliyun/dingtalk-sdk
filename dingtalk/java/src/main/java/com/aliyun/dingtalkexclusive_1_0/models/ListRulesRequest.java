// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListRulesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public ListRulesRequestBody body;

    public static ListRulesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRulesRequest self = new ListRulesRequest();
        return TeaModel.build(map, self);
    }

    public ListRulesRequest setBody(ListRulesRequestBody body) {
        this.body = body;
        return this;
    }
    public ListRulesRequestBody getBody() {
        return this.body;
    }

    public static class ListRulesRequestBody extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Long status;

        public static ListRulesRequestBody build(java.util.Map<String, ?> map) throws Exception {
            ListRulesRequestBody self = new ListRulesRequestBody();
            return TeaModel.build(map, self);
        }

        public ListRulesRequestBody setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

    }

}
