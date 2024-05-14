<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoriesTemplatesRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example categoryIds
     *
     * @var string[]
     */
    public $categoryIds;
    protected $_name = [
        'categoryIds' => 'categoryIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryIds) {
            $res['categoryIds'] = $this->categoryIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryIds'])) {
            if (!empty($map['categoryIds'])) {
                $model->categoryIds = $map['categoryIds'];
            }
        }

        return $model;
    }
}
