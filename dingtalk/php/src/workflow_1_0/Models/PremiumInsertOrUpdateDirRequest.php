<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class PremiumInsertOrUpdateDirRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example administeration
     *
     * @var string
     */
    public $bizGroup;

    /**
     * @example 分组描述信息
     *
     * @var string
     */
    public $description;

    /**
     * @description This parameter is required.
     *
     * @example 行政管理
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example {\"en_US\":\"test\",\"ja_JP\":\"test\",\"vi_VN\":\"test\",\"zh_CN\":\"测试\",\"zh_HK\":\"测试\",\"zh_TW\":\"测试\"}
     *
     * @var string
     */
    public $name18n;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $operateUserId;
    protected $_name = [
        'bizGroup' => 'bizGroup',
        'description' => 'description',
        'name' => 'name',
        'name18n' => 'name18n',
        'operateUserId' => 'operateUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizGroup) {
            $res['bizGroup'] = $this->bizGroup;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->name18n) {
            $res['name18n'] = $this->name18n;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumInsertOrUpdateDirRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizGroup'])) {
            $model->bizGroup = $map['bizGroup'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['name18n'])) {
            $model->name18n = $map['name18n'];
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }

        return $model;
    }
}
