<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody\applyList;
use AlibabaCloud\Tea\Model;

class QueryCityCarApplyResponseBody extends Model
{
    /**
     * @description 审批单列表
     *
     * @var applyList[]
     */
    public $applyList;

    /**
     * @description 总数
     *
     * @var int
     */
    public $total;
    protected $_name = [
        'applyList' => 'applyList',
        'total'     => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->applyList) {
            $res['applyList'] = [];
            if (null !== $this->applyList && \is_array($this->applyList)) {
                $n = 0;
                foreach ($this->applyList as $item) {
                    $res['applyList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCityCarApplyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applyList'])) {
            if (!empty($map['applyList'])) {
                $model->applyList = [];
                $n                = 0;
                foreach ($map['applyList'] as $item) {
                    $model->applyList[$n++] = null !== $item ? applyList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
