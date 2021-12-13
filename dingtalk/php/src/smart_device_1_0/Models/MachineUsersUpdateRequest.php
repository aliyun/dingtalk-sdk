<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class MachineUsersUpdateRequest extends Model
{
    /**
     * @description 移除的员工id列表
     *
     * @var string[]
     */
    public $delUserIds;

    /**
     * @description 设备唯一标识id列表，字符串数组
     *
     * @var string[]
     */
    public $deviceIds;

    /**
     * @description 新增的员工id列表
     *
     * @var string[]
     */
    public $addUserIds;

    /**
     * @description 设备唯一标识id列表，Long数组
     *
     * @var int[]
     */
    public $devIds;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;
    protected $_name = [
        'delUserIds'         => 'delUserIds',
        'deviceIds'          => 'deviceIds',
        'addUserIds'         => 'addUserIds',
        'devIds'             => 'devIds',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingCorpId'         => 'dingCorpId',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->delUserIds) {
            $res['delUserIds'] = $this->delUserIds;
        }
        if (null !== $this->deviceIds) {
            $res['deviceIds'] = $this->deviceIds;
        }
        if (null !== $this->addUserIds) {
            $res['addUserIds'] = $this->addUserIds;
        }
        if (null !== $this->devIds) {
            $res['devIds'] = $this->devIds;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MachineUsersUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['delUserIds'])) {
            if (!empty($map['delUserIds'])) {
                $model->delUserIds = $map['delUserIds'];
            }
        }
        if (isset($map['deviceIds'])) {
            if (!empty($map['deviceIds'])) {
                $model->deviceIds = $map['deviceIds'];
            }
        }
        if (isset($map['addUserIds'])) {
            if (!empty($map['addUserIds'])) {
                $model->addUserIds = $map['addUserIds'];
            }
        }
        if (isset($map['devIds'])) {
            if (!empty($map['devIds'])) {
                $model->devIds = $map['devIds'];
            }
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
