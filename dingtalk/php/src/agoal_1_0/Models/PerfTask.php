<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class PerfTask extends Model
{
    /**
     * @example 328497234
     *
     * @var string
     */
    public $id;

    /**
     * @example y/n
     *
     * @var string
     */
    public $isDeleted;

    /**
     * @example ONGOING
     *
     * @var string
     */
    public $status;

    /**
     * @example xxx考核任务
     *
     * @var string
     */
    public $title;

    /**
     * @example 23223423
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'id' => 'id',
        'isDeleted' => 'isDeleted',
        'status' => 'status',
        'title' => 'title',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PerfTask
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
