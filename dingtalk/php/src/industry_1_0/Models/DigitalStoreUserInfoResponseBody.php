<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreUserInfoResponseBody extends Model
{
    /**
     * @description 人员名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 管理范围
     *
     * @var int[]
     */
    public $scopeList;

    /**
     * @description 所在节点列表
     *
     * @var int[]
     */
    public $storeList;

    /**
     * @description 人员Id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'      => 'name',
        'scopeList' => 'scopeList',
        'storeList' => 'storeList',
        'userId'    => 'userId',
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
