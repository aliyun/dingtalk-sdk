<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersResponseBody\result\permission;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $appUuid;

    /**
     * @var string
     */
    public $creatorNick;

    /**
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
     * @var string
     */
    public $formCode;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $objectType;

    /**
     * @var permission
     */
    public $permission;

    /**
     * @var string
     */
    public $procInstStatus;

    /**
     * @var string
     */
    public $procOutResult;
    protected $_name = [
        'appUuid'        => 'appUuid',
        'creatorNick'    => 'creatorNick',
        'creatorUserId'  => 'creatorUserId',
        'data'           => 'data',
        'extendData'     => 'extendData',
        'formCode'       => 'formCode',
        'gmtCreate'      => 'gmtCreate',
        'gmtModified'    => 'gmtModified',
        'instanceId'     => 'instanceId',
        'objectType'     => 'objectType',
        'permission'     => 'permission',
        'procInstStatus' => 'procInstStatus',
        'procOutResult'  => 'procOutResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
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
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }
        if (null !== $this->procInstStatus) {
            $res['procInstStatus'] = $this->procInstStatus;
        }
        if (null !== $this->procOutResult) {
            $res['procOutResult'] = $this->procOutResult;
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
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
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
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }
        if (isset($map['procInstStatus'])) {
            $model->procInstStatus = $map['procInstStatus'];
        }
        if (isset($map['procOutResult'])) {
            $model->procOutResult = $map['procOutResult'];
        }

        return $model;
    }
}
