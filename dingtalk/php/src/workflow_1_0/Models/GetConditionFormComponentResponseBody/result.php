<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetConditionFormComponentResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 表单ID。
     *
     * @var string
     */
    public $id;

    /**
     * @description 表单名称。
     *
     * @var string
     */
    public $label;
    protected $_name = [
        'id'    => 'id',
        'label' => 'label',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }

        return $model;
    }
}
