// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddUserAccountRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <strong>example:</strong>
     * <p>示例昵称xxx</p>
     */
    @NameInMap("channelAccountName")
    public String channelAccountName;

    /**
     * <strong>example:</strong>
     * <p>6FSe51616SOdd394d6</p>
     */
    @NameInMap("channelUserIdentify")
    public String channelUserIdentify;

    /**
     * <strong>example:</strong>
     * <p>16600010001</p>
     */
    @NameInMap("phoneNumber")
    public String phoneNumber;

    /**
     * <strong>example:</strong>
     * <p>ding123456789</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>1676451039</p>
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
