<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards\todoCardView;

use AlibabaCloud\Tea\Model;

class todoCardContentList extends Model
{
    /**
     * @description 自定义表单内容名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 自定义表单内容值
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'name'  => 'name',
        'value' => 'value',
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
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return todoCardContentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
