<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\FetchLoginStatusDevicesResponseBody\result;

use AlibabaCloud\Tea\Model;

class deviceList extends Model
{
    /**
     * @var int
     */
    public $actionTimestamp;

    /**
     * @var string
     */
    public $clientType;

    /**
     * @var bool
     */
    public $isLoggedIn;

    /**
     * @var string
     */
    public $openDeviceId;
    protected $_name = [
        'actionTimestamp' => 'actionTimestamp',
        'clientType' => 'clientType',
        'isLoggedIn' => 'isLoggedIn',
        'openDeviceId' => 'openDeviceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionTimestamp) {
            $res['actionTimestamp'] = $this->actionTimestamp;
        }
        if (null !== $this->clientType) {
            $res['clientType'] = $this->clientType;
        }
        if (null !== $this->isLoggedIn) {
            $res['isLoggedIn'] = $this->isLoggedIn;
        }
        if (null !== $this->openDeviceId) {
            $res['openDeviceId'] = $this->openDeviceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deviceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionTimestamp'])) {
            $model->actionTimestamp = $map['actionTimestamp'];
        }
        if (isset($map['clientType'])) {
            $model->clientType = $map['clientType'];
        }
        if (isset($map['isLoggedIn'])) {
            $model->isLoggedIn = $map['isLoggedIn'];
        }
        if (isset($map['openDeviceId'])) {
            $model->openDeviceId = $map['openDeviceId'];
        }

        return $model;
    }
}
