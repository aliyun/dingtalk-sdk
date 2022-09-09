// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendByAppRequest extends TeaModel {
    // 文件id
    @NameInMap("dentryId")
    public String dentryId;

    // 文件所在空间id
    @NameInMap("spaceId")
    public String spaceId;

    // 目标用户id
    // 会通过应用发送消息给指定用户
    @NameInMap("targetUnionId")
    public String targetUnionId;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static SendByAppRequest build(java.util.Map<String, ?> map) throws Exception {
        SendByAppRequest self = new SendByAppRequest();
        return TeaModel.build(map, self);
    }

    public SendByAppRequest setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public SendByAppRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public SendByAppRequest setTargetUnionId(String targetUnionId) {
        this.targetUnionId = targetUnionId;
        return this;
    }
    public String getTargetUnionId() {
        return this.targetUnionId;
    }

    public SendByAppRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
