<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponseBody\result\values\permission;
use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @example 2019-12-25 15:33:12
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 张三
     *
     * @var string
     */
    public $creatorNick;

    /**
     * @example ding_userid
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @var mixed[]
     */
    public $data;

    /**
     * @var mixed[]
     */
    public $extendData;

    /**
     * @example instance_id
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example 2019-12-25 15:33:12
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @example crm_customer
     *
     * @var string
     */
    public $objectType;

    /**
     * @var permission
     */
    public $permission;

    /**
     * @example COMPLATE
     *
     * @var string
     */
    public $processInstanceStatus;

    /**
     * @example agree
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
