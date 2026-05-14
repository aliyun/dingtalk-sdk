<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateGroupRequest\managementOptions;
use AlibabaCloud\Tea\Model;

class CreateGroupRequest extends Model
{
    /**
     * @var int
     */
    public $conversationTag;

    /**
     * @var string[]
     */
    public $extidlist;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var managementOptions
     */
    public $managementOptions;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $owner;

    /**
     * @var string
     */
    public $ownerType;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $useridlist;
    protected $_name = [
        'conversationTag' => 'conversationTag',
        'extidlist' => 'extidlist',
        'icon' => 'icon',
        'managementOptions' => 'managementOptions',
        'name' => 'name',
        'owner' => 'owner',
        'ownerType' => 'ownerType',
        'useridlist' => 'useridlist',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationTag) {
            $res['conversationTag'] = $this->conversationTag;
        }
        if (null !== $this->extidlist) {
            $res['extidlist'] = $this->extidlist;
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
        if (null !== $this->useridlist) {
            $res['useridlist'] = $this->useridlist;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationTag'])) {
            $model->conversationTag = $map['conversationTag'];
        }
        if (isset($map['extidlist'])) {
            if (!empty($map['extidlist'])) {
                $model->extidlist = $map['extidlist'];
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
        if (isset($map['useridlist'])) {
            if (!empty($map['useridlist'])) {
                $model->useridlist = $map['useridlist'];
            }
        }

        return $model;
    }
}
