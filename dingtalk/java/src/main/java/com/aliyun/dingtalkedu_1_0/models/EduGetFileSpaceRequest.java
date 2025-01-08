// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduGetFileSpaceRequest extends TeaModel {
    @NameInMap("channelCode")
    public String channelCode;

    public static EduGetFileSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        EduGetFileSpaceRequest self = new EduGetFileSpaceRequest();
        return TeaModel.build(map, self);
    }

    public EduGetFileSpaceRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

}
