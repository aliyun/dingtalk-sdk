// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddOrgRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>15800000000</p>
     */
    @NameInMap("mobileNum")
    public String mobileNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试组织</p>
     */
    @NameInMap("name")
    public String name;

    public static AddOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgRequest self = new AddOrgRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgRequest setMobileNum(String mobileNum) {
        this.mobileNum = mobileNum;
        return this;
    }
    public String getMobileNum() {
        return this.mobileNum;
    }

    public AddOrgRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
