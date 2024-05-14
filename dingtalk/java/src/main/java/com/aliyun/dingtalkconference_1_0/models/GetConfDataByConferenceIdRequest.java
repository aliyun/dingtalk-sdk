// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDataByConferenceIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("realData")
    public Boolean realData;

    public static GetConfDataByConferenceIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConfDataByConferenceIdRequest self = new GetConfDataByConferenceIdRequest();
        return TeaModel.build(map, self);
    }

    public GetConfDataByConferenceIdRequest setRealData(Boolean realData) {
        this.realData = realData;
        return this;
    }
    public Boolean getRealData() {
        return this.realData;
    }

}
