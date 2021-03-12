// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddShareCidListResponseBody extends TeaModel {
    // 是否联播成功
    @NameInMap("hasShareSuccess")
    public Boolean hasShareSuccess;

    // 本次请求成功联播的群列表
    @NameInMap("shareSuccessGroupList")
    public java.util.List<String> shareSuccessGroupList;

    public static AddShareCidListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddShareCidListResponseBody self = new AddShareCidListResponseBody();
        return TeaModel.build(map, self);
    }

    public AddShareCidListResponseBody setHasShareSuccess(Boolean hasShareSuccess) {
        this.hasShareSuccess = hasShareSuccess;
        return this;
    }
    public Boolean getHasShareSuccess() {
        return this.hasShareSuccess;
    }

    public AddShareCidListResponseBody setShareSuccessGroupList(java.util.List<String> shareSuccessGroupList) {
        this.shareSuccessGroupList = shareSuccessGroupList;
        return this;
    }
    public java.util.List<String> getShareSuccessGroupList() {
        return this.shareSuccessGroupList;
    }

}
