<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateSceneGroupConversationRequest\managementOptions;
use AlibabaCloud\Tea\Model;

class CreateSceneGroupConversationRequest extends Model
{
    /**
     * @description 功能增强
     *
     * @var string[]
     */
    public $features;

    /**
     * @description 群名称。
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 群主(钉外用户)userId。
     *
     * @var string
     */
    public $groupOwnerId;

    /**
     * @description 群头像。
     *
     * @var string
     */
    public $icon;

    /**
     * @var managementOptions
     */
    public $managementOptions;

    /**
     * @description 群模板Id。
     *
     * @var string
     */
    public $templateId;

    /**
     * @var string[]
     */
    public $userIdList;

    /**
     * @description 建群去重的业务ID。
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'features'          => 'features',
        'groupName'         => 'groupName',
        'groupOwnerId'      => 'groupOwnerId',
        'icon'              => 'icon',
        'managementOptions' => 'managementOptions',
        'templateId'        => 'templateId',
        'userIdList'        => 'userIdList',
        'uuid'              => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->features) {
            $res['features'] = $this->features;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupOwnerId) {
            $res['groupOwnerId'] = $this->groupOwnerId;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->managementOptions) {
            $res['managementOptions'] = null !== $this->managementOptions ? $this->managementOptions->toMap() : null;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSceneGroupConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['features'])) {
            $model->features = $map['features'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupOwnerId'])) {
            $model->groupOwnerId = $map['groupOwnerId'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['managementOptions'])) {
            $model->managementOptions = managementOptions::fromMap($map['managementOptions']);
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
