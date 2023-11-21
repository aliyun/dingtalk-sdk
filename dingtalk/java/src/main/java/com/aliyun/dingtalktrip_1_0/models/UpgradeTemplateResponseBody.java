// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public UpgradeTemplateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UpgradeTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpgradeTemplateResponseBody self = new UpgradeTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpgradeTemplateResponseBody setResult(UpgradeTemplateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpgradeTemplateResponseBodyResult getResult() {
        return this.result;
    }

    public UpgradeTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpgradeTemplateResponseBodyResult extends TeaModel {
        @NameInMap("upgradeResult")
        public Boolean upgradeResult;

        public static UpgradeTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpgradeTemplateResponseBodyResult self = new UpgradeTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpgradeTemplateResponseBodyResult setUpgradeResult(Boolean upgradeResult) {
            this.upgradeResult = upgradeResult;
            return this;
        }
        public Boolean getUpgradeResult() {
            return this.upgradeResult;
        }

    }

}
