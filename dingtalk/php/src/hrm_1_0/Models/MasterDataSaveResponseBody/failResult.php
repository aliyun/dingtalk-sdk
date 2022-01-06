<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveResponseBody;

use AlibabaCloud\Tea\Model;

class failResult extends Model
{
    /**
     * @description 业务流水唯一标识，和入参一致
     *
     * @var string
     */
    public $bizUk;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;

    /**
     * @description 错误码
     *
     * @var string
     */
    public $errorCode;

    /**
     * @description 错误信息
     *
     * @var string
     */
    public $errorMsg;
    protected $_name = [
        'bizUk'     => 'bizUk',
        'success'   => 'success',
        'errorCode' => 'errorCode',
        'errorMsg'  => 'errorMsg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizUk) {
            $res['bizUk'] = $this->bizUk;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
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
        if (isset($map['bizUk'])) {
            $model->bizUk = $map['bizUk'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }

        return $model;
    }
}
