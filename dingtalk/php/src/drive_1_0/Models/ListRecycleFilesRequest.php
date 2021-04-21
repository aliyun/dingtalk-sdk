<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListRecycleFilesRequest extends Model
{
    /**
     * @description 回收站类型
     *
     * @var string
     */
    public $recycleType;

    /**
     * @description 分页加载更多锚点
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 分页长度
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 文件排序类型
     *
     * @var string
     */
    public $orderType;
    protected $_name = [
        'recycleType' => 'recycleType',
        'nextToken'   => 'nextToken',
        'maxResults'  => 'maxResults',
        'orderType'   => 'orderType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recycleType) {
            $res['recycleType'] = $this->recycleType;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRecycleFilesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recycleType'])) {
            $model->recycleType = $map['recycleType'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }

        return $model;
    }
}
