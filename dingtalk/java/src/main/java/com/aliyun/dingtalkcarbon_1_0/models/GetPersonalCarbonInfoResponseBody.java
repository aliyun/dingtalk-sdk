// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalCarbonInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("personalCarbonAmount")
    public Double personalCarbonAmount;

    public static GetPersonalCarbonInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalCarbonInfoResponseBody self = new GetPersonalCarbonInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPersonalCarbonInfoResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public GetPersonalCarbonInfoResponseBody setPersonalCarbonAmount(Double personalCarbonAmount) {
        this.personalCarbonAmount = personalCarbonAmount;
        return this;
    }
    public Double getPersonalCarbonAmount() {
        return this.personalCarbonAmount;
    }

}
