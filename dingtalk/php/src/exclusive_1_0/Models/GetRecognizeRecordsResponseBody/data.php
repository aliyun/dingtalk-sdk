<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRecognizeRecordsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example agentId
     *
     * @var int
     */
    public $agentId;

    /**
     * @example 1
     *
     * @var int
     */
    public $faceCompareResult;

    /**
     * @example 166700000
     *
     * @var int
     */
    public $invokeTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $platform;

    /**
     * @example 1234
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agentId' => 'agentId',
        'faceCompareResult' => 'faceCompareResult',
        'invokeTime' => 'invokeTime',
        'platform' => 'platform',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->faceCompareResult) {
            $res['faceCompareResult'] = $this->faceCompareResult;
        }
        if (null !== $this->invokeTime) {
            $res['invokeTime'] = $this->invokeTime;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
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
        if (isset($map['invokeTime'])) {
            $model->invokeTime = $map['invokeTime'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
