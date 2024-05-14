<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetEmployeeRosterByFieldResponseBody\result\fieldDataList;

use AlibabaCloud\Tea\Model;

class fieldValueList extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $itemIndex;

    /**
     * @example 正式
     *
     * @var string
     */
    public $label;

    /**
     * @example 3
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'itemIndex' => 'itemIndex',
        'label'     => 'label',
        'value'     => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemIndex) {
            $res['itemIndex'] = $this->itemIndex;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fieldValueList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemIndex'])) {
            $model->itemIndex = $map['itemIndex'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
