<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelCategoryUpdateRequest\categoryVo;
use AlibabaCloud\Tea\Model;

class HrbrainLabelCategoryUpdateRequest extends Model
{
    /**
     * @var categoryVo
     */
    public $categoryVo;
    protected $_name = [
        'categoryVo' => 'categoryVo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryVo) {
            $res['categoryVo'] = null !== $this->categoryVo ? $this->categoryVo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainLabelCategoryUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryVo'])) {
            $model->categoryVo = categoryVo::fromMap($map['categoryVo']);
        }

        return $model;
    }
}
