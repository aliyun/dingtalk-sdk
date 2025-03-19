<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersResponseBody;

use AlibabaCloud\Tea\Model;

class folders extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $childFolderCount;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $displayName;

    /**
     * @var string[]
     */
    public $extensions;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $parentFolderId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $totalItemCount;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $unreadItemCount;
    protected $_name = [
        'childFolderCount' => 'childFolderCount',
        'displayName' => 'displayName',
        'extensions' => 'extensions',
        'id' => 'id',
        'parentFolderId' => 'parentFolderId',
        'totalItemCount' => 'totalItemCount',
        'unreadItemCount' => 'unreadItemCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->childFolderCount) {
            $res['childFolderCount'] = $this->childFolderCount;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->extensions) {
            $res['extensions'] = $this->extensions;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->parentFolderId) {
            $res['parentFolderId'] = $this->parentFolderId;
        }
        if (null !== $this->totalItemCount) {
            $res['totalItemCount'] = $this->totalItemCount;
        }
        if (null !== $this->unreadItemCount) {
            $res['unreadItemCount'] = $this->unreadItemCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return folders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['childFolderCount'])) {
            $model->childFolderCount = $map['childFolderCount'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['extensions'])) {
            $model->extensions = $map['extensions'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['parentFolderId'])) {
            $model->parentFolderId = $map['parentFolderId'];
        }
        if (isset($map['totalItemCount'])) {
            $model->totalItemCount = $map['totalItemCount'];
        }
        if (isset($map['unreadItemCount'])) {
            $model->unreadItemCount = $map['unreadItemCount'];
        }

        return $model;
    }
}
