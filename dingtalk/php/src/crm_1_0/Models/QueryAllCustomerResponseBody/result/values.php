<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponseBody\result\values\permission;
use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @description 记录创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建记录的用户昵称
     *
     * @var string
     */
    public $creatorNick;

    /**
     * @description 创建记录的用户ID
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 数据内容
     *
     * @var mixed[]
     */
    public $data;

    /**
     * @description 扩展数据内容
     *
     * @var mixed[]
     */
    public $extendData;

    /**
     * @description 数据ID
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 记录修改时间
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @description 数据类型
     *
     * @var string
     */
    public $objectType;

    /**
     * @description 数据权限信息
     *
     * @var permission
     */
    public $permission;

    /**
     * @description 审批状态
     *
     * @var string
     */
    public $processInstanceStatus;

    /**
     * @description 审批结果
     *
     * @var string
     */
    public $processOutResult;
    protected $_name = [
        'createTime'            => 'createTime',
        'creatorNick'           => 'creatorNick',
        'creatorUserId'         => 'creatorUserId',
        'data'                  => 'data',
        'extendData'            => 'extendData',
        'instanceId'            => 'instanceId',
        'modifyTime'            => 'modifyTime',
        'objectType'            => 'objectType',
        'permission'            => 'permission',
        'processInstanceStatus' => 'processInstanceStatus',
        'processOutResult'      => 'processOutResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = $this->extendData;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }
        if (null !== $this->processInstanceStatus) {
            $res['processInstanceStatus'] = $this->processInstanceStatus;
        }
        if (null !== $this->processOutResult) {
            $res['processOutResult'] = $this->processOutResult;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return values
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['extendData'])) {
            $model->extendData = $map['extendData'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }
        if (isset($map['processInstanceStatus'])) {
            $model->processInstanceStatus = $map['processInstanceStatus'];
        }
        if (isset($map['processOutResult'])) {
            $model->processOutResult = $map['processOutResult'];
        }

        return $model;
    }
}
