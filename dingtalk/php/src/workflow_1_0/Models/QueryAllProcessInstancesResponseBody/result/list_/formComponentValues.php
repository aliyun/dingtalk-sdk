<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_;

use AlibabaCloud\Tea\Model;

class formComponentValues extends Model
{
    /**
     * @description 控件名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 控件id
     *
     * @var string
     */
    public $id;

    /**
     * @description 控件数据
     *
     * @var string
     */
    public $value;

    /**
     * @description 控件扩展数据
     *
     * @var string
     */
    public $extValue;
    protected $_name = [
        'name'     => 'name',
        'id'       => 'id',
        'value'    => 'value',
        'extValue' => 'extValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->extValue) {
            $res['extValue'] = $this->extValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return formComponentValues
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['extValue'])) {
            $model->extValue = $map['extValue'];
        }

        return $model;
    }
}
