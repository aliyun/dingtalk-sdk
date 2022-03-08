<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveUserExtendValuesRequest extends Model
{
    /**
     * @description 字段展示名称
     *
     * @var string
     */
    public $userDisplayName;

    /**
     * @description 用户拓展字段key
     *
     * @var string
     */
    public $userExtendKey;

    /**
     * @description 用户扩展字段value
     *
     * @var string
     */
    public $userExtendValue;
    protected $_name = [
        'userDisplayName' => 'userDisplayName',
        'userExtendKey'   => 'userExtendKey',
        'userExtendValue' => 'userExtendValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userDisplayName) {
            $res['userDisplayName'] = $this->userDisplayName;
        }
        if (null !== $this->userExtendKey) {
            $res['userExtendKey'] = $this->userExtendKey;
        }
        if (null !== $this->userExtendValue) {
            $res['userExtendValue'] = $this->userExtendValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveUserExtendValuesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userDisplayName'])) {
            $model->userDisplayName = $map['userDisplayName'];
        }
        if (isset($map['userExtendKey'])) {
            $model->userExtendKey = $map['userExtendKey'];
        }
        if (isset($map['userExtendValue'])) {
            $model->userExtendValue = $map['userExtendValue'];
        }

        return $model;
    }
}
