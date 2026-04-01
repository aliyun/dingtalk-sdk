<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckOrderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example corp1234
     *
     * @var string
     */
    public $channelCorpId;

    /**
     * @example be5f1dce-5a15-451a-8be5-2bfe8836b2c3
     *
     * @var string
     */
    public $journeyBizNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $orderType;

    /**
     * @description This parameter is required.
     *
     * @example ljzvGcPYSkyqZ6FsbziK4w10171764232149
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description This parameter is required.
     *
     * @example 1234
     *
     * @var string
     */
    public $staffId;
    protected $_name = [
        'channelCorpId' => 'channelCorpId',
        'journeyBizNo' => 'journeyBizNo',
        'orderType' => 'orderType',
        'processInstanceId' => 'processInstanceId',
        'staffId' => 'staffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCorpId) {
            $res['channelCorpId'] = $this->channelCorpId;
        }
        if (null !== $this->journeyBizNo) {
            $res['journeyBizNo'] = $this->journeyBizNo;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCorpId'])) {
            $model->channelCorpId = $map['channelCorpId'];
        }
        if (isset($map['journeyBizNo'])) {
            $model->journeyBizNo = $map['journeyBizNo'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
