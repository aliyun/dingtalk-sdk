<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryResponseBody\dentry;
use AlibabaCloud\Tea\Model;

class CopyDentryResponseBody extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $async;

    /**
     * @var dentry
     */
    public $dentry;

    /**
     * @example task_id
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'async' => 'async',
        'dentry' => 'dentry',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->async) {
            $res['async'] = $this->async;
        }
        if (null !== $this->dentry) {
            $res['dentry'] = null !== $this->dentry ? $this->dentry->toMap() : null;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyDentryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['async'])) {
            $model->async = $map['async'];
        }
        if (isset($map['dentry'])) {
            $model->dentry = dentry::fromMap($map['dentry']);
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
