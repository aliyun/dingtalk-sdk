// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ContractMarginResponseBody extends TeaModel {
    @NameInMap("data")
    public ContractMarginResponseBodyData data;

    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    public static ContractMarginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ContractMarginResponseBody self = new ContractMarginResponseBody();
        return TeaModel.build(map, self);
    }

    public ContractMarginResponseBody setData(ContractMarginResponseBodyData data) {
        this.data = data;
        return this;
    }
    public ContractMarginResponseBodyData getData() {
        return this.data;
    }

    public ContractMarginResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public ContractMarginResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class ContractMarginResponseBodyData extends TeaModel {
        @NameInMap("margin")
        public Long margin;

        public static ContractMarginResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ContractMarginResponseBodyData self = new ContractMarginResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ContractMarginResponseBodyData setMargin(Long margin) {
            this.margin = margin;
            return this;
        }
        public Long getMargin() {
            return this.margin;
        }

    }

}
