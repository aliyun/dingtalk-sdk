// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryChartDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ABC</p>
     */
    @NameInMap("ticket")
    public String ticket;

    public static QueryChartDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryChartDataRequest self = new QueryChartDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryChartDataRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public QueryChartDataRequest setTicket(String ticket) {
        this.ticket = ticket;
        return this;
    }
    public String getTicket() {
        return this.ticket;
    }

}
