<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $triggerId;

    /**
     * @var string
     */
    public $bizPrimaryKey;

    /**
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $subErrCode;

    /**
     * @var string
     */
    public $subErrMsg;
    protected $_name = [
        'triggerId'     => 'triggerId',
        'bizPrimaryKey' => 'bizPrimaryKey',
        'success'       => 'success',
        'subErrCode'    => 'subErrCode',
        'subErrMsg'     => 'subErrMsg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->triggerId) {
            $res['triggerId'] = $this->triggerId;
        }
        if (null !== $this->bizPrimaryKey) {
            $res['bizPrimaryKey'] = $this->bizPrimaryKey;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->subErrCode) {
            $res['subErrCode'] = $this->subErrCode;
        }
        if (null !== $this->subErrMsg) {
            $res['subErrMsg'] = $this->subErrMsg;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['triggerId'])) {
            $model->triggerId = $map['triggerId'];
        }
        if (isset($map['bizPrimaryKey'])) {
            $model->bizPrimaryKey = $map['bizPrimaryKey'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['subErrCode'])) {
            $model->subErrCode = $map['subErrCode'];
        }
        if (isset($map['subErrMsg'])) {
            $model->subErrMsg = $map['subErrMsg'];
        }

        return $model;
    }
}
