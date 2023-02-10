<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubscribeEventRequest extends Model
{
    /**
     * @description 订阅范围
     * SPACE: 空间
     * @var string
     */
    public $scope;

    /**
     * @description 订阅范围对应的id
     * scope为SPACE时，scopeId对应的是空间id
     * @var string
     */
    public $scopeId;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'scope'   => 'scope',
        'scopeId' => 'scopeId',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        if (null !== $this->scopeId) {
            $res['scopeId'] = $this->scopeId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubscribeEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }
        if (isset($map['scopeId'])) {
            $model->scopeId = $map['scopeId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
