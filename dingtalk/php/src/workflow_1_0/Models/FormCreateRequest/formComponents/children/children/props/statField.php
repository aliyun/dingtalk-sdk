<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children\props;

use AlibabaCloud\Tea\Model;

class statField extends Model
{
    /**
     * @var string
     */
    public $componentId;

    /**
     * @var string
     */
    public $label;

    /**
     * @var bool
     */
    public $upper;

    /**
     * @var string
     */
    public $payEnable;
    protected $_name = [
        'componentId' => 'componentId',
        'label'       => 'label',
        'upper'       => 'upper',
        'payEnable'   => 'payEnable',
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
        if (null !== $this->payEnable) {
            $res['payEnable'] = $this->payEnable;
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
        if (isset($map['payEnable'])) {
            $model->payEnable = $map['payEnable'];
        }

        return $model;
    }
}
