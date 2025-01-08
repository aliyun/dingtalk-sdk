<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceBatchRequest\detailList;
use AlibabaCloud\Tea\Model;

class CreateTrustedDeviceBatchRequest extends Model
{
    /**
     * @var detailList[]
     */
    public $detailList;

    /**
     * @var string[]
     */
    public $macAddressList;

    /**
     * @description This parameter is required.
     *
     * @example Win
     *
     * @var string
     */
    public $platform;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'detailList'     => 'detailList',
        'macAddressList' => 'macAddressList',
        'platform'       => 'platform',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailList) {
            $res['detailList'] = [];
            if (null !== $this->detailList && \is_array($this->detailList)) {
                $n = 0;
                foreach ($this->detailList as $item) {
                    $res['detailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->macAddressList) {
            $res['macAddressList'] = $this->macAddressList;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTrustedDeviceBatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailList'])) {
            if (!empty($map['detailList'])) {
                $model->detailList = [];
                $n                 = 0;
                foreach ($map['detailList'] as $item) {
                    $model->detailList[$n++] = null !== $item ? detailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['macAddressList'])) {
            if (!empty($map['macAddressList'])) {
                $model->macAddressList = $map['macAddressList'];
            }
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
