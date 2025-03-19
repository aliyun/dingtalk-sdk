<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class recallResult extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example template_key_1
     *
     * @var string
     */
    public $templateKey;

    /**
     * @description This parameter is required.
     *
     * @example recall_success
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'templateKey' => 'templateKey',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateKey) {
            $res['templateKey'] = $this->templateKey;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recallResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateKey'])) {
            $model->templateKey = $map['templateKey'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
