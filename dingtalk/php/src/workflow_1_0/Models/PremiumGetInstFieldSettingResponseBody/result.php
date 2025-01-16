<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetInstFieldSettingResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example TextField
     *
     * @var string
     */
    public $componentType;

    /**
     * @example READONLY
     *
     * @var string
     */
    public $fieldBehavior;

    /**
     * @example TextField-abcd
     *
     * @var string
     */
    public $fieldId;
    protected $_name = [
        'componentType' => 'componentType',
        'fieldBehavior' => 'fieldBehavior',
        'fieldId'       => 'fieldId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentType) {
            $res['componentType'] = $this->componentType;
        }
        if (null !== $this->fieldBehavior) {
            $res['fieldBehavior'] = $this->fieldBehavior;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentType'])) {
            $model->componentType = $map['componentType'];
        }
        if (isset($map['fieldBehavior'])) {
            $model->fieldBehavior = $map['fieldBehavior'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }

        return $model;
    }
}
