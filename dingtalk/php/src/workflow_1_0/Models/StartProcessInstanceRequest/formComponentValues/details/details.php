<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest\formComponentValues\details;

use AlibabaCloud\Tea\Model;

class details extends Model
{
    /**
     * @description 控件别名
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 控件类型
     *
     * @var string
     */
    public $componentType;

    /**
     * @description 控件扩展值
     *
     * @var string
     */
    public $extValue;

    /**
     * @description 控件id
     *
     * @var string
     */
    public $id;

    /**
     * @description 控件名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 控件值
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'bizAlias'      => 'bizAlias',
        'componentType' => 'componentType',
        'extValue'      => 'extValue',
        'id'            => 'id',
        'name'          => 'name',
        'value'         => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->componentType) {
            $res['componentType'] = $this->componentType;
        }
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
     * @return details
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['componentType'])) {
            $model->componentType = $map['componentType'];
        }
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
