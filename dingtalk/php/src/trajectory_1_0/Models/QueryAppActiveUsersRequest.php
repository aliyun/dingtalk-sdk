<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAppActiveUsersRequest extends Model
{
    /**
     * @description 本次读取的最大数据记录数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 是否需要返回位置信息
     *
     * @var bool
     */
    public $needPositionInfo;

    /**
     * @description 标记当前开始读取的位置，置空表示从头开始
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'maxResults'       => 'maxResults',
        'needPositionInfo' => 'needPositionInfo',
        'nextToken'        => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->needPositionInfo) {
            $res['needPositionInfo'] = $this->needPositionInfo;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAppActiveUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['needPositionInfo'])) {
            $model->needPositionInfo = $map['needPositionInfo'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
