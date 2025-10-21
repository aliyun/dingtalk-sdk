<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\GetLoginUserResponseBody\commodityInfo;
use AlibabaCloud\Tea\Model;

class GetLoginUserResponseBody extends Model
{
    /**
     * @var commodityInfo
     */
    public $commodityInfo;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $openId;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'commodityInfo' => 'commodityInfo',
        'corpId' => 'corpId',
        'openId' => 'openId',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commodityInfo) {
            $res['commodityInfo'] = null !== $this->commodityInfo ? $this->commodityInfo->toMap() : null;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->openId) {
            $res['openId'] = $this->openId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLoginUserResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commodityInfo'])) {
            $model->commodityInfo = commodityInfo::fromMap($map['commodityInfo']);
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['openId'])) {
            $model->openId = $map['openId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
