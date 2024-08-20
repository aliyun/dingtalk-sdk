<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody\flowConfig;

use AlibabaCloud\Tea\Model;

class sidInstDetail extends Model
{
    /**
     * @example HIDDEN
     *
     * @var string
     */
    public $fieldBehavior;

    /**
     * @example textField_xxx
     *
     * @var string
     */
    public $fieldId;
    protected $_name = [
        'fieldBehavior' => 'fieldBehavior',
        'fieldId'       => 'fieldId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return sidInstDetail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldBehavior'])) {
            $model->fieldBehavior = $map['fieldBehavior'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }

        return $model;
    }
}
