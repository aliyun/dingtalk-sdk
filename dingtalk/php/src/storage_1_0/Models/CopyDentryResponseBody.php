<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryResponseBody\dentry;
use AlibabaCloud\Tea\Model;

class CopyDentryResponseBody extends Model
{
    /**
     * @description 是否是异步任务
     * 如果操作对象有子节点，则会异步处理
     * @var bool
     */
    public $async;

    /**
     * @description 文件信息
     *
     * @var dentry
     */
    public $dentry;

    /**
     * @description 任务id，用于查询任务执行状态
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'async'  => 'async',
        'dentry' => 'dentry',
        'taskId' => 'taskId',
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
