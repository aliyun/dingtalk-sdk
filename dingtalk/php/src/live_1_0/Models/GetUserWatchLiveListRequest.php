<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserWatchLiveListRequest extends Model
{
    /**
     * @description 过滤类型，0：不过滤， 1：过滤已经看完的
     *
     * @var int
     */
    public $filterType;

    /**
     * @description 单次拉去上限，默认40个
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标 第一次可不填， 后面填回包的值
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 用户uid
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'filterType' => 'filterType',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->filterType) {
            $res['filterType'] = $this->filterType;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserWatchLiveListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['filterType'])) {
            $model->filterType = $map['filterType'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
