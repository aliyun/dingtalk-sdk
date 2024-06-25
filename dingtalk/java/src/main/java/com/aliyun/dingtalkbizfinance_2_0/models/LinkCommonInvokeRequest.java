// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class LinkCommonInvokeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>TEST</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <strong>example:</strong>
     * <p>&quot;{&quot;key&quot;:&quot;value&quot;}&quot;</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <strong>example:</strong>
     * <p>INOVKE_XXX</p>
     */
    @NameInMap("invokeId")
    public String invokeId;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("userId")
    public String userId;

    public static LinkCommonInvokeRequest build(java.util.Map<String, ?> map) throws Exception {
        LinkCommonInvokeRequest self = new LinkCommonInvokeRequest();
        return TeaModel.build(map, self);
    }

    public LinkCommonInvokeRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public LinkCommonInvokeRequest setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public LinkCommonInvokeRequest setInvokeId(String invokeId) {
        this.invokeId = invokeId;
        return this;
    }
    public String getInvokeId() {
        return this.invokeId;
    }

    public LinkCommonInvokeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
