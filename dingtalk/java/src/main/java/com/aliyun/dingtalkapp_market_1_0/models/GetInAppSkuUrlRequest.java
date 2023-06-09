// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetInAppSkuUrlRequest extends TeaModel {
    @NameInMap("callbackPage")
    public String callbackPage;

    @NameInMap("extendParam")
    public String extendParam;

    @NameInMap("goodsCode")
    public String goodsCode;

    @NameInMap("itemCode")
    public String itemCode;

    public static GetInAppSkuUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInAppSkuUrlRequest self = new GetInAppSkuUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetInAppSkuUrlRequest setCallbackPage(String callbackPage) {
        this.callbackPage = callbackPage;
        return this;
    }
    public String getCallbackPage() {
        return this.callbackPage;
    }

    public GetInAppSkuUrlRequest setExtendParam(String extendParam) {
        this.extendParam = extendParam;
        return this;
    }
    public String getExtendParam() {
        return this.extendParam;
    }

    public GetInAppSkuUrlRequest setGoodsCode(String goodsCode) {
        this.goodsCode = goodsCode;
        return this;
    }
    public String getGoodsCode() {
        return this.goodsCode;
    }

    public GetInAppSkuUrlRequest setItemCode(String itemCode) {
        this.itemCode = itemCode;
        return this;
    }
    public String getItemCode() {
        return this.itemCode;
    }

}
