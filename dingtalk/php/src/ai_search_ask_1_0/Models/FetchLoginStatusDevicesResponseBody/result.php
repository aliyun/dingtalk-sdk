<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\FetchLoginStatusDevicesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\FetchLoginStatusDevicesResponseBody\result\deviceList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var deviceList[]
     */
    public $deviceList;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'deviceList' => 'deviceList',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceList) {
            $res['deviceList'] = [];
            if (null !== $this->deviceList && \is_array($this->deviceList)) {
                $n = 0;
                foreach ($this->deviceList as $item) {
                    $res['deviceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceList'])) {
            if (!empty($map['deviceList'])) {
                $model->deviceList = [];
                $n = 0;
                foreach ($map['deviceList'] as $item) {
                    $model->deviceList[$n++] = null !== $item ? deviceList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
