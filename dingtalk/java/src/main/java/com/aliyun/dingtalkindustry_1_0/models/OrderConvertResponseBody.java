// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class OrderConvertResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Long dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static OrderConvertResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrderConvertResponseBody self = new OrderConvertResponseBody();
        return TeaModel.build(map, self);
    }

    public OrderConvertResponseBody setDingOpenErrcode(Long dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Long getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public OrderConvertResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public OrderConvertResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public OrderConvertResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
