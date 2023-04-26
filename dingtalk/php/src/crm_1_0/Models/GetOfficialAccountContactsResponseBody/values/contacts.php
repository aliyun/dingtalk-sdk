<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsResponseBody\values;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsResponseBody\values\contacts\permission;
use AlibabaCloud\Tea\Model;

class contacts extends Model
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
     * @var permission
     */
    public $permission;
    protected $_name = [
        'createTime'    => 'createTime',
        'creatorNick'   => 'creatorNick',
        'creatorUserId' => 'creatorUserId',
        'data'          => 'data',
        'extendData'    => 'extendData',
        'instanceId'    => 'instanceId',
        'modifyTime'    => 'modifyTime',
        'permission'    => 'permission',
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
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contacts
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
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }

        return $model;
    }
}
