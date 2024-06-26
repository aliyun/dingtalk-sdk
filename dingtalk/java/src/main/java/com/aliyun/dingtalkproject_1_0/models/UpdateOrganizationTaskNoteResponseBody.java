// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskNoteResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateOrganizationTaskNoteResponseBodyResult result;

    public static UpdateOrganizationTaskNoteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskNoteResponseBody self = new UpdateOrganizationTaskNoteResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskNoteResponseBody setResult(UpdateOrganizationTaskNoteResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateOrganizationTaskNoteResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateOrganizationTaskNoteResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>我是一条备注哦</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <strong>example:</strong>
         * <p>2022-06-13T05:48:45.788Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateOrganizationTaskNoteResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskNoteResponseBodyResult self = new UpdateOrganizationTaskNoteResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskNoteResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public UpdateOrganizationTaskNoteResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
