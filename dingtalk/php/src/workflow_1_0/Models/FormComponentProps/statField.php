<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormComponentProps;

use AlibabaCloud\Tea\Model;

class statField extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example NumberField-abcd
     *
     * @var string
     */
    public $componentId;

    /**
     * @description This parameter is required.
     *
     * @example 金额
     *
     * @var string
     */
    public $label;

    /**
     * @example 1
     *
     * @var string
     */
    public $upper;
    protected $_name = [
        'componentId' => 'componentId',
        'label'       => 'label',
        'upper'       => 'upper',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->upper) {
            $res['upper'] = $this->upper;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return statField
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['upper'])) {
            $model->upper = $map['upper'];
        }

        return $model;
    }
}
