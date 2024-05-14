<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateJobDeliverRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example channelOuterId
     *
     * @var string
     */
    public $channelOuterId;

    /**
     * @description This parameter is required.
     *
     * @example 27016066248xxxxx
     *
     * @var string
     */
    public $deliverUserId;

    /**
     * @example ATS001
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example 职位审核不通过
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @description This parameter is required.
     *
     * @example 1666780239981
     *
     * @var int
     */
    public $opTime;

    /**
     * @example 27016066248xxxxx
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example jobId23ed0d46548f4e88a7b808d3f3057xxx
     *
     * @var string
     */
    public $jobId;
    protected $_name = [
        'bizCode'        => 'bizCode',
        'channelOuterId' => 'channelOuterId',
        'deliverUserId'  => 'deliverUserId',
        'errorCode'      => 'errorCode',
        'errorMsg'       => 'errorMsg',
        'opTime'         => 'opTime',
        'opUserId'       => 'opUserId',
        'status'         => 'status',
        'jobId'          => 'jobId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->channelOuterId) {
            $res['channelOuterId'] = $this->channelOuterId;
        }
        if (null !== $this->deliverUserId) {
            $res['deliverUserId'] = $this->deliverUserId;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->opTime) {
            $res['opTime'] = $this->opTime;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateJobDeliverRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['channelOuterId'])) {
            $model->channelOuterId = $map['channelOuterId'];
        }
        if (isset($map['deliverUserId'])) {
            $model->deliverUserId = $map['deliverUserId'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['opTime'])) {
            $model->opTime = $map['opTime'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }

        return $model;
    }
}
