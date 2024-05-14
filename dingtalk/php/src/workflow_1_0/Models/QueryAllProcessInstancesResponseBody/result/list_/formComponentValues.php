<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_;

use AlibabaCloud\Tea\Model;

class formComponentValues extends Model
{
    /**
     * @example {"staffId":"abcd"}
     *
     * @var string
     */
    public $extValue;

    /**
     * @description This parameter is required.
     *
     * @example TextField-a32bcdef
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'extValue' => 'extValue',
        'id'       => 'id',
        'name'     => 'name',
        'value'    => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extValue) {
            $res['extValue'] = $this->extValue;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
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
        if (isset($map['extValue'])) {
            $model->extValue = $map['extValue'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
