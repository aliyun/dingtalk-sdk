<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemsResponseBody;

use AlibabaCloud\Tea\Model;

class resultItems extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $async;

    /**
     * @example dentry_id
     *
     * @var string
     */
    public $dentryId;

    /**
     * @example permissionDenied
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example recyclebin_id
     *
     * @var string
     */
    public $recycleBinId;

    /**
     * @example recycle_item_id
     *
     * @var string
     */
    public $recycleItemId;

    /**
     * @example space_id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example true
     *
     * @var bool
     */
    public $success;

    /**
     * @example task_id
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'async'         => 'async',
        'dentryId'      => 'dentryId',
        'errorCode'     => 'errorCode',
        'recycleBinId'  => 'recycleBinId',
        'recycleItemId' => 'recycleItemId',
        'spaceId'       => 'spaceId',
        'success'       => 'success',
        'taskId'        => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->async) {
            $res['async'] = $this->async;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->recycleBinId) {
            $res['recycleBinId'] = $this->recycleBinId;
        }
        if (null !== $this->recycleItemId) {
            $res['recycleItemId'] = $this->recycleItemId;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['async'])) {
            $model->async = $map['async'];
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['recycleBinId'])) {
            $model->recycleBinId = $map['recycleBinId'];
        }
        if (isset($map['recycleItemId'])) {
            $model->recycleItemId = $map['recycleItemId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
