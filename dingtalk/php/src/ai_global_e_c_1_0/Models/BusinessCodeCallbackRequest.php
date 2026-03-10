<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\Tea\Model;

class BusinessCodeCallbackRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $businessCode;

    /**
     * @var string
     */
    public $eventType;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'businessCode' => 'businessCode',
        'eventType' => 'eventType',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessCode) {
            $res['businessCode'] = $this->businessCode;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BusinessCodeCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['businessCode'])) {
            $model->businessCode = $map['businessCode'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
