<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdResponseBody\empList;
use AlibabaCloud\Tea\Model;

class GetEmpsByOrgIdResponseBody extends Model
{
    /**
     * @description empList
     *
     * @var empList[]
     */
    public $empList;

    /**
     * @description hasMore
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'empList'   => 'empList',
        'hasMore'   => 'hasMore',
        'nextToken' => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->empList) {
            $res['empList'] = [];
            if (null !== $this->empList && \is_array($this->empList)) {
                $n = 0;
                foreach ($this->empList as $item) {
                    $res['empList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEmpsByOrgIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['empList'])) {
            if (!empty($map['empList'])) {
                $model->empList = [];
                $n              = 0;
                foreach ($map['empList'] as $item) {
                    $model->empList[$n++] = null !== $item ? empList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
