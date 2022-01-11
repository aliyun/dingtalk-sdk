<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\ListSearchTabsByOrgIdResponseBody\searchTabResult;
use AlibabaCloud\Tea\Model;

class ListSearchTabsByOrgIdResponseBody extends Model
{
    /**
     * @description 该企业拥有的所有数据源信息
     *
     * @var searchTabResult[]
     */
    public $searchTabResult;
    protected $_name = [
        'searchTabResult' => 'searchTabResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->searchTabResult) {
            $res['searchTabResult'] = [];
            if (null !== $this->searchTabResult && \is_array($this->searchTabResult)) {
                $n = 0;
                foreach ($this->searchTabResult as $item) {
                    $res['searchTabResult'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSearchTabsByOrgIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['searchTabResult'])) {
            if (!empty($map['searchTabResult'])) {
                $model->searchTabResult = [];
                $n                      = 0;
                foreach ($map['searchTabResult'] as $item) {
                    $model->searchTabResult[$n++] = null !== $item ? searchTabResult::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
