<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $bizPrimaryKey;

    /**
     * @var string
     */
    public $subErrCode;

    /**
     * @var string
     */
    public $subErrMsg;

    /**
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $triggerId;
    protected $_name = [
        'bizPrimaryKey' => 'bizPrimaryKey',
        'subErrCode'    => 'subErrCode',
        'subErrMsg'     => 'subErrMsg',
        'success'       => 'success',
        'triggerId'     => 'triggerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizPrimaryKey) {
            $res['bizPrimaryKey'] = $this->bizPrimaryKey;
        }
        if (null !== $this->subErrCode) {
            $res['subErrCode'] = $this->subErrCode;
        }
        if (null !== $this->subErrMsg) {
            $res['subErrMsg'] = $this->subErrMsg;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->triggerId) {
            $res['triggerId'] = $this->triggerId;
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
        if (isset($map['bizPrimaryKey'])) {
            $model->bizPrimaryKey = $map['bizPrimaryKey'];
        }
        if (isset($map['subErrCode'])) {
            $model->subErrCode = $map['subErrCode'];
        }
        if (isset($map['subErrMsg'])) {
            $model->subErrMsg = $map['subErrMsg'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['triggerId'])) {
            $model->triggerId = $map['triggerId'];
        }

        return $model;
    }
}
