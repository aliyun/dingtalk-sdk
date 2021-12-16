<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList;
use AlibabaCloud\Tea\Model;

class DescribeRelationMetaResponseBody extends Model
{
    /**
     * @var relationMetaDTOList[]
     */
    public $relationMetaDTOList;
    protected $_name = [
        'relationMetaDTOList' => 'relationMetaDTOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relationMetaDTOList) {
            $res['relationMetaDTOList'] = [];
            if (null !== $this->relationMetaDTOList && \is_array($this->relationMetaDTOList)) {
                $n = 0;
                foreach ($this->relationMetaDTOList as $item) {
                    $res['relationMetaDTOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DescribeRelationMetaResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relationMetaDTOList'])) {
            if (!empty($map['relationMetaDTOList'])) {
                $model->relationMetaDTOList = [];
                $n                          = 0;
                foreach ($map['relationMetaDTOList'] as $item) {
                    $model->relationMetaDTOList[$n++] = null !== $item ? relationMetaDTOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
