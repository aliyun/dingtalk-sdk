// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class UpdateMinutesTitleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateMinutesTitleRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMinutesTitleRequest self = new UpdateMinutesTitleRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMinutesTitleRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateMinutesTitleRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
