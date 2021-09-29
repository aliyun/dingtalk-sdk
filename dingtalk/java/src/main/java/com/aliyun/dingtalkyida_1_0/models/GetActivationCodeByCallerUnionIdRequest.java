// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivationCodeByCallerUnionIdRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    public static GetActivationCodeByCallerUnionIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetActivationCodeByCallerUnionIdRequest self = new GetActivationCodeByCallerUnionIdRequest();
        return TeaModel.build(map, self);
    }

    public GetActivationCodeByCallerUnionIdRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

}
