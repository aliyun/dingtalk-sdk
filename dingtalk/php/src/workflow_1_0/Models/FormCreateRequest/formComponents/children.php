<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\props;
use AlibabaCloud\Tea\Model;

class children extends Model
{
    /**
     * @description 控件类型
     *
     * @var string
     */
    public $componentType;

    /**
     * @description 控件属性
     *
     * @var props
     */
    public $props;

    /**
     * @description 子控件列表
     *
     * @var \AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children[]
     */
    public $children;
    protected $_name = [
        'componentType' => 'componentType',
        'props'         => 'props',
        'children'      => 'children',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentType) {
            $res['componentType'] = $this->componentType;
        }
        if (null !== $this->props) {
            $res['props'] = null !== $this->props ? $this->props->toMap() : null;
        }
        if (null !== $this->children) {
            $res['children'] = [];
            if (null !== $this->children && \is_array($this->children)) {
                $n = 0;
                foreach ($this->children as $item) {
                    $res['children'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return children
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentType'])) {
            $model->componentType = $map['componentType'];
        }
        if (isset($map['props'])) {
            $model->props = props::fromMap($map['props']);
        }
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = [];
                $n               = 0;
                foreach ($map['children'] as $item) {
                    $model->children[$n++] = null !== $item ? \AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
