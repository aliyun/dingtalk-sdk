<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataDeleteResponseBody;

use AlibabaCloud\Tea\Model;

class failResult extends Model
{
    /**
     * @example uk123
     *
     * @var string
     */
    public $bizUK;

    /**
     * @example S0005
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example 主键冲突
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'bizUK' => 'bizUK',
        'errorCode' => 'errorCode',
        'errorMsg' => 'errorMsg',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizUK) {
            $res['bizUK'] = $this->bizUK;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return failResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizUK'])) {
            $model->bizUK = $map['bizUK'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
