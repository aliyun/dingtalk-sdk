<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFlowByIdResponseBody extends Model
{
    /**
     * @var string
     */
    public $candidateId;

    /**
     * @var string
     */
    public $candidateName;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $currentStatus;

    /**
     * @var string
     */
    public $flowId;

    /**
     * @var string
     */
    public $jobId;

    /**
     * @var string
     */
    public $sourceName;

    /**
     * @var string
     */
    public $statId;
    protected $_name = [
        'candidateId' => 'candidateId',
        'candidateName' => 'candidateName',
        'createTime' => 'createTime',
        'currentStatus' => 'currentStatus',
        'flowId' => 'flowId',
        'jobId' => 'jobId',
        'sourceName' => 'sourceName',
        'statId' => 'statId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->candidateId) {
            $res['candidateId'] = $this->candidateId;
        }
        if (null !== $this->candidateName) {
            $res['candidateName'] = $this->candidateName;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->currentStatus) {
            $res['currentStatus'] = $this->currentStatus;
        }
        if (null !== $this->flowId) {
            $res['flowId'] = $this->flowId;
        }
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }
        if (null !== $this->sourceName) {
            $res['sourceName'] = $this->sourceName;
        }
        if (null !== $this->statId) {
            $res['statId'] = $this->statId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFlowByIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['candidateId'])) {
            $model->candidateId = $map['candidateId'];
        }
        if (isset($map['candidateName'])) {
            $model->candidateName = $map['candidateName'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['currentStatus'])) {
            $model->currentStatus = $map['currentStatus'];
        }
        if (isset($map['flowId'])) {
            $model->flowId = $map['flowId'];
        }
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }
        if (isset($map['sourceName'])) {
            $model->sourceName = $map['sourceName'];
        }
        if (isset($map['statId'])) {
            $model->statId = $map['statId'];
        }

        return $model;
    }
}
