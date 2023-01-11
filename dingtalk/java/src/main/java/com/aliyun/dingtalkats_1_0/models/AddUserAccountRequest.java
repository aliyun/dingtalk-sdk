// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddUserAccountRequest extends TeaModel {
    /**
     * <p>业务标识</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>渠道账号名</p>
     */
    @NameInMap("channelAccountName")
    public String channelAccountName;

    /**
     * <p>渠道用户标识</p>
     */
    @NameInMap("channelUserIdentify")
    public String channelUserIdentify;

    /**
     * <p>手机号</p>
     */
    @NameInMap("phoneNumber")
    public String phoneNumber;

    /**
     * <p>企业标识</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>用户标识</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddUserAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        AddUserAccountRequest self = new AddUserAccountRequest();
        return TeaModel.build(map, self);
    }

    public AddUserAccountRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public AddUserAccountRequest setChannelAccountName(String channelAccountName) {
        this.channelAccountName = channelAccountName;
        return this;
    }
    public String getChannelAccountName() {
        return this.channelAccountName;
    }

    public AddUserAccountRequest setChannelUserIdentify(String channelUserIdentify) {
        this.channelUserIdentify = channelUserIdentify;
        return this;
    }
    public String getChannelUserIdentify() {
        return this.channelUserIdentify;
    }

    public AddUserAccountRequest setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
        return this;
    }
    public String getPhoneNumber() {
        return this.phoneNumber;
    }

    public AddUserAccountRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AddUserAccountRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
