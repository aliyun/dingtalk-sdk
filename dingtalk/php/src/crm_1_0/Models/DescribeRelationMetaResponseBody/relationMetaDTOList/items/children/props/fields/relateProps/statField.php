<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\fields\relateProps;

use AlibabaCloud\Tea\Model;

class statField extends Model
{
    /**
     * @var string
     */
    public $fieldId;

    /**
     * @var string
     */
    public $label;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var bool
     */
    public $upper;
    protected $_name = [
        'fieldId' => 'fieldId',
        'label'   => 'label',
        'unit'    => 'unit',
        'upper'   => 'upper',
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
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
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
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['upper'])) {
            $model->upper = $map['upper'];
        }

        return $model;
    }
}
