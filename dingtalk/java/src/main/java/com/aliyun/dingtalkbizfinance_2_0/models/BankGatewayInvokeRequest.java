// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BankGatewayInvokeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>bankHttp</p>
     */
    @NameInMap("actionType")
    public String actionType;

    @NameInMap("inputData")
    public String inputData;

    /**
     * <strong>example:</strong>
     * <p><a href="https://cdc.cmbchina.com/cdcserver/api/v2">https://cdc.cmbchina.com/cdcserver/api/v2</a></p>
     */
    @NameInMap("url")
    public String url;

    public static BankGatewayInvokeRequest build(java.util.Map<String, ?> map) throws Exception {
        BankGatewayInvokeRequest self = new BankGatewayInvokeRequest();
        return TeaModel.build(map, self);
    }

    public BankGatewayInvokeRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public BankGatewayInvokeRequest setInputData(String inputData) {
        this.inputData = inputData;
        return this;
    }
    public String getInputData() {
        return this.inputData;
    }

    public BankGatewayInvokeRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
