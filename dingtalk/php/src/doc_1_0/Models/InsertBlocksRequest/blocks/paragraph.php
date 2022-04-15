<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph\children;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph\style;
use AlibabaCloud\Tea\Model;

class paragraph extends Model
{
    /**
     * @description 子节点
     *
     * @var children[]
     */
    public $children;

    /**
     * @description 段落样式
     *
     * @var style
     */
    public $style;
    protected $_name = [
        'children' => 'children',
        'style'    => 'style',
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
        if (null !== $this->style) {
            $res['style'] = null !== $this->style ? $this->style->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return paragraph
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
        if (isset($map['style'])) {
            $model->style = style::fromMap($map['style']);
        }

        return $model;
    }
}
