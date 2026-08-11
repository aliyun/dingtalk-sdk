<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleEntityUpdateRequest;

use AlibabaCloud\Tea\Model;

class fieldInstances extends Model
{
    /**
     * @var string
     */
    public $fieldKey;

    /**
     * @var string
     */
    public $fieldValue;
    protected $_name = [
        'fieldKey' => 'fieldKey',
        'fieldValue' => 'fieldValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldKey) {
            $res['fieldKey'] = $this->fieldKey;
        }
        if (null !== $this->fieldValue) {
            $res['fieldValue'] = $this->fieldValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fieldInstances
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldKey'])) {
            $model->fieldKey = $map['fieldKey'];
        }
        if (isset($map['fieldValue'])) {
            $model->fieldValue = $map['fieldValue'];
        }

        return $model;
    }
}
