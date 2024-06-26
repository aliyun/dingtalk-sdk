// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class RangeFindNextRequest extends TeaModel {
    @NameInMap("findOptions")
    public RangeFindNextRequestFindOptions findOptions;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DingTalk</p>
     */
    @NameInMap("text")
    public String text;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static RangeFindNextRequest build(java.util.Map<String, ?> map) throws Exception {
        RangeFindNextRequest self = new RangeFindNextRequest();
        return TeaModel.build(map, self);
    }

    public RangeFindNextRequest setFindOptions(RangeFindNextRequestFindOptions findOptions) {
        this.findOptions = findOptions;
        return this;
    }
    public RangeFindNextRequestFindOptions getFindOptions() {
        return this.findOptions;
    }

    public RangeFindNextRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public RangeFindNextRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class RangeFindNextRequestFindOptions extends TeaModel {
        @NameInMap("includeHidden")
        public Boolean includeHidden;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("matchCase")
        public Boolean matchCase;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("matchEntireCell")
        public Boolean matchEntireCell;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("matchFormulaText")
        public Boolean matchFormulaText;

        @NameInMap("scope")
        public String scope;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("useRegExp")
        public Boolean useRegExp;

        public static RangeFindNextRequestFindOptions build(java.util.Map<String, ?> map) throws Exception {
            RangeFindNextRequestFindOptions self = new RangeFindNextRequestFindOptions();
            return TeaModel.build(map, self);
        }

        public RangeFindNextRequestFindOptions setIncludeHidden(Boolean includeHidden) {
            this.includeHidden = includeHidden;
            return this;
        }
        public Boolean getIncludeHidden() {
            return this.includeHidden;
        }

        public RangeFindNextRequestFindOptions setMatchCase(Boolean matchCase) {
            this.matchCase = matchCase;
            return this;
        }
        public Boolean getMatchCase() {
            return this.matchCase;
        }

        public RangeFindNextRequestFindOptions setMatchEntireCell(Boolean matchEntireCell) {
            this.matchEntireCell = matchEntireCell;
            return this;
        }
        public Boolean getMatchEntireCell() {
            return this.matchEntireCell;
        }

        public RangeFindNextRequestFindOptions setMatchFormulaText(Boolean matchFormulaText) {
            this.matchFormulaText = matchFormulaText;
            return this;
        }
        public Boolean getMatchFormulaText() {
            return this.matchFormulaText;
        }

        public RangeFindNextRequestFindOptions setScope(String scope) {
            this.scope = scope;
            return this;
        }
        public String getScope() {
            return this.scope;
        }

        public RangeFindNextRequestFindOptions setUseRegExp(Boolean useRegExp) {
            this.useRegExp = useRegExp;
            return this;
        }
        public Boolean getUseRegExp() {
            return this.useRegExp;
        }

    }

}
