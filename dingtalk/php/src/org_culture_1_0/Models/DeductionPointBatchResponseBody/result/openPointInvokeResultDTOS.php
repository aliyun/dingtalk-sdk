<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\DeductionPointBatchResponseBody\result;

use AlibabaCloud\Tea\Model;

class openPointInvokeResultDTOS extends Model
{
    /**
     * @example banliang#-20005
     *
     * @var string
     */
    public $code;

    /**
     * @example Fail
     *
     * @var string
     */
    public $invokeStatus;

    /**
     * @example freeze already settle
     *
     * @var string
     */
    public $msg;

    /**
     * @example 34345435345
     *
     * @var string
     */
    public $outId;

    /**
     * @example 01274411491620908910
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
