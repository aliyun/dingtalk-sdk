<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSimpleCubeModelListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSimpleCubeModelListResponseBody\result\children;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var children[]
     */
    public $children;

    /**
     * @example 12345
     *
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $isDimension;

    /**
     * @var string
     */
    public $text;
    protected $_name = [
        'children'    => 'children',
        'id'          => 'id',
        'isDimension' => 'isDimension',
        'text'        => 'text',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDimension) {
            $res['isDimension'] = $this->isDimension;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
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
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = [];
                $n               = 0;
                foreach ($map['children'] as $item) {
                    $model->children[$n++] = null !== $item ? children::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDimension'])) {
            $model->isDimension = $map['isDimension'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
