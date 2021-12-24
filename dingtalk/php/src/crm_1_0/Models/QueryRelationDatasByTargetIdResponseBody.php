<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdResponseBody\relations;
use AlibabaCloud\Tea\Model;

class QueryRelationDatasByTargetIdResponseBody extends Model
{
    /**
     * @description 关系数据。
     *
     * @var relations[]
     */
    public $relations;
    protected $_name = [
        'relations' => 'relations',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relations) {
            $res['relations'] = [];
            if (null !== $this->relations && \is_array($this->relations)) {
                $n = 0;
                foreach ($this->relations as $item) {
                    $res['relations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRelationDatasByTargetIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relations'])) {
            if (!empty($map['relations'])) {
                $model->relations = [];
                $n                = 0;
                foreach ($map['relations'] as $item) {
                    $model->relations[$n++] = null !== $item ? relations::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
