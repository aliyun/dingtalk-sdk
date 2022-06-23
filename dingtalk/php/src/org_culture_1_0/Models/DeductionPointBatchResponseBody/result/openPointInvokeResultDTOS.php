<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\DeductionPointBatchResponseBody\result;

use AlibabaCloud\Tea\Model;

class openPointInvokeResultDTOS extends Model
{
    /**
     * @description 错误码
     *
     * @var string
     */
    public $code;

    /**
     * @description 状态 success：成功。 Fail：失败 UNKNOWN:结果未知
     *
     * @var string
     */
    public $invokeStatus;

    /**
     * @description 错误信息
     *
     * @var string
     */
    public $msg;

    /**
     * @description 积分交易单号
     *
     * @var string
     */
    public $outId;

    /**
     * @description 扣减用户userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'code'         => 'code',
        'invokeStatus' => 'invokeStatus',
        'msg'          => 'msg',
        'outId'        => 'outId',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->invokeStatus) {
            $res['invokeStatus'] = $this->invokeStatus;
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }
        if (null !== $this->outId) {
            $res['outId'] = $this->outId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openPointInvokeResultDTOS
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['invokeStatus'])) {
            $model->invokeStatus = $map['invokeStatus'];
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }
        if (isset($map['outId'])) {
            $model->outId = $map['outId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
