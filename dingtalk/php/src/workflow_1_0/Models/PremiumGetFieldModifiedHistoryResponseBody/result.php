<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetFieldModifiedHistoryResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2024-04-02T11:52Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example TextField-abcd
     *
     * @var string
     */
    public $fieldId;

    /**
     * @example 钉钉1
     *
     * @var string
     */
    public $name;

    /**
     * @example userId1
     *
     * @var string
     */
    public $userId;

    /**
     * @example 从 111 修改到 222
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'createTime' => 'createTime',
        'fieldId' => 'fieldId',
        'name' => 'name',
        'userId' => 'userId',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
