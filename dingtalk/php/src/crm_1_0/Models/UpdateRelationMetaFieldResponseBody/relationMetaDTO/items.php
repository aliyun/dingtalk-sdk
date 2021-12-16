<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldResponseBody\relationMetaDTO;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldResponseBody\relationMetaDTO\items\children;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldResponseBody\relationMetaDTO\items\props;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var children[]
     */
    public $children;

    /**
     * @var string
     */
    public $componentName;

    /**
     * @var props[]
     */
    public $props;
    protected $_name = [
        'children'      => 'children',
        'componentName' => 'componentName',
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
        if (null !== $this->componentName) {
            $res['componentName'] = $this->componentName;
        }
        if (null !== $this->props) {
            $res['props'] = [];
            if (null !== $this->props && \is_array($this->props)) {
                $n = 0;
                foreach ($this->props as $item) {
                    $res['props'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = [];
                $n               = 0;
                foreach ($map['children'] as $item) {
                    $model->children[$n++] = null !== $item ? children::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['componentName'])) {
            $model->componentName = $map['componentName'];
        }
        if (isset($map['props'])) {
            if (!empty($map['props'])) {
                $model->props = [];
                $n            = 0;
                foreach ($map['props'] as $item) {
                    $model->props[$n++] = null !== $item ? props::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
