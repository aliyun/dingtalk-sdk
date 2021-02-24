// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class RoaDuheYsTestRequest extends TeaModel {
    @NameInMap("bizGenericParameters")
    public java.util.Map<String, BizGenericParametersValue> bizGenericParameters;

    @NameInMap("bizSystemParameters")
    public java.util.Map<String, String> bizSystemParameters;

    @NameInMap("invokeInfomation")
    public java.util.Map<String, String> invokeInfomation;

    @NameInMap("gatewayInfomation")
    public java.util.Map<String, String> gatewayInfomation;

    @NameInMap("bizContext")
    public java.util.Map<String, BizContextValue> bizContext;

    @NameInMap("data")
    public String data;

    public static RoaDuheYsTestRequest build(java.util.Map<String, ?> map) throws Exception {
        RoaDuheYsTestRequest self = new RoaDuheYsTestRequest();
        return TeaModel.build(map, self);
    }

    public RoaDuheYsTestRequest setBizGenericParameters(java.util.Map<String, BizGenericParametersValue> bizGenericParameters) {
        this.bizGenericParameters = bizGenericParameters;
        return this;
    }
    public java.util.Map<String, BizGenericParametersValue> getBizGenericParameters() {
        return this.bizGenericParameters;
    }

    public RoaDuheYsTestRequest setBizSystemParameters(java.util.Map<String, String> bizSystemParameters) {
        this.bizSystemParameters = bizSystemParameters;
        return this;
    }
    public java.util.Map<String, String> getBizSystemParameters() {
        return this.bizSystemParameters;
    }

    public RoaDuheYsTestRequest setInvokeInfomation(java.util.Map<String, String> invokeInfomation) {
        this.invokeInfomation = invokeInfomation;
        return this;
    }
    public java.util.Map<String, String> getInvokeInfomation() {
        return this.invokeInfomation;
    }

    public RoaDuheYsTestRequest setGatewayInfomation(java.util.Map<String, String> gatewayInfomation) {
        this.gatewayInfomation = gatewayInfomation;
        return this;
    }
    public java.util.Map<String, String> getGatewayInfomation() {
        return this.gatewayInfomation;
    }

    public RoaDuheYsTestRequest setBizContext(java.util.Map<String, BizContextValue> bizContext) {
        this.bizContext = bizContext;
        return this;
    }
    public java.util.Map<String, BizContextValue> getBizContext() {
        return this.bizContext;
    }

    public RoaDuheYsTestRequest setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

}
