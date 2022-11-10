<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class RestoreRecycleItemResponseBody extends Model
{
    /**
     * @description 是否是异步任务
     * 如果操作对象有子节点，则会异步处理
     * @var bool
     */
    public $async;

    /**
     * @description 操作对应根节点还原之后的文件id
     * 非失败的情况下同步或者异步都会返回
     * @var string
     */
    public $dentryId;

    /**
     * @description 操作对应根节点还原之后的空间id
     * 非失败的情况下同步或者异步都会返回
     * @var string
     */
    public $spaceId;

    /**
     * @description 异步任务id，用于查询任务执行状态
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'async'    => 'async',
        'dentryId' => 'dentryId',
        'spaceId'  => 'spaceId',
        'taskId'   => 'taskId',
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
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RestoreRecycleItemResponseBody
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
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
