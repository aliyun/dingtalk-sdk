// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetMySpaceResponseBody extends TeaModel {
    @NameInMap("createTime")
    public String createTime;

    @NameInMap("modifyTime")
    public String modifyTime;

    @NameInMap("quota")
    public Long quota;

    @NameInMap("spaceId")
    public String spaceId;

    @NameInMap("spaceName")
    public String spaceName;

    @NameInMap("spaceType")
    public String spaceType;

    @NameInMap("usedQuota")
    public Long usedQuota;

    public static GetMySpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMySpaceResponseBody self = new GetMySpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMySpaceResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public GetMySpaceResponseBody setModifyTime(String modifyTime) {
        this.modifyTime = modifyTime;
        return this;
    }
    public String getModifyTime() {
        return this.modifyTime;
    }

    public GetMySpaceResponseBody setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public GetMySpaceResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public GetMySpaceResponseBody setSpaceName(String spaceName) {
        this.spaceName = spaceName;
        return this;
    }
    public String getSpaceName() {
        return this.spaceName;
    }

    public GetMySpaceResponseBody setSpaceType(String spaceType) {
        this.spaceType = spaceType;
        return this;
    }
    public String getSpaceType() {
        return this.spaceType;
    }

    public GetMySpaceResponseBody setUsedQuota(Long usedQuota) {
        this.usedQuota = usedQuota;
        return this;
    }
    public Long getUsedQuota() {
        return this.usedQuota;
    }

}
