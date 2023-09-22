// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListCategorysRequest extends TeaModel {
    @NameInMap("body")
    public ListCategorysRequestBody body;

    public static ListCategorysRequest build(java.util.Map<String, ?> map) throws Exception {
        ListCategorysRequest self = new ListCategorysRequest();
        return TeaModel.build(map, self);
    }

    public ListCategorysRequest setBody(ListCategorysRequestBody body) {
        this.body = body;
        return this;
    }
    public ListCategorysRequestBody getBody() {
        return this.body;
    }

    public static class ListCategorysRequestBody extends TeaModel {
        @NameInMap("status")
        public Long status;

        public static ListCategorysRequestBody build(java.util.Map<String, ?> map) throws Exception {
            ListCategorysRequestBody self = new ListCategorysRequestBody();
            return TeaModel.build(map, self);
        }

        public ListCategorysRequestBody setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

    }

}
