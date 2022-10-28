<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateJobDeliverRequest extends Model
{
    /**
     * @description 招聘业务标识，目前固定ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 渠道侧职位唯一标识
     *
     * @var string
     */
    public $channelOuterId;

    /**
     * @description 渠道侧错误码
     *
     * @var string
     */
    public $errorCode;

    /**
     * @description 渠道侧错误信息
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @description 操作时间
     *
     * @var int
     */
    public $opTime;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 职位投递状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 钉钉侧职位唯一标识
     *
     * @var string
     */
    public $jobId;
    protected $_name = [
        'bizCode'        => 'bizCode',
        'channelOuterId' => 'channelOuterId',
        'errorCode'      => 'errorCode',
        'errorMsg'       => 'errorMsg',
        'opTime'         => 'opTime',
        'opUserId'       => 'opUserId',
        'status'         => 'status',
        'corpId'         => 'corpId',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }

        return $model;
    }
}
