<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupRequest\managementOptions;
use AlibabaCloud\Tea\Model;

class UpdateGroupRequest extends Model
{
    /**
     * @var string[]
     */
    public $addExtidlist;

    /**
     * @var string[]
     */
    public $addUseridlist;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $chatid;

    /**
     * @var string[]
     */
    public $delExtidlist;

    /**
     * @var string[]
     */
    public $delUseridlist;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var managementOptions
     */
    public $managementOptions;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $owner;

    /**
     * @var string
     */
    public $ownerType;
    protected $_name = [
        'addExtidlist' => 'add_extidlist',
        'addUseridlist' => 'add_useridlist',
        'chatid' => 'chatid',
        'delExtidlist' => 'del_extidlist',
        'delUseridlist' => 'del_useridlist',
        'icon' => 'icon',
        'managementOptions' => 'managementOptions',
        'name' => 'name',
        'owner' => 'owner',
        'ownerType' => 'ownerType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->addExtidlist) {
            $res['add_extidlist'] = $this->addExtidlist;
        }
        if (null !== $this->addUseridlist) {
            $res['add_useridlist'] = $this->addUseridlist;
        }
        if (null !== $this->chatid) {
            $res['chatid'] = $this->chatid;
        }
        if (null !== $this->delExtidlist) {
            $res['del_extidlist'] = $this->delExtidlist;
        }
        if (null !== $this->delUseridlist) {
            $res['del_useridlist'] = $this->delUseridlist;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->managementOptions) {
            $res['managementOptions'] = null !== $this->managementOptions ? $this->managementOptions->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->ownerType) {
            $res['ownerType'] = $this->ownerType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['add_extidlist'])) {
            if (!empty($map['add_extidlist'])) {
                $model->addExtidlist = $map['add_extidlist'];
            }
        }
        if (isset($map['add_useridlist'])) {
            if (!empty($map['add_useridlist'])) {
                $model->addUseridlist = $map['add_useridlist'];
            }
        }
        if (isset($map['chatid'])) {
            $model->chatid = $map['chatid'];
        }
        if (isset($map['del_extidlist'])) {
            if (!empty($map['del_extidlist'])) {
                $model->delExtidlist = $map['del_extidlist'];
            }
        }
        if (isset($map['del_useridlist'])) {
            if (!empty($map['del_useridlist'])) {
                $model->delUseridlist = $map['del_useridlist'];
            }
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['managementOptions'])) {
            $model->managementOptions = managementOptions::fromMap($map['managementOptions']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['ownerType'])) {
            $model->ownerType = $map['ownerType'];
        }

        return $model;
    }
}
