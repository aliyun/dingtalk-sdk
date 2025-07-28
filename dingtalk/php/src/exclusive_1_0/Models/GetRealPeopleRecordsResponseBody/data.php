<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRealPeopleRecordsResponseBody;

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
    public $personIdentification;

    /**
     * @example 1
     *
     * @var int
     */
    public $platform;

    /**
     * @example 1
     *
     * @var int
     */
    public $scene;

    /**
     * @example 1234
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agentId' => 'agentId',
        'invokeTime' => 'invokeTime',
        'personIdentification' => 'personIdentification',
        'platform' => 'platform',
        'scene' => 'scene',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->invokeTime) {
            $res['invokeTime'] = $this->invokeTime;
        }
        if (null !== $this->personIdentification) {
            $res['personIdentification'] = $this->personIdentification;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
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
        if (isset($map['invokeTime'])) {
            $model->invokeTime = $map['invokeTime'];
        }
        if (isset($map['personIdentification'])) {
            $model->personIdentification = $map['personIdentification'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
