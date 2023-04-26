// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateVideoConferenceSettingRequest extends TeaModel {
    @NameInMap("allowUnmuteSelf")
    public Boolean allowUnmuteSelf;

    @NameInMap("autoTransferHost")
    public Boolean autoTransferHost;

    @NameInMap("forbiddenShareScreen")
    public Boolean forbiddenShareScreen;

    @NameInMap("lockConference")
    public Boolean lockConference;

    @NameInMap("muteAll")
    public Boolean muteAll;

    @NameInMap("onlyInternalEmployeesJoin")
    public Boolean onlyInternalEmployeesJoin;

    public static UpdateVideoConferenceSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateVideoConferenceSettingRequest self = new UpdateVideoConferenceSettingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateVideoConferenceSettingRequest setAllowUnmuteSelf(Boolean allowUnmuteSelf) {
        this.allowUnmuteSelf = allowUnmuteSelf;
        return this;
    }
    public Boolean getAllowUnmuteSelf() {
        return this.allowUnmuteSelf;
    }

    public UpdateVideoConferenceSettingRequest setAutoTransferHost(Boolean autoTransferHost) {
        this.autoTransferHost = autoTransferHost;
        return this;
    }
    public Boolean getAutoTransferHost() {
        return this.autoTransferHost;
    }

    public UpdateVideoConferenceSettingRequest setForbiddenShareScreen(Boolean forbiddenShareScreen) {
        this.forbiddenShareScreen = forbiddenShareScreen;
        return this;
    }
    public Boolean getForbiddenShareScreen() {
        return this.forbiddenShareScreen;
    }

    public UpdateVideoConferenceSettingRequest setLockConference(Boolean lockConference) {
        this.lockConference = lockConference;
        return this;
    }
    public Boolean getLockConference() {
        return this.lockConference;
    }

    public UpdateVideoConferenceSettingRequest setMuteAll(Boolean muteAll) {
        this.muteAll = muteAll;
        return this;
    }
    public Boolean getMuteAll() {
        return this.muteAll;
    }

    public UpdateVideoConferenceSettingRequest setOnlyInternalEmployeesJoin(Boolean onlyInternalEmployeesJoin) {
        this.onlyInternalEmployeesJoin = onlyInternalEmployeesJoin;
        return this;
    }
    public Boolean getOnlyInternalEmployeesJoin() {
        return this.onlyInternalEmployeesJoin;
    }

}
