<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TemplateCategoriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $categoryStatus;

    /**
     * @example -1
     *
     * @var int
     */
    public $industryId;
    protected $_name = [
        'categoryStatus' => 'categoryStatus',
        'industryId' => 'industryId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryStatus) {
            $res['categoryStatus'] = $this->categoryStatus;
        }
        if (null !== $this->industryId) {
            $res['industryId'] = $this->industryId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryStatus'])) {
            $model->categoryStatus = $map['categoryStatus'];
        }
        if (isset($map['industryId'])) {
            $model->industryId = $map['industryId'];
        }

        return $model;
    }
}
