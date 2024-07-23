// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class OperateChartConfigRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("apiKey")
    public String apiKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("param")
    public java.util.Map<String, ?> param;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8ABvoWxoelSxcxZBsF3MeWBDe5oi8jmFtU790jhpRoLrfJDWO8UDHbUqvTb3pQA5</p>
     */
    @NameInMap("ticket")
    public String ticket;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static OperateChartConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        OperateChartConfigRequest self = new OperateChartConfigRequest();
        return TeaModel.build(map, self);
    }

    public OperateChartConfigRequest setApiKey(String apiKey) {
        this.apiKey = apiKey;
        return this;
    }
    public String getApiKey() {
        return this.apiKey;
    }

    public OperateChartConfigRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public OperateChartConfigRequest setParam(java.util.Map<String, ?> param) {
        this.param = param;
        return this;
    }
    public java.util.Map<String, ?> getParam() {
        return this.param;
    }

    public OperateChartConfigRequest setTicket(String ticket) {
        this.ticket = ticket;
        return this;
    }
    public String getTicket() {
        return this.ticket;
    }

    public OperateChartConfigRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
