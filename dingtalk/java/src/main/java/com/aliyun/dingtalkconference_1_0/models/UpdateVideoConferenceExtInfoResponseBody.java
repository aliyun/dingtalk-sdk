// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateVideoConferenceExtInfoResponseBody extends TeaModel {
    // 失败原因
    @NameInMap("case")
    public String _case;

    // 返回编码
    @NameInMap("code")
    public String code;

    public static UpdateVideoConferenceExtInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateVideoConferenceExtInfoResponseBody self = new UpdateVideoConferenceExtInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateVideoConferenceExtInfoResponseBody set_case(String _case) {
        this._case = _case;
        return this;
    }
    public String get_case() {
        return this._case;
    }

    public UpdateVideoConferenceExtInfoResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
