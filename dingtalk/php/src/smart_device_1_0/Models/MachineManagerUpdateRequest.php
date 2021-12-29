<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class MachineManagerUpdateRequest extends Model
{
    /**
     * @description 设备id
     *
     * @var int
     */
    public $deviceId;

    /**
     * @description 设备管理员的userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 权限范围：可管理的部门id列表
     *
     * @var int[]
     */
    public $scopeDeptIds;

    /**
     * @description 设备管理员权限点
     *
     * @var bool[]
     */
    public $atmManagerRightMap;

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
        'deviceId'           => 'deviceId',
        'userId'             => 'userId',
        'scopeDeptIds'       => 'scopeDeptIds',
        'atmManagerRightMap' => 'atmManagerRightMap',
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
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->scopeDeptIds) {
            $res['scopeDeptIds'] = $this->scopeDeptIds;
        }
        if (null !== $this->atmManagerRightMap) {
            $res['atmManagerRightMap'] = $this->atmManagerRightMap;
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
     * @return MachineManagerUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['scopeDeptIds'])) {
            if (!empty($map['scopeDeptIds'])) {
                $model->scopeDeptIds = $map['scopeDeptIds'];
            }
        }
        if (isset($map['atmManagerRightMap'])) {
            $model->atmManagerRightMap = $map['atmManagerRightMap'];
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
