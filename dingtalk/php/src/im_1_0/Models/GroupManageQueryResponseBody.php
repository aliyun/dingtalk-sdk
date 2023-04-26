<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageQueryResponseBody\groupInfoList;
use AlibabaCloud\Tea\Model;

class GroupManageQueryResponseBody extends Model
{
    /**
     * @var groupInfoList[]
     */
    public $groupInfoList;

    /**
     * @example true
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @example 500
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'groupInfoList' => 'groupInfoList',
        'hasMore'       => 'hasMore',
        'nextToken'     => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupInfoList) {
            $res['groupInfoList'] = [];
            if (null !== $this->groupInfoList && \is_array($this->groupInfoList)) {
                $n = 0;
                foreach ($this->groupInfoList as $item) {
                    $res['groupInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return GroupManageQueryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupInfoList'])) {
            if (!empty($map['groupInfoList'])) {
                $model->groupInfoList = [];
                $n                    = 0;
                foreach ($map['groupInfoList'] as $item) {
                    $model->groupInfoList[$n++] = null !== $item ? groupInfoList::fromMap($item) : $item;
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
