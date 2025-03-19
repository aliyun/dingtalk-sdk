<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\AddPluginRuleRequest;

use AlibabaCloud\Tea\Model;

class rules extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var string
     */
    public $itemId;

    /**
     * @description This parameter is required.
     *
     * @example 管理员角色
     *
     * @var string
     */
    public $itemName;
    protected $_name = [
        'itemId' => 'itemId',
        'itemName' => 'itemName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }

        return $model;
    }
}
