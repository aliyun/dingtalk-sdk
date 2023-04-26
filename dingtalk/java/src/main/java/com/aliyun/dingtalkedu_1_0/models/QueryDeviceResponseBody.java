// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceResponseBody extends TeaModel {
    @NameInMap("gmtExpiry")
    public Long gmtExpiry;

    @NameInMap("model")
    public String model;

    @NameInMap("name")
    public String name;

    @NameInMap("sn")
    public String sn;

    @NameInMap("type")
    public String type;

    public static QueryDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceResponseBody self = new QueryDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceResponseBody setGmtExpiry(Long gmtExpiry) {
        this.gmtExpiry = gmtExpiry;
        return this;
    }
    public Long getGmtExpiry() {
        return this.gmtExpiry;
    }

    public QueryDeviceResponseBody setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public QueryDeviceResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public QueryDeviceResponseBody setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QueryDeviceResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
