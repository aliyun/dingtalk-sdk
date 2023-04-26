// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetReceiptResponseBody extends TeaModel {
    @NameInMap("appId")
    public String appId;

    @NameInMap("data")
    public String data;

    @NameInMap("modelId")
    public String modelId;

    @NameInMap("source")
    public String source;

    public static GetReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetReceiptResponseBody self = new GetReceiptResponseBody();
        return TeaModel.build(map, self);
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

}
