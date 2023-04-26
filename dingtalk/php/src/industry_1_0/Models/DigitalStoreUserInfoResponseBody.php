<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreUserInfoResponseBody extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @var int[]
     */
    public $roleIdList;

    /**
     * @example 5647993312
     *
     * @var int[]
     */
    public $scopeList;

    /**
     * @var int[]
     */
    public $storeList;

    /**
     * @example 331222222
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'       => 'name',
        'roleIdList' => 'roleIdList',
        'scopeList'  => 'scopeList',
        'storeList'  => 'storeList',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->roleIdList) {
            $res['roleIdList'] = $this->roleIdList;
        }
        if (null !== $this->scopeList) {
            $res['scopeList'] = $this->scopeList;
        }
        if (null !== $this->storeList) {
            $res['storeList'] = $this->storeList;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreUserInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['roleIdList'])) {
            if (!empty($map['roleIdList'])) {
                $model->roleIdList = $map['roleIdList'];
            }
        }
        if (isset($map['scopeList'])) {
            if (!empty($map['scopeList'])) {
                $model->scopeList = $map['scopeList'];
            }
        }
        if (isset($map['storeList'])) {
            if (!empty($map['storeList'])) {
                $model->storeList = $map['storeList'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
