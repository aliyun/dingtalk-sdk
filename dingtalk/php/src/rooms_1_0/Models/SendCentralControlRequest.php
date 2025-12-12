<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendCentralControlRequest extends Model
{
    /**
     * @example {   "version": "1.0.0",    "request": {     "requestId": "xxxx",      "service": "DTRooms.Meeting",      "method": "subscribe"    } }
     *
     * @var string
     */
    public $controlBody;

    /**
     * @example 0ffb7xxxxx
     *
     * @var string
     */
    public $roomId;

    /**
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'controlBody' => 'controlBody',
        'roomId' => 'roomId',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->controlBody) {
            $res['controlBody'] = $this->controlBody;
        }
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendCentralControlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['controlBody'])) {
            $model->controlBody = $map['controlBody'];
        }
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
