<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConversationCategoryModel extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $categoryId;

    /**
     * @description This parameter is required.
     *
     * @example 分组
     *
     * @var string
     */
    public $categoryName;

    /**
     * @var \AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ConversationCategoryModel[]
     */
    public $children;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $levelNum;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $order;
    protected $_name = [
        'categoryId'   => 'categoryId',
        'categoryName' => 'categoryName',
        'children'     => 'children',
        'levelNum'     => 'levelNum',
        'order'        => 'order',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryId) {
            $res['categoryId'] = $this->categoryId;
        }
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
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
        if (null !== $this->levelNum) {
            $res['levelNum'] = $this->levelNum;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConversationCategoryModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryId'])) {
            $model->categoryId = $map['categoryId'];
        }
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['children'])) {
            if (!empty($map['children'])) {
                $model->children = [];
                $n               = 0;
                foreach ($map['children'] as $item) {
                    $model->children[$n++] = null !== $item ? self::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['levelNum'])) {
            $model->levelNum = $map['levelNum'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }

        return $model;
    }
}
