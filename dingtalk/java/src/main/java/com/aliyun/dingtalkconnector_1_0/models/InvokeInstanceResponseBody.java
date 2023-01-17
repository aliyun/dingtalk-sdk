// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class InvokeInstanceResponseBody extends TeaModel {
    /**
     * <p>本次执行耗时</p>
     */
    @NameInMap("cost")
    public Long cost;

    /**
     * <p>连接器错误码</p>
     */
    @NameInMap("errorCode")
    public String errorCode;

    /**
     * <p>连接器错误信息</p>
     */
    @NameInMap("errorMessage")
    public String errorMessage;

    /**
     * <p>调用记录的ID</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("outputJson")
    public String outputJson;

    public static InvokeInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InvokeInstanceResponseBody self = new InvokeInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public InvokeInstanceResponseBody setCost(Long cost) {
        this.cost = cost;
        return this;
    }
    public Long getCost() {
        return this.cost;
    }

    public InvokeInstanceResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public InvokeInstanceResponseBody setErrorMessage(String errorMessage) {
        this.errorMessage = errorMessage;
        return this;
    }
    public String getErrorMessage() {
        return this.errorMessage;
    }

    public InvokeInstanceResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public InvokeInstanceResponseBody setOutputJson(String outputJson) {
        this.outputJson = outputJson;
        return this;
    }
    public String getOutputJson() {
        return this.outputJson;
    }

}
