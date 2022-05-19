// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentInfoRequest extends TeaModel {
    // 小区地址
    @NameInMap("address")
    public String address;

    // 小区类型1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
    @NameInMap("communityType")
    public Long communityType;

    // 小区名
    @NameInMap("name")
    public String name;

    // 小区状态：0正常/1关闭/2作废
    @NameInMap("state")
    public Long state;

    public static UpdateResidentInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentInfoRequest self = new UpdateResidentInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidentInfoRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public UpdateResidentInfoRequest setCommunityType(Long communityType) {
        this.communityType = communityType;
        return this;
    }
    public Long getCommunityType() {
        return this.communityType;
    }

    public UpdateResidentInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateResidentInfoRequest setState(Long state) {
        this.state = state;
        return this;
    }
    public Long getState() {
        return this.state;
    }

}
