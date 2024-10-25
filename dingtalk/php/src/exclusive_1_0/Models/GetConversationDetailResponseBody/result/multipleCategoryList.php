<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConversationDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class multipleCategoryList extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $categoryId;

    /**
     * @example 全部
     *
     * @var string
     */
    public $categoryName;

    /**
     * @var int
     */
    public $order;
    protected $_name = [
        'categoryId'   => 'categoryId',
        'categoryName' => 'categoryName',
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
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return multipleCategoryList
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
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }

        return $model;
    }
}
