<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersResponseBody\memberModels;
use AlibabaCloud\Tea\Model;

class QueryConferenceMembersResponseBody extends Model
{
    /**
     * @description 成员列表
     *
     * @var memberModels[]
     */
    public $memberModels;

    /**
     * @description 分页查询下一页token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 本次返回结果数
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'memberModels' => 'memberModels',
        'nextToken'    => 'nextToken',
        'totalCount'   => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberModels) {
            $res['memberModels'] = [];
            if (null !== $this->memberModels && \is_array($this->memberModels)) {
                $n = 0;
                foreach ($this->memberModels as $item) {
                    $res['memberModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryConferenceMembersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberModels'])) {
            if (!empty($map['memberModels'])) {
                $model->memberModels = [];
                $n                   = 0;
                foreach ($map['memberModels'] as $item) {
                    $model->memberModels[$n++] = null !== $item ? memberModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
