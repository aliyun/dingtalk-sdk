// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class WeiqiaoAluminumQueryResponseBody extends TeaModel {
    @NameInMap("code")
    public Long code;

    @NameInMap("message")
    public String message;

    /**
     * <strong>example:</strong>
     * <p>{&quot;Al-Si-Material&quot;: 1626, &quot;Al-Fe-Material&quot;: 1575}</p>
     */
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    /**
     * <strong>example:</strong>
     * <p>finish</p>
     */
    @NameInMap("status")
    public String status;

    @NameInMap("success")
    public Boolean success;

    public static WeiqiaoAluminumQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WeiqiaoAluminumQueryResponseBody self = new WeiqiaoAluminumQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public WeiqiaoAluminumQueryResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public WeiqiaoAluminumQueryResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public WeiqiaoAluminumQueryResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

    public WeiqiaoAluminumQueryResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public WeiqiaoAluminumQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
