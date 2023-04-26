// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateVideoConferenceSettingResponseBody extends TeaModel {
    @NameInMap("case")
    public String _case;

    @NameInMap("code")
    public String code;

    public static UpdateVideoConferenceSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateVideoConferenceSettingResponseBody self = new UpdateVideoConferenceSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateVideoConferenceSettingResponseBody set_case(String _case) {
        this._case = _case;
        return this;
    }
    public String get_case() {
        return this._case;
    }

    public UpdateVideoConferenceSettingResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
