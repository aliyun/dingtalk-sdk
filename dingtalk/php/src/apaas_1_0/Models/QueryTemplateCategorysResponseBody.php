<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysResponseBody\categoryList;
use AlibabaCloud\Tea\Model;

class QueryTemplateCategorysResponseBody extends Model
{
    /**
     * @description 总数
     *
     * @var string
     */
    public $total;

    /**
     * @var categoryList[]
     */
    public $categoryList;
    protected $_name = [
        'total'        => 'total',
        'categoryList' => 'categoryList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }
        if (null !== $this->categoryList) {
            $res['categoryList'] = [];
            if (null !== $this->categoryList && \is_array($this->categoryList)) {
                $n = 0;
                foreach ($this->categoryList as $item) {
                    $res['categoryList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTemplateCategorysResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }
        if (isset($map['categoryList'])) {
            if (!empty($map['categoryList'])) {
                $model->categoryList = [];
                $n                   = 0;
                foreach ($map['categoryList'] as $item) {
                    $model->categoryList[$n++] = null !== $item ? categoryList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
