// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class OrderResaleResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    @NameInMap("data")
    public OrderResaleResponseBodyData data;

    public static OrderResaleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrderResaleResponseBody self = new OrderResaleResponseBody();
        return TeaModel.build(map, self);
    }

    public OrderResaleResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public OrderResaleResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public OrderResaleResponseBody setData(OrderResaleResponseBodyData data) {
        this.data = data;
        return this;
    }
    public OrderResaleResponseBodyData getData() {
        return this.data;
    }

    public static class OrderResaleResponseBodyData extends TeaModel {
        @NameInMap("esignOrderId")
        public String esignOrderId;

        public static OrderResaleResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            OrderResaleResponseBodyData self = new OrderResaleResponseBodyData();
            return TeaModel.build(map, self);
        }

        public OrderResaleResponseBodyData setEsignOrderId(String esignOrderId) {
            this.esignOrderId = esignOrderId;
            return this;
        }
        public String getEsignOrderId() {
            return this.esignOrderId;
        }

    }

}
