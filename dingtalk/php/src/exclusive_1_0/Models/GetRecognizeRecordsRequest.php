<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRecognizeRecordsRequest extends Model
{
    /**
     * @description 应用唯一标识
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 人脸对比结果 1-成功 2-失败
     *
     * @var int
     */
    public $faceCompareResult;

    /**
     * @description 记录开始时间(毫秒时间戳)
     *
     * @var int
     */
    public $fromTime;

    /**
     * @description 一页最大值（最大50）
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 查询数据的起始位置，0表示从头开始。
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 记录结束时间(毫秒时间戳)
     *
     * @var int
     */
    public $toTime;

    /**
     * @description 员工userIds
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'agentId'           => 'agentId',
        'faceCompareResult' => 'faceCompareResult',
        'fromTime'          => 'fromTime',
        'maxResults'        => 'maxResults',
        'nextToken'         => 'nextToken',
        'toTime'            => 'toTime',
        'userIds'           => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->faceCompareResult) {
            $res['faceCompareResult'] = $this->faceCompareResult;
        }
        if (null !== $this->fromTime) {
            $res['fromTime'] = $this->fromTime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->toTime) {
            $res['toTime'] = $this->toTime;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRecognizeRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['faceCompareResult'])) {
            $model->faceCompareResult = $map['faceCompareResult'];
        }
        if (isset($map['fromTime'])) {
            $model->fromTime = $map['fromTime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['toTime'])) {
            $model->toTime = $map['toTime'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
