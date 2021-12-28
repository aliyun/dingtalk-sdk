<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormComponentProps;

use AlibabaCloud\Tea\Model;

class statField extends Model
{
    /**
     * @description 需要统计的明细控件内子控件id
     *
     * @var string
     */
    public $componentId;

    /**
     * @description 子控件标题
     *
     * @var string
     */
    public $label;

    /**
     * @description 金额控件是否需要大写，1不需要大写，其他需要大写
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
