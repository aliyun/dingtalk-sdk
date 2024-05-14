<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoryTemplatesRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example categoryId
     *
     * @var string
     */
    public $categoryId;
    protected $_name = [
        'categoryId' => 'categoryId',
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
        if (isset($map['categoryId'])) {
            $model->categoryId = $map['categoryId'];
        }

        return $model;
    }
}
