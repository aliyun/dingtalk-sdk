// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureQueryJobsResponseBody extends TeaModel {
    // 查询的数据结果
    @NameInMap("content")
    public String content;

    // httpCode
    @NameInMap("httpCode")
    public String httpCode;

    public static IndustrializeManufactureQueryJobsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureQueryJobsResponseBody self = new IndustrializeManufactureQueryJobsResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureQueryJobsResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public IndustrializeManufactureQueryJobsResponseBody setHttpCode(String httpCode) {
        this.httpCode = httpCode;
        return this;
    }
    public String getHttpCode() {
        return this.httpCode;
    }

}
