<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersResponseBody\result\permission;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $orgId;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $objectType;

    /**
     * @var string
     */
    public $creatorUserId;

    /**
     * @var string
     */
    public $creatorNick;

    /**
     * @var mixed[]
     */
    public $data;

    /**
     * @var mixed[]
     */
    public $extendData;

    /**
     * @var permission
     */
    public $permission;

    /**
     * @var string
     */
    public $appUuid;

    /**
     * @var string
     */
    public $formCode;

    /**
     * @var string
     */
    public $procOutResult;

    /**
     * @var string
     */
    public $procInstStatus;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;
    protected $_name = [
        'orgId'          => 'orgId',
        'instanceId'     => 'instanceId',
        'objectType'     => 'objectType',
        'creatorUserId'  => 'creatorUserId',
        'creatorNick'    => 'creatorNick',
        'data'           => 'data',
        'extendData'     => 'extendData',
        'permission'     => 'permission',
        'appUuid'        => 'appUuid',
        'formCode'       => 'formCode',
        'procOutResult'  => 'procOutResult',
        'procInstStatus' => 'procInstStatus',
        'gmtCreate'      => 'gmtCreate',
        'gmtModified'    => 'gmtModified',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = $this->extendData;
        }
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->procOutResult) {
            $res['procOutResult'] = $this->procOutResult;
        }
        if (null !== $this->procInstStatus) {
            $res['procInstStatus'] = $this->procInstStatus;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
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
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['extendData'])) {
            $model->extendData = $map['extendData'];
        }
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['procOutResult'])) {
            $model->procOutResult = $map['procOutResult'];
        }
        if (isset($map['procInstStatus'])) {
            $model->procInstStatus = $map['procInstStatus'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }

        return $model;
    }
}
