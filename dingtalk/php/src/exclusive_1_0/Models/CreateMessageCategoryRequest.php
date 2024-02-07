<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateMessageCategoryRequest extends Model
{
    /**
     * @var string
     */
    public $categoryName;

    /**
     * @var string[]
     */
    public $groupIds;
    protected $_name = [
        'categoryName' => 'categoryName',
        'groupIds'     => 'groupIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
        }
        if (null !== $this->groupIds) {
            $res['groupIds'] = $this->groupIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMessageCategoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['groupIds'])) {
            if (!empty($map['groupIds'])) {
                $model->groupIds = $map['groupIds'];
            }
        }

        return $model;
    }
}
