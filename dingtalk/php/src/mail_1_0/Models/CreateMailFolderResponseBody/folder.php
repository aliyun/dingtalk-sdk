<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderResponseBody;

use AlibabaCloud\Tea\Model;

class folder extends Model
{
    /**
     * @var int
     */
    public $childFolderCount;

    /**
     * @var string
     */
    public $displayName;

    /**
     * @var mixed[]
     */
    public $extensions;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $parentFolderId;

    /**
     * @var int
     */
    public $totalItemCount;

    /**
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
     * @return folder
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
