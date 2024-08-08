<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceBatchRequest;

use AlibabaCloud\Tea\Model;

class filters extends Model
{
    /**
     * @var string
     */
    public $fieldId;

    /**
     * @var string
     */
    public $operator;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'fieldId'  => 'fieldId',
        'operator' => 'operator',
        'value'    => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filters
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
