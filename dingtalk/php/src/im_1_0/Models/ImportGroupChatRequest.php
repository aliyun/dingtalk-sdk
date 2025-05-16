<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ImportGroupChatRequest extends Model
{
    /**
     * @var string[]
     */
    public $adminIds;

    /**
     * @var int
     */
    public $createAt;

    /**
     * @example @lADOADma*****QKA
     *
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example axcf*-*****-*****-23da*
     *
     * @var string
     */
    public $importUuid;

    /**
     * @description This parameter is required.
     *
     * @example 1107****2120
     *
     * @var string
     */
    public $owner;

    /**
     * @example c354***-***-***-b4ea-6f1ab***65
     *
     * @var string
     */
    public $templateId;

    /**
     * @description This parameter is required.
     *
     * @example 示例群名称
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @var UserListValue[]
     */
    public $userList;
    protected $_name = [
        'adminIds' => 'adminIds',
        'createAt' => 'createAt',
        'icon' => 'icon',
        'importUuid' => 'importUuid',
        'owner' => 'owner',
        'templateId' => 'templateId',
        'title' => 'title',
        'userList' => 'userList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminIds) {
            $res['adminIds'] = $this->adminIds;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->importUuid) {
            $res['importUuid'] = $this->importUuid;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userList) {
            $res['userList'] = [];
            if (null !== $this->userList && \is_array($this->userList)) {
                foreach ($this->userList as $key => $val) {
                    $res['userList'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ImportGroupChatRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminIds'])) {
            if (!empty($map['adminIds'])) {
                $model->adminIds = $map['adminIds'];
            }
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['importUuid'])) {
            $model->importUuid = $map['importUuid'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userList'])) {
            $model->userList = $map['userList'];
        }

        return $model;
    }
}
