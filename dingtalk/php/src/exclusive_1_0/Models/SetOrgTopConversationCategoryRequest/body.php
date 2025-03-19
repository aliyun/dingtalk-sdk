<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetOrgTopConversationCategoryRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @example 123111
     *
     * @var int
     */
    public $categoryId;

    /**
     * @description This parameter is required.
     *
     * @example 重要保障
     *
     * @var string
     */
    public $categoryName;

    /**
     * @example 1
     *
     * @var int
     */
    public $order;
    protected $_name = [
        'categoryId' => 'categoryId',
        'categoryName' => 'categoryName',
        'order' => 'order',
    ];

    public function validate() {}

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
     * @return body
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
