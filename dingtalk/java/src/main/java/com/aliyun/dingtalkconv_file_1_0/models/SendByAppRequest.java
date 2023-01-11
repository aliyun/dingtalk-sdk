// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendByAppRequest extends TeaModel {
    /**
     * <p>文件id</p>
     */
    @NameInMap("dentryId")
    public String dentryId;

    /**
     * <p>文件所在空间id</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    /**
     * <p>用户id</p>
     */
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

    public SendByAppRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
