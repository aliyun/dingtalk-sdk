<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentSubDeptsResponseBody\departmentList;
use AlibabaCloud\Tea\Model;

class ListResidentSubDeptsResponseBody extends Model
{
    /**
     * @description 组户列表
     *
     * @var departmentList[]
     */
    public $departmentList;

    /**
     * @description 是否还有记录
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 游标
     *
     * @var int
     */
    public $nextCursor;

    /**
     * @description 总数
     *
     * @var int
     */
    public $total;
    protected $_name = [
        'departmentList' => 'departmentList',
        'hasMore'        => 'hasMore',
        'nextCursor'     => 'nextCursor',
        'total'          => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentList) {
            $res['departmentList'] = [];
            if (null !== $this->departmentList && \is_array($this->departmentList)) {
                $n = 0;
                foreach ($this->departmentList as $item) {
                    $res['departmentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListResidentSubDeptsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentList'])) {
            if (!empty($map['departmentList'])) {
                $model->departmentList = [];
                $n                     = 0;
                foreach ($map['departmentList'] as $item) {
                    $model->departmentList[$n++] = null !== $item ? departmentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
