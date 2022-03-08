<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class FormComponent extends Model
{
    /**
     * @description 子控件集合
     *
     * @var \AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormComponent[]
     */
    public $children;

    /**
     * @description 控件类型
     *
     * @var string
     */
    public $componentType;

    /**
     * @description 控件属性
     *
     * @var FormComponentProps
     */
    public $props;
    protected $_name = [
        'children'      => 'children',
        'componentType' => 'componentType',
        'props'         => 'props',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->children) {
            $res['children'] = [];
            if (null !== $this->children && \is_array($this->children)) {
                $n = 0;
                foreach ($this->children as $item) {
                    $res['children'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->componentType) {
            $res['componentType'] = $this->componentType;
        }
        if (null !== $this->props) {
            $res['props'] = null !== $this->props ? $this->props->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FormComponent
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = [];
                $n               = 0;
                foreach ($map['children'] as $item) {
                    $model->children[$n++] = null !== $item ? self::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['componentType'])) {
            $model->componentType = $map['componentType'];
        }
        if (isset($map['props'])) {
            $model->props = FormComponentProps::fromMap($map['props']);
        }

        return $model;
    }
}
