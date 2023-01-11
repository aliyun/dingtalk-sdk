// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteIsvStateRequest extends TeaModel {
    /**
     * <p>ISV名称</p>
     */
    @NameInMap("isvName")
    public String isvName;

    /**
     * <p>数据完成日期</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static WriteIsvStateRequest build(java.util.Map<String, ?> map) throws Exception {
        WriteIsvStateRequest self = new WriteIsvStateRequest();
        return TeaModel.build(map, self);
    }

    public WriteIsvStateRequest setIsvName(String isvName) {
        this.isvName = isvName;
        return this;
    }
    public String getIsvName() {
        return this.isvName;
    }

    public WriteIsvStateRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
