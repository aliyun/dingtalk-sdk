// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTotalNumberOfSpacesResponseBody extends TeaModel {
    @NameInMap("spacesCount")
    public String spacesCount;

    public static GetTotalNumberOfSpacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTotalNumberOfSpacesResponseBody self = new GetTotalNumberOfSpacesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTotalNumberOfSpacesResponseBody setSpacesCount(String spacesCount) {
        this.spacesCount = spacesCount;
        return this;
    }
    public String getSpacesCount() {
        return this.spacesCount;
    }

}
