<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class PagePointHistoryRequest extends Model
{
    /**
     * @description 是否查询全员圈积分
     *
     * @var bool
     */
    public $isCircle;

    /**
     * @description 用户userid，可空，不传表示查询组织内所有用户的流水数据
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用来标记当前开始读取的位置
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 本次读取的最大数据记录数量，最大20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 起始时间Unix时间戳，可空
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 结束时间Unix时间戳（不包含），可空
     *
     * @var int
     */
    public $endTime;
    protected $_name = [
        'isCircle'   => 'isCircle',
        'userId'     => 'userId',
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
        'startTime'  => 'startTime',
        'endTime'    => 'endTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isCircle) {
            $res['isCircle'] = $this->isCircle;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PagePointHistoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isCircle'])) {
            $model->isCircle = $map['isCircle'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }

        return $model;
    }
}
