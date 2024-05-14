// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentMembersInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("residentCropId")
    public String residentCropId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static GetResidentMembersInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetResidentMembersInfoRequest self = new GetResidentMembersInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetResidentMembersInfoRequest setResidentCropId(String residentCropId) {
        this.residentCropId = residentCropId;
        return this;
    }
    public String getResidentCropId() {
        return this.residentCropId;
    }

    public GetResidentMembersInfoRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
