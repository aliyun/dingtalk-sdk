<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTrustedDeviceBatchRequest extends Model
{
    /**
     * @description mac地址列表
     *
     * @var string[]
     */
    public $macAddressList;

    /**
     * @description 平台
     *
     * @var string
     */
    public $platform;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
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
