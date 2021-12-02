// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetReceiptResponseBody extends TeaModel {
    // 数据模型id
    @NameInMap("modelId")
    public String modelId;

    // 数据来源：审批(approval)，开放接口(openapi)
    @NameInMap("source")
    public String source;

    // 数据来源于开放时，对应的微应用id
    @NameInMap("appId")
    public String appId;

    // 单据数据体json
    @NameInMap("data")
    public String data;

    public static GetReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetReceiptResponseBody self = new GetReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public GetReceiptResponseBody setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

    public GetReceiptResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetReceiptResponseBody setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public GetReceiptResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

}
